

let modal = document.querySelector(".modal");
console.log(modal);
window.addEventListener("click", function (e) {
    if (e.target == modal) {
        modal.classList.remove("modal--active");
    }

});