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