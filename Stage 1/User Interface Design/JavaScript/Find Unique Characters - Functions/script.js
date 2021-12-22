function modifyString(str)
{
    //fill code here
    var newStr = "";
    for (var i=0;i<str.length;i++){
        if (str[i] !== " ") newStr += str[i];
    }
    return newStr.toLowerCase();
}

function uniqueCharacters(str)
{
    //fill code here
    var modifiedStr = modifyString(str);
    var profile = {};
    var result = "";
    for (var i=0;i<modifiedStr.length;i++){
        if (profile[modifiedStr[i]] === undefined){
            profile[modifiedStr[i]] = true;
            result += modifiedStr[i];
        }
    }
    return result;
}  

console.log(uniqueCharacters("Welcome to the Javascript course"));