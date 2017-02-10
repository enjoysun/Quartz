; (function ($) {
    $.fn.colorful = function (option) {
        var defaultset = { color: "blue", fontsize: 20 };
        var endsetting = $.extend(defaultset, option);
        this.css({
            "background-color": "black",
            "color": endsetting.color,
            "fontSize": endsetting.fontsize
        });
    }
})(jQuery);