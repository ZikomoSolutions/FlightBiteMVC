

let modal = document.querySelector(".modal");
window.addEventListener("click", function (e) {
    if (e.target == modal) {
        modal.classList.remove("modal--active");
    }

});



function toggleModalSection(modalSection) {
    var modalContainer = document.querySelectorAll(".modal--active .modal__container");
    modalContainer.forEach(e => {
        e.classList.remove("show");
        e.classList.add("hide");

    });
    document.getElementById(modalSection).classList.remove("hide");

    document.getElementById(modalSection).classList.add("show");

}