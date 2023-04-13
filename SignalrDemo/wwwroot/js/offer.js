"use strict";

let connection = new signalR.HubConnectionBuilder().withUrl("/offershub").build();

connection.start().then(function () {
    console.log('Connection started.......!')
}).catch(function (err) {
    return console.error(err.toString());
});

connection.on("SendOffersToUser", function (offer) {
    let li = document.createElement("li");
    document.getElementById("offers").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${offer}`;
});