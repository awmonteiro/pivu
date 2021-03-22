// $('.carousel').slick({
//     dots: false,
//     infinite: true,
//     slidesToShow: 9,
//     slidesToScroll: 1
// })


$('.responsive').slick({
    dots: false,
    swipeToSlide: true,
    infinite: true,
    slidesToShow: 3,
    slidesToScroll: 1,
    mobileFirst: true,
    responsive: [{
            breakpoint: 1100,
            settings: {
                slidesToShow: 9,
                slidesToScroll: 1,
                infinite: true
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1,
                infinite: true
            }
        },
        {
            breakpoint: 600,
            settings: {
                slidesToShow: 4,
                slidesToScroll: 1,
                infinite: true
            }
        },
        {
            breakpoint: 820,
            settings: {
                slidesToShow: 6,
                slidesToScroll: 1,
                infinite: true
            }
        }
        // You can unslick at a given breakpoint now by adding:
        // settings: "unslick"
        // instead of a settings object
    ]
});