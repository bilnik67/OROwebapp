
const Eten = ["<img src='css/images/koffie.png'/>", "<img src='css/images/thee.png'/>", "<img src='css/images/limonade.png'/>", "<img src='css/images/sinaasappel.png'/>", "<img src='css/images/melk.png'/>", "<img src='css/images/water.png'/>", "<img src='css/images/cola.png'/>", "<img src='css/images/fanta.png'/>", "<img src='css/images/ice_tea.png'/>", "<img src='css/images/sprite.png'/>", "<img src='css/images/avg.png'/>", "<img src='css/images/curry.png'/>", "<img src='css/images/hamburger.png'/>", "<img src='css/images/pannenkoeken.png'/>", "<img src='css/images/schotel.png'/>", "<img src='css/images/soep.png'/>", "<img src='css/images/spaghetti.png'/>", "<img src='css/images/zalm.png'/>" ];


function gekozenavond(i) {
    var keuze = document.getElementById(i);

    keuze.innerHTML = Eten[i];

}
function verwijder(i) {
    var keuze = document.getElementById(i);
    keuze.innerHTML = "";
}
function eten() {
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