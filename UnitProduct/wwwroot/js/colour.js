$(document).ready(function () {
    $('tr').click(function () {
        if (this.style.background == "" || this.style.background == "white") {
            $(this).css('background', 'red');
        }
        else {
            $(this).css('background', 'white');
        }
    });
});

