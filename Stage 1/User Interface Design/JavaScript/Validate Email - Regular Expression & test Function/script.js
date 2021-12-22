function validateEmail(email) {
    var result = (/^\w+([\.-]?\w+)@\w+([\.-]?\w+)(\.\w{2,3})+$/).test(email)
 
 if(result===true){
     return "Valid email address!"
 }
 else{
     return "Invalid email address!"
 }
 }