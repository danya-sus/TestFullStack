
var card = document.querySelectorAll(".carCard");

function script() {
    this.classList.toggle("is-flipped");
}

card.forEach(e => e.addEventListener('click', script));