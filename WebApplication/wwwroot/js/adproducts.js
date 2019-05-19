﻿var lnid = 0;
var listFile = [];
var listFileUd = [];
var listFileUdOld = [];
var formDataUd = null;
var formData = new FormData();

var listLnPr = [];
//get lines products
callAjax(tp.get, "lineproduct/GetAllLineProduct", null, bindingGetAllLnPr);
function bindingGetAllLnPr(data) {
    if (data) {
        $(".bd-prd").remove();
        for (var i in data) {
            listLnPr.push(data[i]);
            $("#f-ln-prd").append('<div class="k bd-prd" onclick= "filterLinePr(' + data[i].lineprid + ')">' +
                '<div class="k ic-pdt" ></div >' +
                '<span class="k t t-name-pr">' + data[i].linename + '</span>' +
                '<div class="k ic-next"></div>' +
                '</div >');
            $("#sl-lnpr").append("<option value=" + data[i].lineprid + ">" + data[i].linename + "</option>");
        }
        callAjax(tp.get, "products/GetByLine?id=" + data[0].lineprid, null, bindingPdtByLine);
        lnid = data[0].lineprid;
        document.getElementById('ip-name-ctl').value = '';
    }
}
function filterLinePr(id) {
    lnid = id;
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
                '<div class="k ic_delete_pdt" onclick="deleteProduct(' + data[i].prid + ')"></div>' +
                '<div class="k ic_edit_pdt" onclick="getPrById(' + data[i].prid + ')" data-toggle="modal" data-target="#myModal-ud"></div>' +
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
    callAjax(tp.get, "lineproduct/GetAllLineProduct", null, bindingGetAllLnPr);
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
    $("#multi-file-it").val("");
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
    $.ajax({
        url: linkserver + 'File/InseretProduct',
        type: 'POST',
        dataType: 'json',
        async: false,
        data: formData,
        processData: false,
        contentType: false,
        error: function (err) {
            bootbox.alert("Error: " + err);
        },
        success: function (data) {
            bootbox.alert("Insert item success!");
            callAjax(tp.get, "products/GetByLine?id=" + lnid, null, bindingPdtByLine);
        }
    });
}
function resultInsertProduct() {
    alert("fasdf");
}
function deleteProduct(id) {
    bootbox.confirm({
        message: "Delete item?",
        buttons: {
            confirm: {
                label: 'Yes',
                className: 'btn-success'
            },
            cancel: {
                label: 'No',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: linkserver + "file/deleteproduct?id=" + id,
                    type: 'post',
                    datatype: 'json',
                    async: false,
                    data: null,
                    processdata: false,
                    contenttype: false,
                    error: function (err) {
                        bootbox.alert({
                            message: "Error: " + err,
                            backdrop: true
                        });
                    },
                    success: function (data) {
                        bootbox.alert({
                            message: "Delete item success! ",
                            backdrop: true
                        });
                        callAjax(tp.get, "products/GetByLine?id=" + lnid, null, bindingPdtByLine);
                    }
                });
            }
            else {
                //
            }
        }
    });

}
//update products-----------------------------------------------
$(document).ready(function () {
    $('#datepicker-ud').datetimepicker({
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
    $('#datepicker1-ud').datetimepicker({
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
//get products by id
function getPrById(id) {
    formDataUd = new FormData()
    callAjax(tp.get, "products/GetPrById?id=" + id, null, bindingPrbyId);
}
var totalimg_ud = 0;
function bindingPrbyId(data) {
    if (data) {
        formDataUd.append('prid', data[0].product.prid);
        $('#pr-name-ud').val(data[0].product.prname);
        $('#total-pr-ud').val(data[0].product.total);
        $('#sale-price-ud').val(data[0].product.price);
        $('#import-price-ud').val(data[0].product.importprice);
        $('#opt-ud').remove();
        for (var i in listLnPr) {
            if (listLnPr[i].lineprid != data[0].product.lineprid) {
                $("#sl-lnpr-ud").append('<option value="' + listLnPr[i].lineprid + '" id="opt-ud">' + listLnPr[i].linename + '</option>');
            }
            else {
                $("#sl-lnpr-ud").append('<option value="' + listLnPr[i].lineprid + '" id="opt-ud"  selected="selected">' + listLnPr[i].linename + '</option>');
            }
        }
        $('#mn-day-ud').val(formatDate(new Date(data[0].product.mnday)));
        $('#ex-day-ud').val(formatDate(new Date(data[0].product.expirydate)));
        //image main
        $('#img-main-ud').css("background-image", "url(" + serverfile + data[0].product.image + ")");
        $("#img-main-ud").css("color", "rgba(51,51,51,0)");
        //image item
        totalimg_ud = data[0].images.length;
        for (var j in data[0].images) {
            var x = { "imgid": data[0].images[j].imgid, "image": data[0].images[j].image, "check": true };
            listFileUdOld.push(x);
            $("#list-img-it-ud").append('<div class="k bd-img-view-it-up">' +
                '<div class= "k img-view-it"style="background-image:url(' + serverfile + data[0].images[j].image + ')"></div >' +
                ' <i class="fa fa-times" aria-hidden="true" id="bnt-remove-ud" onclick="deleteImgItUp(' + j + ')"></i>' +
                '</div');
        }
    }
}
//remove image item update
$(document).on("click", "#bnt-remove-ud", function () {
    $(this).parent().remove();
    totalimg_ud--;
    if (totalimg_ud < 5) {
        $("#bnt-add-it-img-ud").show();
    }
    var removeFile = $(this).parent().find('.img-view-it').attr('title');
    var index = listFile.findIndex(function (o) {
        return o.name === removeFile;
    });
    listFileUd.splice(index, 1);
});
//get image main update
function getImageUd() {
    $("#multi-file-ud").click();
    $("#multi-file-ud").change(function () {
        readImageUploadUd(this);
    });
}
function readImageUploadUd(input) {
    if (!input.files[0].name.toLowerCase().match(/\.(jpg|jpeg|png|gif)$/)) {
        toastr.info("", " Vui lòng chọn hình ảnh có đuôi(*.jpg | *.jpeg | *.png | *.gif)", 2000);
        return false;
    }
    if (input.files[0].size / 1024 / 1024 > 10) {
        toastr.info("", "Vui lòng upload hình dung lượng dưới 10MB", 2000);
        return false;
    }
    if (input.files && input.files[0]) {
        formDataUd.append("imagerq", input.files[0]);
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#img-main-ud").css("background-image", "url(" + e.target.result + ")");
            $("#img-main-ud").css("color", "rgba(51,51,51,0)");
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file-ud").val("");
}
//get image item update
function getImageItUd() {
    $("#multi-file-it-ud").click();
    $("#multi-file-it-ud").change(function () {
        readImageUploadItUd(this);
    });
}
function readImageUploadItUd(input) {
    if (totalimg_ud >= 5) {
        totalimg_ud = 5;
        $("#bnt-add-it-img-ud").hide();
    }
    if (input.files.length >= 5) {
        $("#bnt-add-it-img-ud").hide();
    }
    for (var i = 0; i < input.files.length; i++) {
        totalimg_ud++;
        if (totalimg_ud == 5) {
            $("#bnt-add-it-img-ud").hide();
        }
        listFileUd.push(input.files[i]);
        if (totalimg_ud < 6) {
            var reader1 = new FileReader();
            reader1.name = input.files[i].name;
            reader1.addEventListener('load', function (e) {
                var picFile = e.target;
                $("#list-img-it-ud").append('<div class="k bd-img-view-it">' +
                    '<div class= "k img-view-it"style="background-image:url(' + e.target.result + ')"title="' + picFile.name + '" ></div >' +
                    ' <i class="fa fa-times" aria-hidden="true" id="bnt-remove-ud"></i>' +
                    '</div');
            });
            reader1.readAsDataURL(input.files[i]);
        }
    }
    $("#multi-file-it-ud").val("");
}

//delete image from server
function deleteImgItUp(position) {
    listFileUdOld[position].check = false;
}
//call server update products
function updateProduct() {
    formDataUd.append('prname', $('#pr-name-ud').val());
    formDataUd.append('total', $('#total-pr-ud').val());
    formDataUd.append('importprice', $('#import-price-ud').val());
    formDataUd.append('price', $('#sale-price-ud').val());

    var mnday = (new Date($('#mn-day-ud').val())).toUTCString();
    formDataUd.append('mnday', mnday);
    var expirydate = (new Date($('#ex-day-ud').val())).toUTCString();
    formDataUd.append('expirydate', expirydate);

    formDataUd.append('lineprid', parseInt($('#sl-lnpr-ud').val()));

    if (listFileUd.length > 0) {
        for (var i = 0; i < listFileUd.length; i++) {
            formDataUd.append("files", listFileUd[i]);
        }
    }
    if (listFileUdOld) {
        debugger
        formDataUd.append("filesOld",listFileUdOld);
    }
    $.ajax({
        type: "POST",
        url: 'https://localhost:44337/api/file/UpdateProduct',
        data: formDataUd,
        processData: false,
        contentType: false,
        cache: false,
        enctype: 'multipart/form-data',
        success: function (data) {
            bootbox.alert("Insert item success!");
        },
        error: function (err) {
            bootbox.alert("Error: " + err);
        }
    });
}
