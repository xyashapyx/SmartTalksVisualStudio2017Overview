$(document).ready(function () {
    $("#showBlockButton").hide()
});

$("#showBlockButton").click(function () {
    $("#blockToHide").show();
    $("#showBlockButton").hide();
    $("#hideBlockButton").show()
});

$("#hideBlockButton").click(function () {
    $("#blockToHide").hide();
    $("#hideBlockButton").hide();
    $("#showBlockButton").show();
});