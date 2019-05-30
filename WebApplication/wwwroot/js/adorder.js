
$('.div-radio-button').click(function () {
    $(this).find("fa-circle-o").css("color", "red");
});

function select(evt) {
    $("" + evt).find(".fa-circle-o").css("color", "red");

}
function setRadioChecked(a) {
    var n = $(a).find("i");
    if (!n.is(".fa-dot-circle-o")) {
        $(a).find("input").prop("checked", !0);
        var e = $(a).attr("itemprop");
        $(".div-radio-button[itemprop='" + e + "']").find("i").removeClass("fa-dot-circle-o").addClass("fa-circle-o"),
            n.removeClass("fa-circle-o").addClass("fa-dot-circle-o");
        var t = $(a).attr("data-val");
        $("#" + e).length > 0 && $("#" + e).val(t), $(a).parent().removeClass("input-validation-error");
       // var o = e.replace("_", ".");
        //$("span[data-valmsg-for='" + o + "']").length > 0 && $("span[data-valmsg-for='" + o + "']").text("");
    }
}
function setCheckBoxChecked(a) {
    var n = $(a).find("i");
    n.is(".fa-check-square") ? ($(a).find("input").prop("checked", !1),
        n.removeClass("fa-check-square").addClass("fa-square-o")) : ($(a).find("input").prop("checked",
            !0), n.removeClass("fa-square-o").addClass("fa-check-square"));
}