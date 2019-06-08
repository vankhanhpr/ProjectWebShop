

var totalmoney = 0;
$('.div-radio-button').click(function () {
    $(this).find("fa-circle-o").css("color", "red");
});

getProduct();

function select(evt) {
    $("" + evt).find(".fa-circle-o").css("color", "red");

}
function setRadioChecked(a) {
    var n = $(a).find("i");
    if (!n.is(".fa-dot-circle-o")) {
        $(a).find("input").prop("checked", !0);
        var e = $(a).attr("itemprop");
        $(".div-radio-button[itemprop='" + e + "']").find("i").removeClass("fa-dot-circle-o").addClass("fa-circle-o"),
            n.removeClass("fa-circle-o").addClass("fa-dot-circle-o");
        var t = $(a).attr("data-val");
        $("#" + e).length > 0 && $("#" + e).val(t), $(a).parent().removeClass("input-validation-error");
       // var o = e.replace("_", ".");
        //$("span[data-valmsg-for='" + o + "']").length > 0 && $("span[data-valmsg-for='" + o + "']").text("");
    }
}
function setCheckBoxChecked(a) {
    var n = $(a).find("i");
    n.is(".fa-check-square") ? ($(a).find("input").prop("checked", !1),
        n.removeClass("fa-check-square").addClass("fa-square-o")) : ($(a).find("input").prop("checked",
            !0), n.removeClass("fa-square-o").addClass("fa-check-square"));
}

//get product
function getPrFromServer(id, callback,num) {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/GetproductbyId?id=" + id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
        },
        success: function (data) {
            callback(data, num);
        }
    });
}

//get all product select
function getProduct() {
    var listPr = getPrFromLocal();
    if (listPr.length > 0) {
        for (var i = 0; i < listPr.length; i++) {
            getPrFromServer(listPr[i].prid, bindingPrById, listPr[i].total);
        }
    }
    else {
        //
    }
}
//get list product from local
function getPrFromLocal() {
    if (typeof (Storage) !== "undefined") {
        var list = [];
        if (localStorage.getItem('product').length > 0) {
            list = JSON.parse(localStorage.getItem("product"));
        }
        return list;
    }
    else {
        alert('Trình duyệt của bạn đã quá cũ. Hãy nâng cấp trình duyệt ngay!');
    }
}

//binding products
function bindingPrById(data, num) {
    if (data.success) {
        var item = data.data.product;
        totalmoney += item.price * num;
        $(".t-money").text(totalmoney + " đ");
        $(".bd-item-small").append('<div class="k f-prd">' +
            '<div class= "k img-prd" style="background-image:url(' + serverfile + item.image + ')"></div >' +
            '<span class="k name-prd">' + item.prname + '</span>' +
            '<span class="k price-product">' + item.price + ' đ</span>' +
            '<div class="k f-amount">' +
            '<span class="k t-note-amount">Số lượng</span>' +
            '<a class="k t-amount" title="Số lượng sản phẩm muốn mua">' + num + '</a>' +
            '</div>' +
            '</div> ');
    }
}