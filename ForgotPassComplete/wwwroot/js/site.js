$("#rememberMe ,#btnLogin").click(function () {
    CreateCookie()
})

function CreateCookie() {

    let email = $('#Email').val()
    let password = $('#password').val()
    let rememberMe = $('#rememberMe').is(':checked')

    let date = new Date()
    let ckTillDate = new Date(date.setDate(date.getDate() + 30)).toGMTString();
    // let ckTillDate = new Date(date.setDate(date.getDate() + -1)).toGMTString();
    if (rememberMe) {
        document.cookie = 'username' + '=' + btoa(email) + ';expires=' + ckTillDate;
        document.cookie = 'password' + '=' + btoa(password) + ';expires=' + ckTillDate;
    }
    else {
        document.cookie = 'username=; expires=;'
        document.cookie = 'password=; expires=;'
    }
}

//function GetCookie(name) {
//    let cookie = document.cookie.split(';');
//    for (var i = 0; i < cookie.length; i++) {
//        let ck = cookie[i].trim()
//        if (ck.startsWith(name + '=')) {
//            return ck.substring(name.length + 1)
//        }
//    }
//    return null
//}

//window.onload = function () {
//    let email = GetCookie('username')
//    let password = GetCookie('password')
//    if (email && password) {
//        $('#Email').val(atob(email))
//        $('#password').val(atob(password))
//        $('#rememberMe').prop('checked',true)
//    }

//}



$(document).ready(function () {

    $("#btnRegister").click(function () {

        var user = {
            "fName": $("#floatingName").val(),
            "lname": $("#LastName").val(),
            "Email": $("#floatingEmail").val(),
            "phone": $("#floatingPhone").val(),
            "DOB": $("#floatingdob").val(),
            "Referral": $("#floatingref").val(),
            "Address": $("#floatingadd").val(),
            "State": $("#state").val(),
            "Location": $("#floatingloc").val(),
            "Password": $("#floatingPass").val(),
            "ConfirmPassword": $("#floatingcnfPass").val()

        }
        $.ajax({
            "url": "Register",
            "method": "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            //contentType: 'application/json',
            data: JSON.stringify(user),
            "success": function (response) {
               
            },
            "error": function (err) {
                console.log(err)
            }
        })

    })

})