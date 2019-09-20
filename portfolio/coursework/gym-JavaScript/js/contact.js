var $ = function(id) {
    return document.getElementById(id)
};

var processEntries = function() {
    var validInput     = true;
	
    // get values for user entries
    var ssn = $("ssn").value;   
    var fname = $("fname").value;
    var lname = $("lname").value;
    var address = $("address").value;
    var city = $("city").value;
    var state = $("state").value;
    var zip = $("zip").value;
    var phone = $("phone").value;
    var gender = $("gender").value;
    var age = $("age").value;
    var reason = $("reason").value;

    // check user entries for validity
    if(isNaN(ssn))
    {
        $("ssn").nextElementSibling.firstChild.nodeValue = "BAD INPUT! Numbers Only!";
        validInput = false;
    } else {
        $("ssn").nextElementSibling.firstChild.nodeValue = "";
        validInput = true;
    }

    if(fname == "")
    {
        $("fname").nextElementSibling.firstChild.nodeValue = "BAD INPUT!";
        validInput = false;
    } else {
        $("fname").nextElementSibling.firstChild.nodeValue = "";	
        validInput = true;
    }

    if(lname == "")
    {
        $("lname").nextElementSibling.firstChild.nodeValue = "BAD INPUT!";
        validInput = false;
    } else {
        $("lname").nextElementSibling.firstChild.nodeValue = "";
        validInput = true;	
    }
    
    if (address == "") {
        $("address").nextElementSibling.firstChild.nodeValue = "This field is required.";
        validInput = false;
    } else {
        $("address").nextElementSibling.firstChild.nodeValue = "";	
        validInput = true;
    }

    if (city == "") {
        $("city").nextElementSibling.firstChild.nodeValue = "This field is required.";
        validInput = false;
    } else {
        $("city").nextElementSibling.firstChild.nodeValue = "";	
        validInput = true;
    }

    if (state == "") {
        $("state").nextElementSibling.firstChild.nodeValue = "Please select a state.";
        validInput = false;
    } else {
        $("state").nextElementSibling.firstChild.nodeValue = "";	
        validInput = true;
    }
    
    if(isNaN(phone))
    {
        $("phone").nextElementSibling.firstChild.nodeValue = "BAD INPUT! Numbers Only!";
        validInput = false;
    } else {
        $("phone").nextElementSibling.firstChild.nodeValue = "";
        validInput = true;	
    }

    if(isNaN(zip))
    {
        $("zip").nextElementSibling.firstChild.nodeValue = "BAD INPUT! Numbers Only!";
        validInput = false;
    } else {
        $("zip").nextElementSibling.firstChild.nodeValue = "";
        validInput = true;	
    }

    if( ( form.gender[0].checked == false ) && ( form.gender[1].checked == false ) ) 
    {
        $("gender").nextElementSibling.firstChild.nodeValue = "This field is required.";
        validInput = false;
    } else {
        $("gender").nextElementSibling.firstChild.nodeValue = "";
        validInput = true;	
    }
    
    if (validInput == true) {
        theTest();
    }
};

var theTest = function()
{
    alert("Your Information:" + "\n" +
            "SSN = " + ssn.value + "\n" +
            "First Name = " + fname.value + "\n" +
            "Last Name = " + lname.value + "\n" +
            "Address = " + address.value + "\n" +
            "City = " + city.value + "\n" +
            "State = " + state.value + "\n" +
            "ZipCode = " + zip.value + "\n" +
            "Phone Number = " + phone.value + "\n" +
            "Gender = " + gender.value + "\n" +
            "Age Group = " + age.value + "\n" +
            "Reason = " + reason.value + "\n");
};

var resetForm = function() {
    $("ssn").value = "";
    $("fname").value = "";
    $("lname").value = "";
    $("address").value = "";
    $("city").value = "";
    $("state").value = "";
    $("zip").value = "";
    $("phone").value = "";
    $("gender").value = "";
    $("age").value = "";
    $("reason").value = "";

    $("ssn").nextElementSibling.firstChild.nodeValue = "*";
    $("fname").nextElementSibling.firstChild.nodeValue = "*";
    $("lname").nextElementSibling.firstChild.nodeValue = "*";
    $("address").nextElementSibling.firstChild.nodeValue = "*";
    $("city").nextElementSibling.firstChild.nodeValue = "*";
    $("state").nextElementSibling.firstChild.nodeValue = "*";
    $("zip").nextElementSibling.firstChild.nodeValue = "*";	
    $("phone").nextElementSibling.firstChild.nodeValue = "*";
    $("gender").nextElementSibling.firstChild.nodeValue = "*";
    $("age").nextElementSibling.firstChild.nodeValue = "*";
    $("reason").nextElementSibling.firstChild.nodeValue = "*";

    $("ssn").focus();
};

window.onload = function() {
    $("submit").onclick = processEntries;
    $("reset").onclick = resetForm;    
    $("ssn").focus();
};