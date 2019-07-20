$(document).ready(function () {
    showLoading();
    var bol = checkTokenServerAd();
});
var page = 0;
var pagesize = 40;
getAllRegister(page, pagesize, bindingRegister);
function getAllRegister(p, pz, callback) {
    $.ajax({
        type: "get",
        url: linkserver + "register/getallregister?page=" + p + "&pagesize=" + pz,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra, vui lòng kiểm tra kết nối");
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingRegister(data) {
    if (data.success) {
        for (var i in data.data) {
            var item = data.data[i];
            $("#tb-register").append('<tr>' +
                '<td>' + item.email + '</th>' +
                '<td>Time</th>' +
                '<td>' + item.regid + '</th>' +
                '<td>' + (item.status == 0 ? 'Enable' : 'Disible')+'</th>' +
                '</tr>');
        }
    }
    destroyLoading();
}

//lazyload user
$(window).scroll(function () {
    if ($(window).scrollTop() + $(window).height() === $(document).height()) {
        page = page + 1;
        getAllRegister(page, pagesize, bindingRegister);
    }
});