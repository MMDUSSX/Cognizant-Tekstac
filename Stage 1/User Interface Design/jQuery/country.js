$("#btn-id").click(function() {
    //get data    
    $.getJSON("https://reqres.in/api/users?page=2", function(json) {
      $("#data-id").html('')
      json.data.forEach(function(jd) {
        $("#data-id").append("<ul><li>"+jd.id + "--" + jd.email + '<br>');
      })
    });
  });