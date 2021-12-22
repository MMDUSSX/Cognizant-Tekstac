//WRITE YOUR JQUERY CODE HERE
$('#signup_div').hide();
$('#signup').click(function () {
    $('#login_div').hide();
    $('#signup_div').show();
});
$('#login').click(function () {
     $('#signup_div').hide();
    $('#login_div').show();
});
