
var bool = true;
var formdata = new FormData();
var formdataUd = new FormData();
var sex = -1;
function showFormCreateUs() {
    formdata = new FormData();
    if (bool) {
        $(".tab-body-user").show(500);
        bool = false;
        $(".bnt-add-f").addClass("fa-minus");
        $(".bnt-add-f").removeClass("fa-plus");
    }
    else {
        $(".tab-body-user").hide(500);
        bool = true;
        $(".bnt-add-f").removeClass("fa-minus");
        $(".bnt-add-f").addClass("fa-plus");
    }
}
getUserByRole(1);//get user
function getUserByRole(roleid) {
    callAjax(tp.get, "user/getUserByRole?roleid=" + roleid, null, bindingUserByRole);
}
function bindingUserByRole(data) {
    if (data != null) {
        $(".bd-inf-user").remove();
        for (var user = 0; user < data.length; user++) {
            var stt = user + 1;
            $('.bd-body-us').append('<div class="k body-user bd-inf-user">' +
                '<span class= "k note-tius" style = "width:5%;" >' + stt + '</span >' +
                '<div class="k avt-user" style="background-image:url(' + serverfileuser + data[user].avatar + ')"></div>' +
                '<span class="k note-tius" style="width:20%;">' + data[user].fullname + '</span>' +
                '<span class="k note-tius" style="width:5%;"></span>' +
                '<span class="k note-tius" style="width:20%;">' + data[user].email + '</span>' +
                '<span class="k note-tius">' + data[user].phone + '</span>' +
                '<span class="k note-tius">' + formatDate(new Date(data[user].birthday)) + '</span>' +
                '<span class="k note-tius">' + formatDate(new Date(data[user].createday)) + '</span>' +
                '<div class=" k f-edit">' +
                '<i class="fa fa-pencil-square-o font-ic" aria-hidden="true" onclick = showFormUd("' + data[user].email + '") data-toggle="modal" data-target="#myModalUser"></i>' +
                '<i class="fa fa-trash-o font-ic" aria-hidden="true"></i>' +
                '</div>' +
                '</div >');
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
    var month = (date.getMonth() + 1) < 10 ? '0' + (date.getMonth() + 1) : (date.getMonth() + 1);
    var day = date.getDate() < 10 ? '0' + date.getDate() : date.getDate();
    return day + "/" + month + "/" + date.getFullYear();
}
$(document).ready(function () {
    $('#datepicker-us').datetimepicker({
        format: 'DD/MM/YYYY',
        extraFormats: false,
        stepping: 1,
        minDate: false,
        maxDate: false,
        useCurrent: true,
        collapse: true,
        locale: moment.locale(),
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
        icons: {
            time: 'glyphicon glyphicon-time',
            date: 'glyphicon glyphicon-calendar',
            up: 'glyphicon glyphicon-chevron-up',
            down: 'glyphicon glyphicon-chevron-down',
            previous: 'glyphicon glyphicon-chevron-left',
            next: 'glyphicon glyphicon-chevron-right',
            today: 'glyphicon glyphicon-screenshot',
            clear: 'glyphicon glyphicon-trash'
        },
        useStrict: false,
        sideBySide: false,
        daysOfWeekDisabled: [],
        calendarWeeks: false,
        viewMode: 'days',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});
function getImage() {
    $("#multi-file").click();
    $("#multi-file").change(function () {
        readImageUpload(this);
    });
}
function readImageUpload(input) {
    if (input.files && input.files[0]) {
        if (formdata.get("avatar") != null) {
            formdata.delete("avatar");
        }
        formdata.append("avatar", input.files[0]);
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#img-main").css("background-image", "url(" + e.target.result + ")");
            $("#img-main").css("color", "rgba(51,51,51,0)");
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file").val("");
}
//insert user
function insertUser() {
    try {
        formdata.append("fullname", $('#inp-name').val());
        formdata.append("roles", $('.value-roles-add').val());
        formdata.append("email", $('#inp-email').val());
        formdata.append("phone", $('#inp-phone').val());
        formdata.append("address", $('#inp-addr').val());
        formdata.append("birthday", $('#inp-bd').val());
        formdata.append("password", md5($('#inp-pass').val()));
        formdata.append("gender", sex);
        var today = new Date();
        var dd = String(today.getDate()).padStart(2, '0');
        var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
        var yyyy = today.getFullYear();
        today = dd + '/' + mm + '/' + yyyy;
        formdata.append("createday", today);
        formdata.append("active", 1);
        $.ajax({
            type: "POST",
            url: linkserver + 'user/insertUser',
            data: formdata,
            processData: false,
            contentType: false,
            cache: false,
            enctype: 'multipart/form-data',
            success: function (data) {
                if (data.data == "success") {
                    bootbox.alert("Insert user success!");
                    getUserByRole(1);
                    resetFormIs();
                }
                else {
                    bootbox.alert("Error: ");
                }
            },
            error: function (err) {
                bootbox.alert("Error: " + err);
            }
        });
    }
    catch (err) {
        //
    }
}

//remove checkbox
function removeCheckbox(pos) {
    sex = pos;
    switch (pos) {
        case 1:
            document.getElementById("check-woman").checked = false;
            document.getElementById("check-other").checked = false;
            break;
        case 2:
            document.getElementById("check-man").checked = false;
            document.getElementById("check-other").checked = false;
            break;
        default:
            document.getElementById("check-man").checked = false;
            document.getElementById("check-woman").checked = false;
            break;
    }
}

//filter with role
function changeRoles(obj) {
    var value = obj.value;

    if (value === '1') {
        getUserByRole(1);//get user
    }
    else {
        getUserByRole(2);//get user
    }
}

//reset form after inset user
function resetFormIs() {
    document.getElementById("check-woman").checked = false;
    document.getElementById("check-man").checked = false;
    document.getElementById("check-other").checked = false;
    $("#inp-name").val("");
    $("#inp-email").val("");
    $("#inp-addr").val("");
    $("#inp-phone").val("");
    $("#inp-pass").val("");
    $("#img-main").css("background-image", "none");
    $("#img-main").css("color", "rgb(51, 51, 51)");
}
var showp = true;

//format check show hide pass
function showpass() {
    var x = document.getElementById("inp-pass");
    if (showp == true) {
        x.type = "text";
        showp = false;
    }
    else {
        x.type = "password";
        showp = true;

    }
}
//show hide pass update
var showpud = true;
function showpassUd() {
    var x = document.getElementById("ed-pass-ud");
    if (showpud == true) {
        x.type = "text";
        showpud = false;
    }
    else {
        x.type = "password";
        showpud = true;

    }
}
//showtap update user 
function showFormUd(emailus) {
    formdataUd = new FormData();
    callAjax(tp.post, "user/getUserByEmail?email=" + emailus, null, bindingFormUpdate);
}
//binding data insert
function bindingFormUpdate(data) {
    if (data) {
        try {
            $("#ud-fullname").val(data.fullname);
            $("#ed-mail").text(data.email);
            $("#ed-phone").val(data.phone);
            $("#ed-address").val(data.address);
            $("#ed-pass-ud").val(data.password);
            $("#ed-birthday").val(formatDate(new Date(data.birthday)));
            //document.getElementById('sl-gd-ud').getElementsByTagName('option')[data.gender - 1].selected = 'selected';
            if (data.avatar != null) {
                $("#image-mainud").css("background-image", 'url(' + serverfileuser + data.avatar + ')');
                $("#image-mainud").css("color", "rgba(51,51,51,0)");
            }
            formdataUd.append("createday", formatDate(new Date(data.createday)).toString());
            formdataUd.append("avatar", data.avatar.toString());
            formdataUd.append("usid", data.usid);
            formdataUd.append("email", data.email);
        }
        catch (err) {
            //
        }
    }
}

function getImageUd() {
    $("#multi-file").click();
    $("#multi-file").change(function () {
        readImageUploadUd(this);
    });
}
function readImageUploadUd(input) {
    if (input.files && input.files[0]) {
        if (formdataUd.get("newavatar") != null) {
            formdataUd.delete("newavatar");
        }
        formdataUd.append("newavatar", input.files[0]);
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#image-mainud").css("background-image", "url(" + e.target.result + ")");
            $("#image-mainud").css("color", "rgba(51,51,51,0)");
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file-ud").val("");
}
function gotoUpdate() {

    try {
        if (!checkDataUd($('#ud-fullname').val(), $('#ed-pass').val())) {
            bootbox.alert("Warning: Username not empty ,password must be greater than 6  ");
            return;
        }
        formdataUd.append("fullname", $('#ud-fullname').val());
        formdataUd.append("roles", $('.value-roles-add').val());
        formdataUd.append("email", $('#ed-mail').val());
        formdataUd.append("phone", $('#ed-phone').val());
        formdataUd.append("address", $('#ed-address').val());
        formdataUd.append("birthday", $('#ed-birthday').val());
        formdataUd.append("password", md5($('#ed-pass-ud').val()));
        formdataUd.append("gender", parseInt($("#sl-gd-ud").val()));

        formdataUd.append("active", 1);
        $.ajax({
            type: "POST",
            url: linkserver + 'user/updateUser',
            data: formdataUd,
            processData: false,
            contentType: false,
            cache: false,
            enctype: 'multipart/form-data',
            success: function (data) {
                if (data.data == "success") {
                    bootbox.alert("Update user success!");
                    getUserByRole(1);
                    $('#myModalUser').modal('toggle');
                }
                else {
                    bootbox.alert("Error: ");
                }
            },
            error: function (err) {
                bootbox.alert("Error: " + err);
            }
        });
    }
    catch (err) {
        alert("error");
    }
}

// date picker update user
$(document).ready(function () {
    $('#datepicker-ud-user').datetimepicker({
        format: 'DD/MM/YYYY',
        extraFormats: false,
        stepping: 1,
        minDate: false,
        maxDate: false,
        useCurrent: true,
        collapse: true,
        locale: moment.locale(),
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
        icons: {
            time: 'glyphicon glyphicon-time',
            date: 'glyphicon glyphicon-calendar',
            up: 'glyphicon glyphicon-chevron-up',
            down: 'glyphicon glyphicon-chevron-down',
            previous: 'glyphicon glyphicon-chevron-left',
            next: 'glyphicon glyphicon-chevron-right',
            today: 'glyphicon glyphicon-screenshot',
            clear: 'glyphicon glyphicon-trash'
        },
        useStrict: false,
        sideBySide: false,
        daysOfWeekDisabled: [],
        calendarWeeks: false,
        viewMode: 'days',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});
//check correct item 
function checkDataUd(fname, pass) {
    if (fname.trim(0).length >0) {
        return true;
    }
    if (pass.trim().length > 6) {
        return true;
    }
    return false;
}