var page = 0;
var pagesize = 16;
getAllEvent(bindingEvent,true);
//get event
function getAllEvent(callback,bol) {
    $.ajax({
        type: "get",
        url: linkserver + "Discount/GetAllDiscount?page=" + page + "&pagesize=" + pagesize,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert({
                title: "Error",
                message: err.message,
                size: 'small'
            });
        },
        success: function (data) {
            if (data.success) {
                callback(data,bol);
            }
            else {
                bootbox.alert({
                    title: "Error",
                    message: data.error.message,
                    size: 'small'
                });
            }
        }
    });
}

//lazyload user
$(window).scroll(function () {
    if ($(window).scrollTop() + $(window).height() === $(document).height()) {
        page = page + 1;
        getAllEvent(bindingEvent,false);
    }
});

function bindingEvent(data, bol) {
    if (bol) {
        $(".bd-f-bd-ev").remove();
    }
    if (data.success && data.data.length>0) {
        for (var i in data.data) {
            var item = data.data[i];
            var discount = "";
            if (item.money == 0) {
                discount = item.percent + " %";
            }
            else {
                discount = formatNumber(item.money) + " vnđ";
            }
            var stt = "Enable";
            if (parseDate(currentDate()).getTime() > parseDate(formatDate(new Date(item.endday))).getTime()) {
                stt = "Disble";
            }
            $(".f-all-event").append('<div class="k bd-f-bd-ev">' +
                '<div class= "k f-body-ev">' +
                '<div class="k f-it-bd-ev">' +
                '<span class="k t-le-te">Event name: </span>' +
                '<span class="k t-ev">' + item.eventname + '</span>' +
                '</div>' +
                '<div class="k f-it-bd-ev">' +
                '<span class="k t-le-te">Code: </span>' +
                '<span class="k t-ev" id="code">' + item.code + '</span>' +
                '</div>' +
                '<div class="k f-it-bd-ev">' +
                '<span class="k t-le-te">Discount: </span>' +
                '<span class="k t-ev">' + discount + '</span>' +
                '</div>' +
                '<div class="k f-it-bd-ev">' +
                '<span class="k t-le-te">Start day: </span>' +
                '<span class="k t-ev">' + formatDate(new Date(item.startday)) + '</span>' +
                '</div>' +
                '<div class="k f-it-bd-ev">' +
                '<span class="k t-le-te">End day: </span>' +
                '<span class="k t-ev">' + formatDate(new Date(item.endday)) + '</span>' +
                '</div>' +
                '<div class="k f-it-bd-ev">' +
                '<span class="k t-le-te">Status: </span>' +
                '<span class="k t-ev" id="status">' + stt + '</span>' +
                '</div>' +
                '</div>' +
                '</div>');
            emtyForm();
        }
    }
}
function currentDate() {
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    today = dd + '/' + mm + '/' + yyyy;
    return today;
}
//format datetime
function formatDate(date) {
    var hours = date.getHours();
    var minutes = date.getMinutes();
    var ampm = hours >= 12 ? 'pm' : 'am';
    hours = hours % 12;
    hours = hours ? hours : 12; // the hour '0' should be '12'
    minutes = minutes < 10 ? '0' + minutes : minutes;
    var strTime = hours + ':' + minutes + ' ' + ampm;
    var month = (date.getMonth() + 1) < 10 ? '0' + (date.getMonth() + 1) : (date.getMonth() + 1);
    var day = date.getDate() < 10 ? '0' + date.getDate() : date.getDate();
    return day + "/" + month + "/" + date.getFullYear();
}

//insert the event
function insertEvent() {
    var name = $("#name-ev").val();
    var dismoney = $("#dis-money").val();
    if (dismoney == "") {
        dismoney = 0;
    }
    var dispercent = $("#dis-percent").val();
    if (dispercent == "") {
        dispercent = 0;
    }
    var stday = $("#st-day").val();
    var endday = $("#end-day").val();
    if (checkDataForm(name, dismoney, dispercent, stday, endday)) {
        var data = { "eventname": name, "stt": 0, "startday": stday, "endday": endday, "note": "", "percent": dispercent, "money": dismoney };
        $.ajax({
            url: linkserver + 'Discount/InsertDiscount',
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
                if (data.success) {
                    bootbox.alert({
                        title: "Advertise",
                        message: "Code of event: " + data.data,
                        size: 'small'
                    });
                    getAllEvent();
                }
                else {
                    bootbox.alert({
                        message: "" + data.error.message,
                        size: 'small'
                    });
                }
            }
        });
    }

}
//emty form
function emtyForm() {
    $("#name-ev").val("");
    $("#dis-money").val("");
    $("#dis-percent").val("");
}
//check data form insert
function checkDataForm(name, dismoney, dispercent, stday, endday) {
    var bool = true;
    if (name == "") {
        $("#name-ev").css("border", "1px solid red");
        bool = true;
    }
    else {
        $("#name-ev").css("border", "1px solid rgba(51,51,51,0.1)");
        bool = false;
    }
    if (dismoney != "" || (dispercent != "" && parseInt(dispercent) < 100)) {
        $("#dis-money").css("border", "1px solid rgba(51,51,51,0.1)");
        $("#dis-percent").css("border", "1px solid rgba(51,51,51,0.1)");
        bool = true;
    }
    else {
        if (parseInt(dispercent) > 100) {
            $("#dis-percent").css("border", "1px solid red");
            bool = false;
        }
        else {
            $("#dis-money").css("border", "1px solid red");
            $("#dis-percent").css("border", "1px solid red");
            bool = false;
        }
    }
    if (parseDate(stday).getTime() <= parseDate(endday).getTime()) {
        $(".error-day").hide();
        bool = true;
    }
    else {
        $(".error-day").show();
        bool = false;
    }
    return bool;
}
//Delete the event
function deleteEvent() {
    //
}
//update the event 
function updateEvent() {
    //
}

//date time picker
$(document).ready(function () {
    $('#datepicker-startday').datetimepicker({
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
    $('#datepicker-endday').datetimepicker({
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

    //only number
    $("#dis-money").keypress(function (e) {
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
            return false;
        }
    });
    $("#dis-percent").keypress(function (e) {
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
            return false;
        }
    });
});

//part string to day
function parseDate(str) {
    var mdy = str.split('/');
    return new Date(mdy[2], mdy[1], mdy[0]);
}
//change key press
function changeKeyPress(obj) {
    var text = $(obj).val().toString();
    var str = formatNumber(covertToString(text));
    $(obj).val(str);
}
function covertToString(str) {
    var strint = str.replace(/,/g, '');
    return strint;
}

//show form add the event
var bolshowf = true;
function showFormAddEv() {
    if (bolshowf) {
        $("#tab-addnew-ev").show(300);
        bolshowf = false;
        $("#bnt-show-t-add-ev").removeClass("fa-plus-square");
        $("#bnt-show-t-add-ev").addClass("fa-minus-square");
    }
    else {
        $("#tab-addnew-ev").hide(300);
        bolshowf = true;
        $("#bnt-show-t-add-ev").removeClass("fa-minus-square");
        $("#bnt-show-t-add-ev").addClass("fa-plus-square");
    }
}

//filter event 
function filterEventBySearchBox(obj, callback) {
    var data = { "filter": $(obj).val() };
    $.ajax({
        url: linkserver + 'discount/FilterDiscountBySearchBox',
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