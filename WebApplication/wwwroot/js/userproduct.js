
//get detail product
function getProductById(id, callback) {
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
            callback(data);
        }
    });
}
function bindingPrById(data) {
    var pr = data.data;
    if (data.success) {
        $("#name-prd").text(pr.product.prname);
        $("#price-pr").text(pr.product.price+" đ");
        $("#old-price").text(pr.product.oldprice + " đ");

        var x = parseInt(pr.product.price);
        var y = parseInt(pr.product.oldprice);
        var dsc = (x - y) / x * 100; 
        var temp = Math.round(parseFloat(dsc) * 100) / 100;
        $("#t-price-dc").text("("+temp + "%)");



        $("#img-main-prd").css('background-image', 'url(' + serverfile + pr.product.image +')');
    }
    else {
        bootbox.alert("Có lỗi xảy ra xin vui lòng thử lại");
    }
}

//get same products
function getSamePrd(lnid) {
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
            callback(data);
        }
    });
}

//get evaluate 
function getEvaluate(prid) {
    $.ajax({
        type: "get",
        url: linkserver + "evaluate/getEvaByPr?prid=" + prid,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra vui lòng thử lại");
        },
        success: function (data) {
            if (data.success) {
                for (var i = 0; i < data.data.everage
; i++) {
                    $("#bd-evaluate").append('<i class="fa fa-star ic-star" aria-hidden="true"></i>');
                }
            }
        }
    });
}
//change number 
function changeNumber(bool) {
    var numb = parseInt($("#numb").text());
    if (bool) {
        numb++;
        $("#numb").text(numb);
    }
    else {
        numb--;
        if (numb < 1) {
            numb = 1;
        }
        $("#numb").text(numb);
    }
}