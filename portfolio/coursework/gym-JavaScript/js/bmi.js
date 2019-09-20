var $ = function(id) {
    return document.getElementById(id)
};

const MINWEIGHT =1;
const MINHEIGHT =12;
const MAXWEIGHT =777;
const MAXHEIGHT =96;

function processEntries() {
    var weight = document.bmiForm.weight.value;
    var height = document.bmiForm.height.value;

    if((isNaN(weight)) || (weight < MINWEIGHT) || (weight > MAXWEIGHT))
    {
        $("weight").nextElementSibling.firstChild.nodeValue = "BAD INPUT!";
    }
    else {
        $("weight").nextElementSibling.firstChild.nodeValue = "";
    }

    if((isNaN(height)) || (height < MINHEIGHT) || (height > MAXHEIGHT))
    {
        $("height").nextElementSibling.firstChild.nodeValue = "BAD INPUT!";
    }
    else {
        $("height").nextElementSibling.firstChild.nodeValue = "";
    }

    if(weight > 0 && height > 0){
        var finalBmi = (weight/(height * height)) * 703;
        document.bmiForm.bmi.value = finalBmi}

        if(finalBmi < 18.50){
            document.bmiForm.meaning.value = "You are underweight."}
        if(finalBmi >= 18.50 && finalBmi < 25.00){
            document.bmiForm.meaning.value = "You are healthy."}
        if(finalBmi >= 25 && finalBmi < 30.00){
            document.bmiForm.meaning.value = "You are overweight."}
        if(finalBmi >= 30){
            document.bmiForm.meaning.value = "You are obese."}
};

var clear = function() {
    $("height").value = "";
    $("weight").value = "";
    $("bmi").value = "";
    $("status").value = "";
    $("height").nextElementSibling.firstChild.nodeValue = "*";
    $("weight").nextElementSibling.firstChild.nodeValue = "*";
    $("height").focus();
};

window.onload = function() {
    $("calculate").onclick = processEntries;
    $("reset").onclick     = clear;
    $("height").focus();
};