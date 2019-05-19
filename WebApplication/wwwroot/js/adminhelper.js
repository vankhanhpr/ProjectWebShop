var tp = {
    'get': 'GET',
    'post': 'POST',
    'delete': 'DELETE'
};
var linkserver = "https://localhost:44337/api/";
var serverfile = "https://localhost:44337/images/";
function callAjax(type, link, data, callback) {
    console.log(link);
    $.ajax({
        type: type,
        url: linkserver + link,
        data: data,
        dataType:'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
            
        },
        success: function (data) {
            callback(data);
        }
    });
}
function callAjaxInsert(type, link, data, callback) {
    $.ajax({
        url: linkserver + link,
        type: type,
        datatype: 'json',
        async: false,
        data: data,
        processdata: false,
        contenttype: false,
        error: function (err) {
            callback('error');
        },
        success: function (data) {
            callback('insert success');
        }
    });
}

function showLoading() {
    $("body").append('<div class="lds-ring"><div></div><div></div><div></div><div></div></div>');
}
function destroyLoading() {
    $(".lds-ring").hide();
}
function formatNumber(yourNumber) {
    if (yourNumber) {
        var components = yourNumber.toString().split(".");
        components[0] = components[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
        return components.join(".");
    } else {
        return "0";
    }
}