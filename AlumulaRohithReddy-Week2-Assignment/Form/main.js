let Form = document.getElementById("form");
let Nameerrmsg = document.getElementById("nameerror");
let Emailerror = document.getElementById("mailerror");
let Numerror = document.getElementById("numerror");
let Polyerror= document.getElementById("polerror")
let Reqerror = document.getElementById("reqerror");
let Msgerror = document.getElementById("msgerror");
let Ratingerror = document.getElementById("ratingerror");
let SuccessMsg = document.getElementById("successmsg");

Form.addEventListener("submit", function(e) {
    e.preventDefault();
    Nameerrmsg.textContent = "";
    Emailerror.textContent = "";
    Numerror.textContent= "";
    Polyerror.textContent = "";
    Reqerror.textContent = "";
    Msgerror.textContent = "";
    SuccessMsg.textContent = "";
    Ratingerror.textContent="";
    const Name = document.getElementById("name").value.trim();
    const Email = document.getElementById("mail").value.trim();
    const PNumber = document.getElementById("number").value.trim();
    const RequestT = document.getElementById("request").value;
    const PolicyT = document.getElementById("policy").value;
    const Message = document.getElementById("message").value.trim();
    const Rate1 = document.getElementById("rate1");
    const Rate2 = document.getElementById("rate2");
    const Rate3 = document.getElementById("rate3");
    const Rate4 = document.getElementById("rate4");
    const Rate5 = document.getElementById("rate5");
    

    let valid = true;
    if (Name === "") {
        Nameerrmsg.textContent = "Name is required";
        valid = false;
    }
    if (Email === "") {
        Emailerror.textContent = "Email is required";
        valid = false;
    }

    if (!/^[0-9]{10}$/.test(PNumber)) {
       Numerror.textContent = "Enter 10 digit mobile number";
        valid = false;
    }

    if (RequestT === "Select Request Type") {
        Reqerror.textContent = "Please select request type";
        valid = false;
    }

    if (PolicyT === "Select Policy") {
        Polyerror.textContent = "Please select policy";
        valid = false;
    }

    if (Message.length < 10) {
        Msgerror.textContent = "Minimum 10 characters required";
        valid = false;
    }
    if (!(Rate1.checked || Rate2.checked || Rate3.checked || Rate4.checked || Rate5.checked)) {
      Ratingerror.textContent= "Please select a rating";
        valid = false;
    }
    if (valid) {
        SuccessMsg.textContent = "Thank you! Your enquiry has been successfully submitted.";
        Form.reset();
    }
});
