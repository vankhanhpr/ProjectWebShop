$(document).ready(function () {
    var bol = checkTokenServerAd();
    //if (!bol) {
    //    window.location.href = "/admin/adminlogin";
    //}
    //else {
    //    //
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