$(document).ready(function () {

    /*Modal Functionlity*/

    //$(window).click(function (e) {
    //    if (e.target == $(".modal")) {
    //        $(".modal").removeClass("modal--active");
    //    }
    //    console.log(e.target);
    //});
    $(".open-modal").click(function () {
        var modalId = $(this).data("modal-target");
        $("#" + modalId).addClass("modal--active");

        $("body").css("overflow", "hidden");
    })
    $(".close-modal").click(function () {

        var modalId = $(this).data("modal-target");
        $(".modal").removeClass("modal--active");
        $("#" + modalId).addClass("modal--active");
        $("body").css("overflow", "auto");
    });

    //Enquiry Page 

    $("#open-client-notes-section").click(function () {
        $("#client-name-notes").show();
        $("#enquiry-details").hide();

    });
    $("#back-to-enquiry-details").click(function () {
        $("#enquiry-details").show();
        $("#client-name-notes").hide();
    });
    $("#submit-selected-client-type").click(function () {
        $("#enquiry-section-2").show();
        $("#enquiry-section-1").hide();
    });
    $("#back-to-enquiry-section-1").click(function () {
        $("#enquiry-section-2").hide();
        $("#enquiry-section-1").show();
    })
    $("#submit-button").click(function () {
        $(".modal").removeClass("modal--active");
    });



    /*Client Page*/
    $("#selectClient").change(function (e) {
        $("#client-enquiry-form-heading").text(e.value);
        console.log(e.value);
    });


});
$(document).keydown(function (e) {
    if (e.keyCode == 27) {
        $(".modal").removeClass("modal--active");
        $("body").css("overflow", "auto");

    }
});