let toggleModalClass = document.getElementById("toggle-modal");
let submitButtonOfModal = document.getElementById("submit-button");
let crossIcon = document.getElementById("cross-icon");
let openModalId = document.getElementById("open-modal");
let modalContainer = document.getElementById("modal-container");
openModalId.addEventListener("click", function () {
    openModal();
});


toggleModalClass.addEventListener("click", function (e) {
    if (e.target !== toggleModalClass) return;
    closeModal();
    console.log(e.target);
});

//document.addEventListener("click", function (e) {
//    if (e.target != modalContainer) return;
//    closeModal();
//});

submitButtonOfModal.addEventListener("click", function () {
    closeModal();
});

document.addEventListener("keyup", function (e) {
    if (e.key == "Escape") {
        closeModal();
    }

})


function closeModal() {
    toggleModalClass.classList.remove("modal-active");
    document.body.style.overflow = "auto";
}
function openModal() {
    toggleModalClass.classList.add("modal-active");
    document.body.style.overflow = "hidden";
}