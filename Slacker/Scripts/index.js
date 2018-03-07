$(document).ready(function () {
 
    
        var t = false;
        var showDiv = function () {
        $('#buttest').html('Show less &laquo;');
    $('.js-anim1').fadeIn(500);
            $('.js-anim2').delay(1000).fadeIn(500);
            $('.js-anim3').delay(2000).fadeIn(500);
            t = true;
        };
        var hideDiv = function () {
        $('#buttest').html('Show more &raquo;');
    $('.js-anim3').fadeOut(500);
            $('.js-anim2').delay(1000).fadeOut(500);
            $('.js-anim1').delay(2000).fadeOut(500);
            t = false;
        };
        var button = $('#buttest');
        hideDiv();
        button.click(function () {
            if (t == false) {
        showDiv();
    } else {
        hideDiv();
    }
        });
        $(".js-anim1").hover(function () {
        $(this).css("background-color", "antiquewhite");
    }, function () {
        $(this).css("background-color", "azure");
    })
        $(".js-anim2").hover(function () {
        $(this).css("background-color", "antiquewhite");
    }, function () {
        $(this).css("background-color", "azure");
    })
        $(".js-anim3").hover(function () {
        $(this).css("background-color", "antiquewhite");
    }, function () {
        $(this).css("background-color", "azure");
    })

    });
