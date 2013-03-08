$(document).ready(function () {
    $('#show-menu').click(OnClickShowMenu);
});

function OnClickShowMenu(e) {
    e.preventDefault();
    $('body').scrollTop(0);
    $('#menu').slideToggle();
}