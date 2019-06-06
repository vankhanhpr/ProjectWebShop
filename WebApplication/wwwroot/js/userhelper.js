var linkserver = "https://localhost:44337/api/";
var serverfile = "https://localhost:44337/images/";
var serverfileuser = "https://localhost:44337/user/";

//format money
function formatNumber(yourNumber) {
    if (yourNumber) {
        var components = yourNumber.toString().split(".");
        components[0] = components[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
        return components.join(".");
    } else {
        return "0";
    }
}
function showLoading() {
    $("body").append('<div class="lds-ring"><div></div><div></div><div></div><div></div></div>');
}
function destroyLoading() {
    $(".lds-ring").hide();
}