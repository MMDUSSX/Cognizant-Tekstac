function display(){
    var sname = document.getElementById("sname").value;
    var course = document.getElementById("course").value;
    if(sname===""){
        document.getElementById("greet").innerHTML = "Name cannot be empty"
    }
    else{
        document.getElementById("greet").innerHTML = "Hi, " + sname + ". You have successfully registered for the "+ course + " course."
    }  
}