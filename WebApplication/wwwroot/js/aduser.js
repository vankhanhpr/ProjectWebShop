

var bool = true;
function showFormCreateUs() {
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