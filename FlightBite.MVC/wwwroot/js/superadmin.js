let toggleModalClass = document.getElementById("toggle-modal");

function addActiveClassOnModal() {
    toggleModalClass.classList.add("modal-active");
    document.body.style.overflow = "hidden";
}
function removeActiveClassOnModal() {
    toggleModalClass.classList.remove("modal-active");
    document.body.style.overflow = "auto";
}




document.addEventListener("keyup", function (e) {
    if (e.key == "Escape") {
        toggleModalClass.classList.remove("modal-active");
        document.body.style.overflow = "auto";
    }

})
