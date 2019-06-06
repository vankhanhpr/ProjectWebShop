getNewProducts(bindingNewPr);
getHighLightpr(bindingHLpr);
//get new products
function getNewProducts(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/getProductsHighLights",
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
        var lstpr = data.data;
        $(".db-it-prd").remove();
        for (var i in lstpr) {

            $(".main-it-lv2").append('<div class="k db-it-prd">' +
                '<div class= "k main-it">' +
                '<div class="k bd-img">' +
                '<div class="k img-product" style="background-image:url(' + serverfile + lstpr[i].product.image + ')"></div>' +
                '</div>' +
                '<span class="k t t-name-it">' + lstpr[i].product.prname + '</span>' +
                '<span class="k t t-price-it">' + lstpr[i].product.price + '</span>' +
                '<span class="k t t-price-pro-it">35.000₫ </span>' +
                '<div class="f-dt-pdt">' +
                '<i class="fa fa-shopping-cart"></i>' +
                '<a href="/product/product?prid=' + lstpr[i].product.prid+'"><i class="fa fa-info"></i></a>' +
                '</div>' +
                '</div>' +
                '</div >');
        }
    }
    else {
        bootbox.alert("Error !");
    }
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
        $(".it-fvr").remove();
        for (var i in lsthlpr) {
            $("#bd-pr-favorite").append('<div class="k db-it-prd it-fvr">' +
                '<div class= "k main-it">' +
                '<div class="k bd-img" style="background-image:url(' + serverfile + lsthlpr[i].product.image + ')">' +
                '<div class="k img-product"></div>' +
                '</div>' +
                '<span class="k t t-name-it">' + lsthlpr[i].product.prname + '</span>' +
                '<span class="k t t-price-it">' + lsthlpr[i].product.price + ' đ </span>' +
                '<span class="k t t-price-pro-it">35.000₫ </span>' +
                '<div class="f-dt-pdt">' +
                '<i class="fa fa-shopping-cart"></i>' +
                '<i class="fa fa-info"></i>' +
                '</div>' +
                '</div >' +
                '</div>');
        }

    }
    else {
        bootbox.alert("Error connect");
    }
}