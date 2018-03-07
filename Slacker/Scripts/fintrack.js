$(document).ready(function () {

    $("#SpentGainedSource").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Home/AutoComplete",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    console.log(data);
                    debugger;

                    response($.map(data, function (item) {
                        return { label: item.SpentGainedSource, value: item.SpentGainedSource };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });
    $(window).scroll(function () {
        $(".test-js").stop().animate({ "marginTop": ($(window).scrollTop()) + "px", "marginLeft": ($(window).scrollLeft()) + "px" }, "slow");
    });

});