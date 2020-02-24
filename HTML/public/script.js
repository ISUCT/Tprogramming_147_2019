// для фона начало
$(".jumbotron1").css({ height: $(window).height() + "px" });

$(window).on("resize", function() {
  $(".jumbotron1").css({ height: $(window).height() + "px" });
});
$(".jumbotron2").css({ height: $(window).height() + "px" });

$(window).on("resize", function() {
  $(".jumbotron2").css({ height: $(window).height() + "px" });
});
$(".jumbotron3").css({ height: $(window).height() + "px" });

$(window).on("resize", function() {
  $(".jumbotron3").css({ height: $(window).height() + "px" });
});
// для фона конец
