


/*Modal functionality */

let toggleModalClass = document.getElementById("toggle-modal");
let submitButtonOfModal = document.getElementById("submit-button");
let crossIcon = document.getElementById("cross-icon");
let openModalId = document.getElementById("open-modal");
let modalContainer = document.getElementById("modal-container");
openModalId.addEventListener("click", function () {
    openModal();
});

window.addEventListener("keyup", function (e) {
    if (e.key == "Escape") {
        console.log(e.key);
        closeModal();
        backToClientSection();
    }


toggleModalClass.addEventListener("click", function (e) {
    if (e.target !== toggleModalClass) return;
    closeModal();
    backToClientSection();
});



crossIcon.addEventListener("click", function () {
    closeModal();
});
submitButtonOfModal.addEventListener("click", function () {
    closeModal();
    backToClientSection();
});


})


function closeModal() {
    toggleModalClass.classList.remove("modal-active");
    document.body.style.overflow = "auto";
}
function openModal() {
    toggleModalClass.classList.add("modal-active");
    document.body.style.overflow = "hidden";
}



var selectedClientValue;
let toggleClientType = document.getElementById("type-of-client");
let toggleClientForm = document.getElementById("client-form");
let toggleFormHeader = document.getElementById("form-header");
let toggleClientHeader = document.getElementById("client-header");
let backToClient = document.getElementById("back-to-client");

//provider.addEventListener("change", function (e) {

//    if (provider.value == "provider") {
//        console.log(provider.value);
//    }
//    if (agent.value == "agent") {
//        //console.log("agent");
//    }
//    console.log(e.value);


//});

function selectClientType(e) {
    selectedClientValue = e;

    //console.log(selectedClientValue);
}
function backToClientSection() {
    toggleClientType.classList.remove("hide");
    toggleClientForm.classList.remove("show");
    toggleClientForm.classList.add("hide");
    toggleFormHeader.classList.remove("show");
    toggleFormHeader.classList.add("hide");
    toggleClientHeader.classList.remove("hide");
}
function SelectedClient() {
    if (selectedClientValue == "agent" || selectedClientValue == "provider") {
        toggleClientType.classList.add("hide");
        toggleClientForm.classList.add("show");
        toggleClientForm.classList.remove("hide");
        toggleFormHeader.classList.add("flex");
        toggleFormHeader.classList.remove("hide");
        toggleClientHeader.classList.add("hide");
    }
    if (selectedClientValue == undefined) {
        alert("please select");
    }
}
backToClient.addEventListener("click", function () {
    backToClientSection();
});