// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//$("#AddAppBtn").on("click", function () {
//    var txtCompany = $("#company");
//    var txtTitle = $("title");
//    var txtLocation = $("location");
//    var txtSticker = $("sticker");

//    // Add Row
//    var row = tBody.insertRow(-1);

//    // Add Company
//    var cell = $(row.insertCell(-1));
//    cell.html(txtCompany.val());

//    // Add Title
//    var cell = $(row.insertCell(-1));
//    cell.html(txtTitle.val());

//    // Add Location
//    var cell = $(row.insertCell(-1));
//    cell.html(txtLocation.val());

//    // Add Sticker
//    var cell = $(row.insertCell(-1));
//    cell.html(txtSticker.val());

//    // Add it to database
//    $.ajax({
//        type: 'POST',
//        url: '/Home/Applications/StudentId',
//        data: {
//            Company: txtCompany.val,
//            Title: txtTitle,
//            Location: txtLocation,
//            Sticker: txtSticker
//        },
//        success: function () {
//            alert("success!");
//        }
//        error: function () {
//            alert("fail to upload")
//        }
//    });
//});