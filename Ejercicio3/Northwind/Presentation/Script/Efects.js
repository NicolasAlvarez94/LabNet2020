

function HideMessage() {
    document.getElementById('alertError').hidden = true;
}

function ShowModal() {
    $('#ModalPage').modal('show');
}

function ShowModalDelete() {
    $('#ModalDelete').modal('show');
}

function HideModalDelete() {
    $('#ModalDelete').modal('hide');
}

function ShowAlert() {
    document.getElementById('alertError').style.display = 'block';
}

function ShowAlertSuccessful() {
    document.getElementById('SuccessfulAlert').style.display = 'block';
}