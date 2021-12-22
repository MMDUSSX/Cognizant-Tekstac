
//WRITE YOUR jQUERY CODE HERE

var element = $('div > ul >li >a')
$("#each_ex").click(function(){
  element.css('background-color','red')
  $('#msg_ex').append('Home<br>Products<br>Services<br>About<br>Contact')
});