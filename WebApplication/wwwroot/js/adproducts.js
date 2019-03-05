
//line products
//callAjax(tp.get, "lineproduct/GetAllLineProduct", null, bindingGetAllLnPr);
function bindingGetAllLnPr(data) {
    if (data) {
        for (var i in data) {
            $(".f-ln-prd").remove();
            $("#f-ln-prd").append('<div class="k bd-prd" onclick= "filterLinePr(' + data[i].lineprid + ')">' +
                '<div class="k ic-pdt" ></div >' +
                '<span class="k t t-name-pr">' + data[i].linename + '</span>' +
                '<div class="k ic-next"></div>' +
                '</div >');
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
                '<div class="k ic_delete_pdt"></div>' +
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
function insertPr() {
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
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#img-main").css("background-image", "url(" + e.target.result + ")");
            $("#img-main").css("color", "rgba(51,51,51,0)");
        };
        reader.readAsDataURL(input.files[0]);
    }
    input.clear();
}
var totalimg = 0;
var po = 0;
function readImageUploadIt(input) {
    if (totalimg >= 5) {
        totalimg = 5;
        $("#bnt-add-it-img").hide();
    }
    //if (!input.files[0].name.toLowerCase().match(/\.(jpg|jpeg|png|gif)$/)) {
    //    toastr.info("", " Vui lòng chọn hình ảnh có đuôi(*.jpg | *.jpeg | *.png | *.gif)", 2000);
    //    return false;
    //}
    //if (input.files[0].size / 1024 / 1024 > 10) {
    //    toastr.info("", "Vui lòng upload hình dung lượng dưới 10MB", 2000);
    //    return false;
    //}
    for (var i = 0; i < input.files.length; i++) {
        totalimg++;
        if (totalimg < 6) {
            var reader1 = new FileReader();
            reader1.onload = function (e) {
                $(".bd-img-it-lv2").append('<div class="k bd-img-view-it"id="f-img-it' + po +'">' +
                    '<div class= "k img-view-it"style="background-image:url(' + e.target.result + ')" ></div >' +
                    ' <i class="fa fa-times" aria-hidden="true"onclick="removeImg(' + po +')"></i>' +
                    '</div');
            };
            reader1.readAsDataURL(input.files[i]);
        }
        po = po + 1;
    }
    $("#multi-file-it").val('');
}
function removeImg(x) {
    $('#f-img-it' + x).remove();
    totalimg--;
    if (totalimg < 5) {
        $("#bnt-add-it-img").show();    
    }
}
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
        },
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
        },
    });
});