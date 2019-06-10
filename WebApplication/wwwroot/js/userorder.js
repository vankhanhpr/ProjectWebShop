
getProvince(bindingProvince);
var totalmoney = 0;
var typeaddress = null;
var timeinwork = null;
var typepay = null;
var gender = - 1;
var codediscount = "";
var listinvoicepr = [];
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

        switch (e) {
            case "setgender":
                if ($(a).find("input").get(0).id=="male") {
                    gender = 0;
                }
                else {
                    gender = 1;
                }
                break;
            case "setdeliver":
                if ($(a).find("input").get(0).id == "address") {
                    typeaddress = true;
                    $("#other-adress").hide(300);
                }
                else {
                    typeaddress = false;
                    $("#other-adress").show(300);
                }
                break;
            case "settimedeliver":
                if ($(a).find("input").get(0).id == "timeinwork") {
                    timeinwork = 0;
                }
                else {
                    timeinwork = 1;
                }
                break;
            case "settypepay":
                if ($(a).find("input").get(0).id == "cod") {
                    typepay = 0;
                }
                else {
                    typepay = 1;
                }
                break;
        }

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

        var model = { "prid": item.prid,"total": num };
        listinvoicepr.push(model);

        $("#t-money").text(totalmoney + " đ");
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

//get province
function getProvince(callback) {
    $.ajax({
        type: "get",
        url: linkserver + "province/GetProvince",
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
//binding province
function bindingProvince(data) {
    if (data.success) {
        var province = data.data;
        for (var i in province) {
            $("#sl-province").append(' <option value=' + province[i].matp + '>' + province[i].name + '</option>');
        }
        getDistrictByProvince(province[0].matp,false);
    }
}

//get district by province 
function getDistrictByProvince(obj, bool) {
    var pid = null;
    if (bool) {//the first call
        pid = obj.value;
    }
    else {//the select call
        pid = obj;
    }
    $.ajax({
        type: "get",
        url: linkserver + "district/GetDtByProvince?pid=" + pid,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, xin vui lòng thử lại");
        },
        success: function (data) {
            if (data.success) {
                $(".opt-dst").remove();
                var district = data.data;
                for (var i in district) {
                    $("#sl-district").append('<option class="opt-dst" value=' + district[i].maqh + '>' + district[i].name + '</option>');
                }
            }
        }
    });
}

//order 
function toOrder() {
    var data = checkOrder();
    $.ajax({
        type: "POST",
        url: linkserver +"invoice/InsertInvoive",
        data: data,
        processData: false,
        contentType: false,
        cache: false,
        enctype: 'multipart/form-data',
        success: function (data) {
            if (data.success) {
                deleteIt();
                window.location.href = "/order/ordersuccess?ivid=" + data.data.ivid;
            }
        },
        error: function (err) {
            bootbox.alert("Error: " + err);
        }
    });
}
//check order
function checkOrder() {
    //check name
    var nameclient = $("#t-name-client").val().trim();
    if (nameclient == "" || nameclient == null) {
        changeColorElement("t-name-client", true);
    }
    else {
        changeColorElement("t-name-client", false);
    }
    //check gender
    if (gender == -1) {
        changeColorElement("f-input-gender", true);
    }
    else {
        changeColorElement("f-input-gender", false);
    }
    //check phone number
    var phonenumber = $("#phone-numb").val().trim();
    if (phonenumber == "" || phonenumber == null) {
        changeColorElement("phone-numb", true);
    }
    else {
        changeColorElement("phone-numb", false);
    }
    //check email
    var email = $("#email").val().trim();
    if (email == "" || email == null) {
        changeColorElement("email", true);
    }
    else {
        changeColorElement("email", false);
    }
    //check adress delivery
    var adrclient = $("#adress-client").val().trim();
    if (adrclient == "" || adrclient == null) {
        changeColorElement("adress-client", true);
    }
    else {
        changeColorElement("adress-client", false);
    }

    //check address delivery 
    if (typeaddress == null) {
        changeColorElement("f-input-address", true);
    }
    else {
        changeColorElement("f-input-address", false);
    }
    //other address
    var otheraddress = $("#other-adress").val().trim();
    if (otheraddress == "" || adrclient == null) {
        changeColorElement("other-adress", true);
    }
    else {
        changeColorElement("other-adress", false);
    }
    //check time delivery
    if (timeinwork == null) {
        changeColorElement("f-input-timedl", true);
    }
    else {
        changeColorElement("f-input-timedl", false);
    }
    //check typy pays f-input-pay
    if (typepay == null) {
        changeColorElement("f-input-pay", true);
        return false;
    }
    else {
        changeColorElement("f-input-pay", false);
    }
    var formData = new FormData();
    formData.append("namecustomer", nameclient);
    formData.append("gender", gender);
    formData.append("phonenumber", phonenumber);
    formData.append("email", email);

    formData.append("province", $("#sl-province").val());
    formData.append("district", $("#sl-district").val());
    formData.append("adress", $("#adress-client").val());
    if (typeaddress) {
        formData.append("adressdelviver", $("#adress-client").val());
    }
    else {
        formData.append("adressdelviver", $("#other-adress").val());
    }
    formData.append("timedeliver", timeinwork);//0 trong h hanh chinhs //1 ><
    formData.append("typepay", typepay);//0 to pay = cod 1-> bank/momo
    formData.append("totalmoney", totalmoney);

    formData.append("money", totalmoney);
    formData.append("codediscount", codediscount);
    formData.append("note", $(".tex-note").val());
    formData.append("usid", -1);

    for (var i in listinvoicepr) {
        formData.append("invoiceproduct", JSON.stringify(listinvoicepr[i]));
    }
    return formData;
}
//change border color element
function changeColorElement(elem,bol) {
    if (bol) {
        $("#" + elem).css("border", "1px solid red");
    }
    else {
        $("#" + elem).css("border", "1px solid rgba(51,51,51,0.2");
    }
}