
getProduct();
var ttmoney = 0;
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

//get all product select
function getProduct() {
    var listPr = getPrFromLocal();
    addTotalPrToView(listPr.length);
    if (listPr.length > 0) {
        for (var i = 0; i < listPr.length; i++) {
            getPrFromServer(listPr[i].prid, bindingPrById, listPr[i].total, i);
        }
    }
    else {
        //
    }
}
//add total pr to pr
function addTotalPrToView(ttpr) {
    $(".total-prd").text("(" + ttpr + " sản phẩm)");
}
//get Product by id from server
function getPrFromServer(id, callback,num,po) {
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
            callback(data,num,po);
        }
    });
}
//delete product in cart
function deletePrInCart(id) {
    if (typeof (Storage) !== "undefined") {
        var list = [];
        if (localStorage.getItem('product').length > 0) {
            list = JSON.parse(localStorage.getItem("product"));
            for (var i = 0; i < list.length; i++) {
                if (list[i].prid == id) {
                    list.splice(i, 1);
                    localStorage['product'] = JSON.stringify(list);
                    getProduct();
                    $(".f-body-prd").remove();
                    ttmoney = 0;
                    return;
                }
            }
        }
    }
    else {
        alert('Trình duyệt của bạn đã quá cũ. Hãy nâng cấp trình duyệt ngay!');
    }
}

//binding data
function bindingPrById(data,numb,po) {
    if (data.success) {
        var pr = data.data.product;
        var x = parseInt(pr.price);
        var y = parseInt(pr.oldprice);
        var dsc = (x- y) / y * 100;
        var temp = Math.round(parseFloat(dsc) * 100) / 100;
        ttmoney += x * numb;
        showTotalMoney(ttmoney);
        $(".body-prd").append('<div class="k f-body-prd">' +
            '<div class= "k img-prd" style="background-image:url(' + serverfile + pr.image + ')"></div>' +
            '<div class="k f-note-prd">' +
            '<span class="k t-name-prd">' + pr.prname + '</span>' +
            '<span class="k t-vs2">Cung cấp bởi: Fooody</span>' +
            '<span class="bnt-remove-prd" onclick="deletePrInCart(' + pr.prid + ')">Xóa</span>' +
            '</div>' +
            '<div class=" k f-price-prd">' +
            '<span class="k t-price">' + pr.price + ' đ</span>' +
            '<span class="k t-old-price">' + pr.oldprice + ' đ</span>' +
            '<span class="k t-discount">' + temp + '%</span>' +
            '<div class="k bd-numb-prd">' +
            '<button class="bnt-amount" type="button" onclick="changeNumber(false,' + po + ',' + pr.price + ')">-</button>' +
            '<span class="bnt-amount" id="numb' + po + '">' + numb + '</span>' +
            '<button class="bnt-amount" type="button" onclick="changeNumber(true,' + po + ',' + pr.price + ')">+</button>' +
            '</div>' +
            '</div>' +
            '</div >');
    }
    else {
        bootbox.alert("Có lỗi xảy ra vui lòng thử lại");
    }
}

//show total money
function showTotalMoney(money) {
    $(".t-tt-money").text(money+" đ");
    $(".t-total-money").text(money+" đ");
}

//edit total 
function changeNumber(bool, po,price) {
    var number = parseInt($("#numb" + po).text());
    var mon = parseInt($("#numb" + po).text());
    if (bool) {
        number++;
        $("#numb" + po).text(number);
        ttmoney += price;
    }
    else {
        number--;
        if (number == 0) {
            number = 1;
        }
        $("#numb" + po).text(number);
        ttmoney -= price;

    }
    showTotalMoney(ttmoney);
}