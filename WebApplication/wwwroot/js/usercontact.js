
var page = 0;
var pagesize = 20;
function insertComplain() {
    var data = {
        "title": $("#tt-complain").val(),
        "phone": $("#phone-client").val(),
        "content": $("#conten-complain").val()
    };
    if (checkData(data) === true) {
        //
    }
    else {
        alert(checkData(data));
        return; 
    }

    $.ajax({
        url: linkserver + "complain/InsertComplain",
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(data),
        async: false,
        processData: false,
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Đã có lỗi xảy ra, xin vui lòng thủ lại!");
        },
        success: function (data) {
            bootbox.alert("Xin cảm ơn về phản ánh của quý khách, phản ảnh của quý khách đã " +
                "được ghi lại, chúng tôi sẽ phản hồi phản ánh của quý khách trong" +
                "thời gian sớm nhất. Xim chân thành cảm ơn");
            emptyForm();
        }
    });
}

function checkData(obj) {
    if (obj.title.trim() === "" || obj.title.trim().length < 1) {
        return "Vui lòng thêm tiêu đề";
    }
    if (obj.content.trim() === "" || obj.content.trim().length < 1) {
        return "Vui lòng nhập nội dung cần phản ánh";
    }
    var phoneno = /^\d{10}$/;
    if (!obj.phone.match(phoneno) || obj.phone[0]!=='0') {
        return "Số điện thoại của quý khách chưa chính xác, vui lòng nhập lại";
    }
    return true;
}

function emptyForm() {
    $("#tt-complain").val("");
    $("#phone-client").val("");
    $("#conten-complain").val("");
}
//checknumber
$(document).ready(function () {
    $("#phone-client").keypress(function (e) {
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
            return false;
        }
    });
});