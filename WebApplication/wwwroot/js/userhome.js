
$(document).ready(function () {
    showLoadingHome();
    getNewProducts(bindingNewPr, 3, 1);
    getHighLightpr(bindingHLpr);
});
var boolf = true;

//get new products
function getNewProducts(callback, pagesize, page) {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/getProductsHighLights?pagesize=" + pagesize + "&page=" + page + "",
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
        },
        success: function (data) {
            callback(data);
        }
    });
}
//binding new products
function bindingNewPr(data) {
    if (data.success) {
        var lstpr = data.data.prd;
        $(".f-newprd").remove();
        for (var i in lstpr) {
            var item = lstpr[i];
            $(".main-it-lv2").append('<div class="k db-it-prd f-newprd">' +
                '<div class= "k main-it">' +
                '<div class="k bd-img">' +
                '<div class="k img-product" style="background-image:url(' + serverfile + item.product.image + ')"></div>' +
                '</div>' +
                '<span class="k t t-name-it">' + formatNumber(item.product.prname) + ' đ</span>' +
                '<span class="k t t-price-it">' + formatNumber(item.product.price) + ' đ</span>' +
                '<span class="k t t-price-pro-it">' + formatNumber(item.product.oldprice) + ' ₫ </span>' +
                '<span class="k t-tt-view">' + item.product.totallike + '</span>' +
                '<i class= "fa fa-heart-o"></i>' +
                '<span class="k t-tt-view">' + item.product.totalview + '</span>' +
                '<i class="fa fa-eye"></i>' +
                '<div class="f-dt-pdt">' +
                '<i class="fa fa-shopping-cart h-icon-fa" onclick="addProduct(' + item.product.prid + ')"></i>' +
                '<a href="/product/product?prid=' + item.product.prid + '"><i class="fa fa-info h-icon-fa"></i></a>' +
                '</div>' +
                '</div>' +
                '</div >');
        }
        if (boolf) {
            pagging(data.data.total);
        }
        destroyLoadingHome();
    }
    else {
        bootbox.alert("Error !");
    }
}
//add to cart
function addProduct(id) {
    var model = { prid: id, total: 1 };
    addToCart(model);
}
//get highlight products
function getHighLightpr(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/GetProductsMostLikely",
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
        },
        success: function (data) {
            callback(data);
        }
    });
}
//binding highlight products
function bindingHLpr(data) {
    if (data.success) {
        var lsthlpr = data.data;
        $(".it-fvr-hl").remove();
        for (var i in lsthlpr) {
            var item = lsthlpr[i];
            $("#bd-pr-favorite").append('<div class="k db-it-prd db-it-prd-hl it-fvr-hl">' +
                '<div class= "k main-it">' +
                '<div class="k bd-img-highlight" style="background-image:url(' + serverfile + item.product.image + ')">' +
                '<div class="k img-product"></div>' +
                '</div>' +
                '<span class="k t t-name-it">' + item.product.prname + '</span>' +
                '<span class="k t t-price-it">' + formatNumber(item.product.price) + ' đ </span>' +
                '<span class="k t t-price-pro-it">' + formatNumber(item.product.oldprice) + ' ₫ </span>' +
                '<span class="k t-tt-view">' + item.product.totallike + '</span>' +
                '<i class= "fa fa-heart-o"></i>' +
                '<span class="k t-tt-view">' + item.product.totalview + '</span>' +
                '<i class="fa fa-eye"></i>' +
                '<div class="f-dt-pdt">' +
                '<i class="fa fa-shopping-cart h-icon-fa" onclick="addProduct(' + item.product.prid + ')"></i>' +
                '<a href="/product/product?prid=' + item.product.prid + '"><i class="fa fa-info h-icon-fa"></i></a>' +
                '</div>' +
                '</div >' +
                '</div>');
        }
    }
    else {
        bootbox.alert("Error connect");
    }
}
//get the describe product
getDesPr();
function getDesPr() {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/GetDesPr",
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {

        },
        success: function (data) {
            if (data.success) {
                for (var i in data.data) {
                    var item = data.data[i];
                    var describes = "";
                    if (item.des != null) {
                        describes = item.des.describes;
                    }
                    $("#f-despr").append('<a href="/product/product?prid=' + item.product.prid + '"><div class="k bd-id-new">' +
                        '<div class= "k body-it-new">' +
                        '<div class="k img-it-new" style="background-image:url(' + serverfile + item.product.image + ')"></div>' +
                        '<div class="k f-note-inf">' +
                        '<span class="k t t-name-it-new">' + item.product.prname + '</span>' +
                        '<span class="k t t-price-it">' + formatNumber(item.product.price) + ' đ</span>' +
                        '<span class="k t t-inf-it">' + describes + '</span>' +
                        '</div>' +
                        '</div>' +
                        '</div></a>');
                }
            }
        }
    });
}

function gotoTab(tag) {
    $('html, body').animate({
        scrollTop: $("#" + tag).offset().top
    }, 2000);
}
//paging product hightlight

function pagging(page) {
    if (page > 5) {
        page = 5;
    }
    $(".owl-dot").remove();
    for (var i = 0; i < page; i++) {
        var poi = i + 1;
        $("#tab-pagging").append('<div data-val=' + poi + ' onclick = "zoomDot(this)" class= "owl-dot">' +
            '<span></span></div>'
        );
    }
    if (boolf) {
        var view = document.getElementsByClassName("owl-dot");
        $(view[0]).addClass('zoomin');
        boolf = false;
    }
    else {
        //
    }
    //$("#tab-pagging").append('<div onclick = "zoomDot(this)" class= "owl-dot" > ' +
    //    '<i class="fa fa-step-forward" aria-hidden="true"></i></div>');
}
function zoomDot(pos) {
    $(".owl-dot").removeClass('zoomin');
    $(pos).addClass('zoomin');
    var t = $(pos).attr("data-val");
    getNewProducts(bindingNewPr, 3, parseInt(t));
}
function showLoadingHome() {
    $(".bd-main-it").append('<div class="f-progress"><div class="loader">Loading...</div></div>');
}
function destroyLoadingHome() {
    $(".f-progress").hide();
}