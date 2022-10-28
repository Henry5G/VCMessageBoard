function AlertName(name) {

    alert('You clicked ' + name + "!");

}

function FacultyPage() {

    document.location.href = "Home/Contact";
    alert("Yes");
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