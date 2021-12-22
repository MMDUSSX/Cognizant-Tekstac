//WRITE YOUR jQUERY CODE HERE
$(".add-row").click(function(){
    var name=$('#name').val();
    var tr="<tr><td><input type='checkbox' name='record'></td><td>"+name+"</td></tr>";
    $("#frm table tbody").append(tr);
});

$(".delete-row").click(function(){
    $('input:checked').parents("tr").remove();
});