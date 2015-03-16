function ajaxGet(event) {
    event.preventDefault();
    var theTag = $(this);
    $.get(theTag.attr("href"), function (data) {
        theTag.closest("body").find("div.container").html(data);
    });
}

function ajaxGetAbout(event) {
    event.preventDefault();
    var theTag = $(this);
    $.get(theTag.attr("href"), function (data) {
        theTag.closest("body").find("div.about").html(data);
    });
}

$(document).ready(function () {
    $("body").on("click", "a#about", ajaxGet
        );
    $("body").on("click", "a#work", ajaxGet
        );
    $("body").on("click", "a#careers", ajaxGet
        );
    $("body").on("click", "a#contact", ajaxGet
        );
    $("body").on("click", "a#Who", ajaxGetAbout
      );
    $("body").on("click", "a#What", ajaxGetAbout
      );
    $("body").on("click", "a#Why", ajaxGetAbout
      );
    $("body").on("click", "a#How", ajaxGetAbout
      );
    $("body").on("click", "a#Where", ajaxGetAbout
      );

    $("body").on("click", "button#submit", function () {
        var theTag = $(this);
        $.get("Home/ThankYou", function (data) {
            theTag.closest("body").find("div.container").html(data);
        });
    });
});