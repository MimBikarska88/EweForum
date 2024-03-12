﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#confirm").on("click", function (e) {
    fetch("/Account/Logout", {
        method: "post"
    })
        .then(res => window.location = window.location.origin+"/home")
        .catch(err => console.log(err));
    $("#confirmLogout").hide();
    $('.modal-backdrop').remove();
});

$("#password-change-back-edit").on("click", function () {
    window.location = window.location.origin + "/Account/Edit"
});