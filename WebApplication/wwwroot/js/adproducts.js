
//line products
callAjax(tp.get, "lineproduct/GetAllLineProduct", null, bindingGetAllLnPr);
function bindingGetAllLnPr(data) {
    if (data) {
        for (var i in data) {
            $(".f-ln-prd").remove();
            $("#f-ln-prd").append('<div class="k bd-prd" onclick= "filterLinePr(' + data[i].lineprid + ')">' +
                '<div class="k ic-pdt" ></div >' +
                '<span class="k t t-name-pr">' + data[i].linename +'</span>' +
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
                '<div class= "k img-pdt"style="background-image:url(' + serverfile +data[i].image+ ')" ></div>' +
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
    return date.getDate() + "/" + month+ "/" + date.getFullYear();
}
