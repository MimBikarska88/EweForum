// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
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

$("#password-change-back-edit").click( function () {
    window.location = window.location.origin + "/Account/Edit"
});


$("#pagination-select-rows").on('change', function (e) {
    var form = $("#pagination-form");
    console.log(form)
    var selectedPageSize = $(this).val();
    var actionUrl = form.attr("action");
    var updatedActionUrl = actionUrl + "&pageSize=" + selectedPageSize;
    form.attr("action", updatedActionUrl);
    form.submit();
});
$("#pagination-select-order").on('change', function (e) {
        var form = $("#pagination-form");
        console.log(form)
        var selectedPageSize = $("#pagination-select-rows").val();
        var actionUrl = form.attr("action");
        var updatedActionUrl = actionUrl + "&pageSize=" + selectedPageSize;
        form.attr("action", updatedActionUrl);
        form.submit();
});
$("#pagination-select-order-joined").on('change', function (e) {
    var form = $("#pagination-form");
    var selectedPageSize = $("#pagination-select-rows").val();
    var actionUrl = form.attr("action");
    var updatedActionUrl = actionUrl + "&pageSize=" + selectedPageSize;
    form.attr("action", updatedActionUrl);
    form.submit();
})

$('#media,#event').hide();


$("input[name*='PostType']").change(function () {
    const val = $(this).val();
    switch (val) {
        case '0': {
            $("#media").hide();
            $("#event").hide();
            $("#text").show("fade");
         
        } break;
        case '1': {
            $("#text").hide();
            $("#media").hide();
            $("#event").show("fade");
            
            
        } break;
        case '2': {
            $("#text").hide();
            $("#event").hide();
            $("#media").show('fade');
           
        }
    }
})
