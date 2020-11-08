

$('#btnRegistrar').on("click", function () {
    var apellido = $('#Apellido').val();
    var nombre = $('#Nombre').val();
    var edad = $('#Edad').val();

    var validacion = nombre == "" || apellido == "" || edad == "";
    if (validacion) {
        $('#AlertaErrorFormulario').show();

        if (nombre == "") {
            $('#ErrorNombre').text('EL CAMPO NOMBRE ES OBLIGATORIO').show();
        }
        if (apellido == "") {
            $('#ErrorApellido').text('EL CAMPO APELLIDO ES OBLIGATORIO').show();
        }
        if (edad == "") {
            $('#ErrorEdad').text('EL CAMPO EDAD ES OBLIGATORIO').show();
        }
        return false;
    }
    return true;
});


$('#btnRegistrar').on("click", function () {
    $('ModalPage').show();
});


$('#btnLimpiar').on("click", function () {
    LimpiarCampos();
});


function LimpiarCampos() {
    $("form input[type='Text'], form input[type='number'").each(function () {
        this.value = ''
    });
}


$('form input').on("focus", function () {
    $('#AlertaErrorFormulario').hide();
    $('#ErrorNombre').hide();
    $('#ErrorApellido').hide();
    $('#ErrorEdad').hide();
})