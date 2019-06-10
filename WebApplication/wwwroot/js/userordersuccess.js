function getOrder(id, callback) {
    $.ajax({
        type: "get",
        url: linkserver + "invoice/GetInvoicebyId?=" + id,
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
function bindingOrderById(data) {
    if (data.success) {
        $(".name-client").text(data.data.invoi.namecustomer);
        $(".code").text(data.data.invoi.codeinvoice);
        $(".email-client").text(data.data.invoi.email);
    }
    else {
        bootbox.alert("Có lỗi xảy ra vui lòng thủ lại sau");
    }
}

//get more product
function getMoreProduct(callback) {
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
getMoreProduct(bindingPrdMore);
function bindingPrdMore(data) {
    if (data.success) {
        for (var i in data.data) {
            var it = data.data[i].product;
            $(".bd-item-more").append('<a href="/product/product?prid=' + it.prid +'"><div class="k bd-f-moer-prd">' +
                '<div class= "k img-prd-more"style="background-image:url(' + serverfile + it.image + ')" ></div>' +
                '<div class="k f-name-pr-more">' +
                '<span class="k t-name-pr-more">' + it.prname + '</span>' +
                '<span class="k t-price-pr-more">' + it.price + ' đ</span>' +
                '</div>' +
                '</div></a>');
        }
    }
}