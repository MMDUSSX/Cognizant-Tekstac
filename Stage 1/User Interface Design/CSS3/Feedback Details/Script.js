var feedbacks=[];
function addFeedback(){
 //Fill the required logic 
 const newFeedback=document.getElementById("feedback").value;
 feedbacks.push(newFeedback);
 console.log(feedbacks);
 document.getElementById("feedback").value="";
 document.getElementById("result").innerHTML="<h2>Feedback Details</h2><b>Successfully Added Feedback Details!</b>";
}

function displayFeedback(){
    //Fill the required logic
    document.getElementById("result").innerHTML="<h2>Feedback Details</h2>";
    for (var i = 0; i < feedbacks.length ; i++) {
        document.getElementById("result").innerHTML += "Feedback "+(i+1)+"<br>"+feedbacks[i]+"<br>";
    }
    feedbacks=[];
}