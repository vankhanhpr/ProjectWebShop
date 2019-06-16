
$(document).ready(function () {
    //if (!checkTokenFromLocal()) {
    //    //window.location.href = "/admin/adminlogin";
    //}
});
boolsh = true;
function showListItem() {
    if (boolsh == true) {
        $('#catalogy').hide(300);
        boolsh = false;
        $('#icon_show-l-it').toggleClass("down");
    }
    else {
        $('#catalogy').show(300);
        $('#icon_show-l-it').toggleClass("down");
        boolsh = true;
    }
}