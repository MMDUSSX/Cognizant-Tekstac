var count = 0;
$("input[type='checkbox']").change(function () {
  if (this.checked) count++;
  else count--;

  if (count === 1) {
    $("#result").text(count + " box is checked");
    return;
  }

  $("#result").text(count + " boxes are checked");
});
