"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();




connection.start().then(function () {
    var myVariable = "Patient Data";
    connection.invoke("SendMyVariable", myVariable).catch(function (err) {
        console.err(err.toString());
    });
}).catch(function (err) {
    console.error(err.toString());
});
