function AlertName(name) {

    alert('You clicked ' + name + "!");

}

function Greet(name) {

    alert('Hello ' + name + "!");

}

$(document).ready(function () {
    $("#signin-button").click(function () {
        
        $('#signin').toggleClass('centered');
        $('#register').toggleClass('centered');
    })

    $("#register-button").click(function () {

        $('#signin').toggleClass('centered');
        $('#register').toggleClass('centered');
    })
});







//function ChangePosition(divId) {

//    if (document.getElementById(divId).classList.contains('centered') {
//        document.getElementById(divId).classList.remove('centered');
//        document.getElementById(divId).classList.add('off-screen');
//        alert("Changed");
//    } else {
//        document.getElementById(divId).classList.remove('off-screen');
//        document.getElementById(divId).classList.add('centered');
//    }
//}