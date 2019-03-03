getLine();

function getLine() {
    var myUrl = '@Url.Action("SendRequestAsyncSchedule","Admin")';
    $.ajax({
        type: "GET",
        url: myUrl,
        data: null,
        contentType: "application/json",
        error: function (err) {
            alert("error");
        },
         success: function (data) {
            alert("here");
        },
    });
}