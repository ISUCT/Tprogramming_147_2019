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

// MDB Lightbox Init
$(function() {
  $("#mdb-lightbox-ui").load("mdb-addons/mdb-lightbox-ui.html");
});

//карточка в контактах
var card = new TimelineMax();

card
  .set(".card", { autoAlpha: 0 })
  .set(".card-top-section", { y: -100, autoAlpha: 0 })
  .set(".card-block, .card-action", { y: 100, autoAlpha: 0 })
  .set(".card-img-top", { autoAlpha: 0, scale: 0.5 })
  .to(".card", 0.5, { autoAlpha: 1, ease: Quad.easeInOut })
  .to(".card-top-section, .card-block, .card-action", 0.35, {
    autoAlpha: 1,
    y: 0,
    ease: Quad.easeInOut
  })
  .to(".card-img-top", 0.5, {
    autoAlpha: 1,
    scale: 1,
    ease: Elastic.easeInOut
  });
