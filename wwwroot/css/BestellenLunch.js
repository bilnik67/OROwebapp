﻿function eten() {
    var x = document.getElementById("dranken");
    if (x.style.display = "flex") {
        x.style.display = "none";
    }
}
function eten2() {
    var x = document.getElementById("eten");
    if (x.style.display = "none") {
        x.style.display = "flex";
    }
}
function dranken() {
    var x = document.getElementById("eten");
    if (x.style.display = "flex") {
        x.style.display = "none";
    }
}
function dranken2() {
    var x = document.getElementById("dranken");
    if (x.style.display = "none") {
        x.style.display = "flex";
    }
}
const Eten = ["<img src='css/images/koffie.png'/>", "<img src='css/images/thee.png'/>", "<img src='css/images/limonade.png'/>", "<img src='css/images/sinaasappel.png'/>", "<img src='css/images/melk.png'/>", "<img src='css/images/water.png'/>", "<img src='css/images/boterhammen.png'/>", "<img src='css/images/broodjes.png'/>", "<img src='css/images/sandwich.png'/>", "<img src='css/images/salade.png'/>", "<img src='css/images/fruit.png'/>", "<img src='css/images/yoghurt.png'/>"];


function verwijder(i) {
    var keuze = document.getElementById(i);
    keuze.innerHTML = "";
}
function gekozen(i) {

    var keuze = document.getElementById(i);

    keuze.innerHTML = Eten[i];

}