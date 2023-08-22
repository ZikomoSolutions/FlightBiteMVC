

$(document).ready(function () {

    //$(window).click(function (e) {
    //    if (e.target == $(".modal")) {
    //        $(".modal").removeClass("modal--active");
    //    }
    //    console.log(e.target);
    //});
    $(".open-modal").click(function () {
        var modalId = $(this).data("modal-target");
        $("#" + modalId).addClass("modal--active");
        $("body").css("overflow","hidden");
    })
    $(".close-modal").click(function () {

        var modalId = $(this).data("modal-target");
        $(".modal").removeClass("modal--active");
        $("#" + modalId).addClass("modal--active");
        $("body").css("overflow", "auto");
    });

    $("#open-client-notes-section").click(function () {
        $("#client-name-notes").show();
        $("#enquiry-details").hide();

    });
    $("#back-to-enquiry-details").click(function () {
        $("#enquiry-details").show();
        $("#client-name-notes").hide();
    });

});
$(document).keydown(function (e) {
    if (e.keyCode == 27) {
        $(".modal").removeClass("modal--active");
        $("body").css("overflow", "auto");

    }
});

















