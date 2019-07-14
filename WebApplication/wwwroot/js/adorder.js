var page = 0;
getInvoidFrSv(0, bindingNewInvoidFrSv,true);
getInvoidFrSv(1, bindingOldInvoidFrSv,true);

var istab = true;
function getInvoidFrSv(active, callback,bol) {
    $.ajax({
        type: "get",
        url: linkserver + "invoice/getivbyactive?active=" + active +"&page="+page+"&pagesize=5",
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
        },
        success: function (data,bol) {
            callback(data);
        }
    });
}
function addInvoidSocket(data) {
    var item = data.data.data.invoi;
    var view = '';
    for (var j in data.data.data.invoiceproduct) {
        var prd = data.data.data.invoiceproduct[j];
        view += '<div class="k item-prd">' +
            '<div class="k img-prd"style="background-image:url(' + serverfile + prd.product.image + ')"></div > ' +
            '<div class="k f-dt-it">' +
            '<span class="k t t-dt-od">' + prd.product.prname + '</span>' +
            '<span class="k n-tt-prd">Total:</span>' +
            '<span class="k tt-prd">' + prd.invoidprd.total + '</span>' +
            '</div>' +
            '</div>';
    }

    $("#f-ap-it-iv").append('<div class=" k bd-tab-it-od">' +
        '<div class= "k tab-it-od">' +
        '<div class="k tab-l-it-od">' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Order code: </span>' +
        '<span class="k t t-main-od">' + item.codeinvoice + '</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Name custemer: </span>' +
        '<span class="k t t-main-od">' + item.namecustomer + '</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Phone number: </span>' +
        '<span class="k t t-main-od">' + item.phonenumber + '</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Adress: </span>' +
        '<span class="k t t-main-od">' + item.adress + '</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Email: </span>' +
        '<span class="k t t-main-od">' + item.email + '</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Total money: </span>' +
        '<span class="k t t-main-od">' + formatNumber(item.totalmoney) + ' đ</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Code discount: </span>' +
        '<span class="k t t-main-od">' + (item.codediscount != null ? item.codediscount : '0') + '</span>' +
        '</div>' +
        '<div class="k tab-sml-od">' +
        '<span class="k t t-note-od">Note: </span>' +
        '<span class="k t t-main-od">' + (item.note != null ? item.note : '') + '</span>' +
        '</div>' +
        '</div>' +
        '<div class="k tab-r-it-od">' +
        //product here
        view +
        '<span class="bnt-success-it"onclick="successOrder(' + item.ivid + ')">Success</span>' +
        '</div>' +
        '</div>' +
        '</div>');

}
function bindingNewInvoidFrSv(data, bol) {
    if (bol) {
        $(".bd-tab-it-od").remove();
    }
    if (data.success && data.data.length > 0) {
        for (var i in data.data) {
            var item = data.data[i].invoi;
            var view = '';
            for (var j in data.data[i].invoiceproduct) {
                var prd = data.data[i].invoiceproduct[j];
                view += '<div class="k item-prd">' +
                    '<div class="k img-prd"style="background-image:url(' + serverfile + prd.product.image + ')"></div > ' +
                    '<div class="k f-dt-it">' +
                    '<span class="k t t-dt-od">' + prd.product.prname + '</span>' +
                    '<span class="k n-tt-prd">Total:</span>' +
                    '<span class="k tt-prd">' + prd.invoidprd.total + '</span>' +
                    '</div>' +
                    '</div>';
            }

            $("#f-ap-it-iv").append('<div class=" k bd-tab-it-od">' +
                '<div class= "k tab-it-od">' +
                '<div class="k tab-l-it-od">' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Order code: </span>' +
                '<span class="k t t-main-od">' + item.codeinvoice + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Name custemer: </span>' +
                '<span class="k t t-main-od">' + item.namecustomer + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Phone number: </span>' +
                '<span class="k t t-main-od">' + item.phonenumber + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Adress: </span>' +
                '<span class="k t t-main-od">' + item.adress + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Email: </span>' +
                '<span class="k t t-main-od">' + item.email + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Total money: </span>' +
                '<span class="k t t-main-od">' + formatNumber(item.totalmoney) + ' đ</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Code discount: </span>' +
                '<span class="k t t-main-od">' + (item.codediscount != null ? item.codediscount : '0') + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Note: </span>' +
                '<span class="k t t-main-od">' + (item.note != null ? item.note : '') + '</span>' +
                '</div>' +
                '</div>' +
                '<div class="k tab-r-it-od" id="tab-r-it-od' + i + '">' +
                //product here
                view +
                '<span class="bnt-success-it"onclick="successOrder(' + item.ivid + ')">Success</span>' +
                '</div>' +
                '</div>' +
                '</div>');

        }
    }
}

function bindingOldInvoidFrSv(data, bol) {
    if (bol) {
        $(".bd-tab-itold-od").remove();
    }
    if (data.success && data.data.length > 0) {
        for (var i in data.data) {
            var item = data.data[i].invoi;

            var view = '';
            for (var j in data.data[i].invoiceproduct) {
                var prd = data.data[i].invoiceproduct[j];
                view += '<div class="k item-prd">' +
                    '<div class="k img-prd"style="background-image:url(' + serverfile + prd.product.image + ')"></div > ' +
                    '<div class="k f-dt-it">' +
                    '<span class="k t t-dt-od">' + prd.product.prname + '</span>' +
                    '<span class="k n-tt-prd">Total:</span>' +
                    '<span class="k tt-prd">' + prd.invoidprd.total + '</span>' +
                    '</div>' +
                    '</div>';
            }

            $("#f-ap-it-oldiv").append('<div class=" k bd-tab-itold-od">' +
                '<div class= "k tab-it-od">' +
                '<div class="k tab-l-it-od">' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Order code: </span>' +
                '<span class="k t t-main-od">' + item.codeinvoice + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Name custemer: </span>' +
                '<span class="k t t-main-od">' + item.namecustomer + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Phone number: </span>' +
                '<span class="k t t-main-od">' + item.phonenumber + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Adress: </span>' +
                '<span class="k t t-main-od">' + item.adress + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Email: </span>' +
                '<span class="k t t-main-od">' + item.email + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Total money: </span>' +
                '<span class="k t t-main-od">' + formatNumber(item.totalmoney) + ' đ</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Code discount: </span>' +
                '<span class="k t t-main-od">' + (item.codediscount != null ? item.codediscount : '0') + '</span>' +
                '</div>' +
                '<div class="k tab-sml-od">' +
                '<span class="k t t-note-od">Note: </span>' +
                '<span class="k t t-main-od">' + (item.note != null ? item.note : '') + '</span>' +
                '</div>' +
                '</div>' +
                '<div class="k tab-r-it-od" id="tab-r-it-od' + i + '">' +
                view +
                '</div>' +
                '</div>' +
                '</div>');

        }
    }
}

function changeTab(bool) {
    page = 0;
    if (bool) {
        $("#f-ap-it-iv").show();
        $("#f-ap-it-oldiv").hide();
        $(".bnt-old-od").css('background-color','white');
        $(".bnt-new-od").css('background-color', '#ef7147');
        $("#view-new-od").text("0");
        getInvoidFrSv(0, bindingNewInvoidFrSv);
        istab = true;
    }
    else {
        $("#f-ap-it-oldiv").show();
        $("#f-ap-it-iv").hide();
        $(".bnt-new-od").css('background-color', 'white');
        $(".bnt-old-od").css('background-color', '#ef7147');

        getInvoidFrSv(1, bindingOldInvoidFrSv);
        istab = false;
    }
}

function successOrder(id) {
    var data = { "ivid":id };
    $.ajax({
        url: linkserver + 'invoice/UpdateInvoice',
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(data),
        async: false,
        processData: false,
        contentType: "application/json",
        error: function (err) {
            bootbox.alert({
                message: "Error :" + err.message
            });
        },
        success: function (data) {
            getInvoidFrSv(0, bindingNewInvoidFrSv);
            getInvoidFrSv(1, bindingOldInvoidFrSv);
        }
    });
}


function filterOrder(callback) {
    var startday = $("#startday").val();
    var endday = $("#endday").val();
    var data = { "startday": startday, "endday": endday };
    $.ajax({
        url: linkserver + 'invoice/filterByDay',
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(data),
        async: false,
        processData: false,
        contentType: "application/json",
        error: function (err) {
            bootbox.alert({
                message: "Error :" + err.message
            });
        },
        success: function (data) {
            callback(data);
        }
    });
}
function filterOrderBySearchBox(callback) {
    var data = { "filterBy": $(".search-order").val() };
    $.ajax({
        url: linkserver + 'invoice/FilterBySearchBox',
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(data),
        async: false,
        processData: false,
        contentType: "application/json",
        error: function (err) {
            bootbox.alert({
                message: "Error :" + err.message
            });
        },
        success: function (data) {
            callback(data);
        }
    });
}

function bindingDataFilter(data) {
    if (istab) {
        bindingNewInvoidFrSv(data);
    }
    else {
        bindingOldInvoidFrSv(data);
    }
}

$(document).ready(function () {
    $('#datepicker-stday,#datepicker-endday').datetimepicker({
        format: 'DD/MM/YYYY',
        extraFormats: false,
        stepping: 1,
        minDate: false,
        maxDate: false,
        useCurrent: true,
        collapse: true,
        locale: moment.locale(),
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
        icons: {
            time: 'glyphicon glyphicon-time',
            date: 'glyphicon glyphicon-calendar',
            up: 'glyphicon glyphicon-chevron-up',
            down: 'glyphicon glyphicon-chevron-down',
            previous: 'glyphicon glyphicon-chevron-left',
            next: 'glyphicon glyphicon-chevron-right',
            today: 'glyphicon glyphicon-screenshot',
            clear: 'glyphicon glyphicon-trash'
        },
        useStrict: false,
        sideBySide: false,
        daysOfWeekDisabled: [],
        calendarWeeks: false,
        viewMode: 'days',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});


//lazyload invoice
$(window).scroll(function () {
    if ($(window).scrollTop() + $(window).height() === $(document).height()) {
        if (istab) {
            page = page + 1;
            getInvoidFrSv(0, bindingNewInvoidFrSv,false);
        }
        else {
            page = page + 1;
            getInvoidFrSv(0, bindingNewInvoidFrSv,false);
        }
    }
});
//$(window).scroll(function () {
//    if ($(window).scrollTop() + $(window).height() > $(document).height() - 100) {
//        alert("near bottom!");
//    }
//});