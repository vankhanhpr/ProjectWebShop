var linkserver = "https://localhost:44337/api/";
var serverfile = "https://localhost:44337/images/";
var serverfileuser = "https://localhost:44337/user/";

//format money
function formatNumber(yourNumber) {
    if (yourNumber) {
        var components = yourNumber.toString().split(".");
        components[0] = components[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
        return components.join(".");
    } else {
        return "0";
    }
}
function showLoading() {
    $("body").append('<div class="lds-ring"><div></div><div></div><div></div><div></div></div>');
}
function destroyLoading() {
    $(".lds-ring").hide();
}

//adđ product to the cart
function addToCart(prod) {
    if (typeof (Storage) !== "undefined") {
        var list = [];
        var total = 0;
        total += prod.total;
        if (localStorage.getItem('product')) {
            list = JSON.parse(localStorage.getItem("product"));
            for (var j = 0; j < list.length; j++) {
                total += parseInt(list[j].total);
                if (list[j].prid == prod.prid) {//item is exist in the cart
                    list[j].total = list[j].total + prod.total;
                    localStorage['product'] = JSON.stringify(list);
                    $(".tt_pdt").text("" + total);
                    return;
                }
            }
        }
        //item not exist in the cart
        list.push(prod);
        localStorage['product'] = JSON.stringify(list);
        $(".tt_pdt").text("" + total);
    }
    else {
        alert('Trình duyệt của bạn đã quá cũ. Hãy nâng cấp trình duyệt ngay!');
    }
}
//show product in cart
showCart();
function showCart() {
    if (typeof (Storage) !== "undefined") {
        var list = [];
        var totalpr = 0;
        if (localStorage.getItem('product')) {
            list = JSON.parse(localStorage.getItem("product"));
            for (var i = 0; i < list.length; i++) {
                totalpr += parseInt(list[i].total);
            }
        }
        $(".tt_pdt").text("" + totalpr);
    }
    else {
        $(".tt_pdt").text("0");

        alert('Trình duyệt của bạn đã quá cũ. Hãy nâng cấp trình duyệt ngay!');
    }

}

function deleteIt() {
    if (typeof (Storage) !== "undefined") {
        localStorage.removeItem("product");
    }
}