
//var lnid = 0;
var listFile = [];
var formData = new FormData();
//get lines products
callAjax(tp.get, "lineproduct/GetAllLineProduct", null, bindingGetAllLnPr);
function bindingGetAllLnPr(data) {
    if (data) {
        for (var i in data) {
            $(".f-ln-prd").remove();
            $("#f-ln-prd").append('<div class="k bd-prd" onclick= "filterLinePr(' + data[i].lineprid + ')">' +
                '<div class="k ic-pdt" ></div >' +
                '<span class="k t t-name-pr">' + data[i].linename + '</span>' +
                '<div class="k ic-next"></div>' +
                '</div >');
            $("#sl-lnpr").append("<option value=" + data[i].lineprid + ">" + data[i].linename + "</option>");
        }
        callAjax(tp.get, "products/GetByLine?id=" + data[0].lineprid, null, bindingPdtByLine);
    }
}
function filterLinePr(id) {
    callAjax(tp.get, "products/GetByLine?id=" + id, null, bindingPdtByLine);
}
//products by line products
function bindingPdtByLine(data) {
    if (data) {
        $(".item-pr-form").remove();
        for (var i in data) {
            $("#f-it-products").append('<div class="k item-pr-form">' +
                '<div class= "k img-pdt"style="background-image:url(' + serverfile + data[i].image + ')" ></div>' +
                '<div class="k f-pdt-name">' +
                '<span class="k t name-product">' + data[i].prname + '</span>' +
                '<span class="k t total-pdt">Total: ' + data[i].total + '</span>' +
                '</div>' +
                '<div class="k f-pdt-name">' +
                '<span class="k t name-product">Saleprice: ' + data[i].price + '</span>' +
                '<span class="k t total-pdt">Import price: ' + data[i].importprice + '</span>' +
                '<span class="k t total-pdt">Manufacturing date: ' + formatDate(new Date(data[i].mnday)) + '</span>' +
                '<span class="k t t-warning">Expiry date: ' + formatDate(new Date(data[i].expirydate)) + '</span>' +
                '<div class="k ic_delete_pdt" onclick="deleteProduct(' + data[i].prid+')"></div>' +
                '<div class="k ic_edit_pdt"></div>' +
                '</div>' +
                '</div>');
        }
    }
}
function formatDate(date) {
    var hours = date.getHours();
    var minutes = date.getMinutes();
    var ampm = hours >= 12 ? 'pm' : 'am';
    hours = hours % 12;
    hours = hours ? hours : 12; // the hour '0' should be '12'
    minutes = minutes < 10 ? '0' + minutes : minutes;
    var strTime = hours + ':' + minutes + ' ' + ampm;
    var month = date.getMonth() + 1;
    return date.getDate() + "/" + month + "/" + date.getFullYear();
}
//insert a product
function insertLnPr() {
    var namecat = { "linename": $("#ip-name-ctl").val() };
    callAjax(tp.post, "lineproduct/InsertLineProduct", JSON.stringify(namecat), resultInsert);
}
//result after insert product
function resultInsert(data) {
    $('#myModal2').modal('toggle');//colse modal
}
//select multi imge
function getImage() {
    $("#multi-file").click();
    $("#multi-file").change(function () {
        readImageUpload(this);
    });
}
function getImageIt() {
    $("#multi-file-it").click();
    $("#multi-file-it").change(function () {
        readImageUploadIt(this);
    });
}
function readImageUpload(input) {
    if (!input.files[0].name.toLowerCase().match(/\.(jpg|jpeg|png|gif)$/)) {
        toastr.info("", " Vui lòng chọn hình ảnh có đuôi(*.jpg | *.jpeg | *.png | *.gif)", 2000);
        return false;
    }
    if (input.files[0].size / 1024 / 1024 > 10) {
        toastr.info("", "Vui lòng upload hình dung lượng dưới 10MB", 2000);
        return false;
    }
    if (input.files && input.files[0]) {
        formData.append("imagerq", input.files[0]);
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#img-main").css("background-image", "url(" + e.target.result + ")");
            $("#img-main").css("color", "rgba(51,51,51,0)");
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file").val("");
}
var totalimg = 0;
function readImageUploadIt(input) {
    if (totalimg >= 5) {
        totalimg = 5;
        $("#bnt-add-it-img").hide();
    }
    if (input.files.length >= 5) {
        $("#bnt-add-it-img").hide();
    }
    for (var i = 0; i < input.files.length; i++) {
        totalimg++;
        listFile.push(input.files[i]);
        if (totalimg < 6) {
            var reader1 = new FileReader();
            reader1.name = input.files[i].name;
            reader1.addEventListener('load', function (e) {
                var picFile = e.target;
                $(".bd-img-it-lv2").append('<div class="k bd-img-view-it">' +
                    '<div class= "k img-view-it"style="background-image:url(' + e.target.result + ')"title="' + picFile.name + '" ></div >' +
                    ' <i class="fa fa-times" aria-hidden="true" id="bnt-remove"></i>' +
                    '</div');
            });
            reader1.readAsDataURL(input.files[i]);
        }
    }
   // $("#multi-file-it").val("");
}
//remove image item
$(document).on("click", "#bnt-remove", function () {
    $(this).parent().remove();
    totalimg--;
    if (totalimg < 5) {
        $("#bnt-add-it-img").show();
    }
    var removeFile = $(this).parent().find('.img-view-it').attr('title');
    var index = listFile.findIndex(function (o) {
        return o.name === removeFile;
    });
    listFile.splice(index, 1);
});
$(document).ready(function () {
    $('#datepicker').datetimepicker({
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
$(document).ready(function () {
    $('#datepicker1').datetimepicker({
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

//insert a product
function insertProduct() {
   
    formData.append('prname', $('#pr-name').val());
    formData.append('total', $('#total-pr').val());
    formData.append('importprice', $('#import-price').val());
    formData.append('price', $('#sale-price').val());
    formData.append('mnday', $('#mn-day').val());
    formData.append('expirydate', $('#ex-day').val());
    formData.append('lineprid', parseInt($('#sl-lnpr').val()));
    for (var i = 0; i < listFile.length; i++) {
        formData.append("files", listFile[i]);
    }
    //callAjaxInsert(tp.post,"File/InseretProduct",formData,resultInsertProduct);
    $.ajax({
        url: linkserver + 'File/InseretProduct',
        type: 'POST',
        dataType: 'json',
        async: false,
        data: formData,
        processData: false,
        contentType: false,
        error: function (err) {
            alert('error' + err);
        },
        success: function (data) {
            alert('insert success');

        }
    });
}
function resultInsertProduct() {
    alert("fasdf");
}
function deleteProduct(id) {
    $.ajax({
        url: linkserver +"file/DeleteProduct?id="+ id,
        type: 'POST',
        dataType: 'json',
        async: false,
        data: null,
        processData: false,
        contentType: false,
        error: function (err) {
            alert('error');
        },
        success: function (data) {
            alert('delete success');

        }
    });
}