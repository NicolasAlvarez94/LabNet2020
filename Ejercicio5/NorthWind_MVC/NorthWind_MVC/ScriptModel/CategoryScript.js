
$('#btnCategory').on("click", function () {
    var nombre = $('#nombre').val();
    var descripcion = $('#descripcion').val();
    var imagen = $('#imagen').val();

    var validacion = nombre == "" || descripcion == "" || imagen == "";
    if (validacion) {
        $('#AlertaError').show();

        if (nombre == "") {
            $('#ErrorNombre').text('EL CAMPO NOMBRE ES OBLIGATORIO').show();
        }
        if (descripcion == "") {
            $('#ErrorDescripcion').text('EL CAMPO DESCRIPCION ES OBLIGATORIO').show();
        }
        if (imagen == "") {
            $('#ErrorImagen').text('EL CAMPO IMAGEN ES OBLIGATORIO').show();
        }
        return false;
    }
    return true;
});


$('#btnEliminar').on("click", function () {
    $('#ventanaModalEliminar').show();
});


function EliminarCategoria(id) {
    $('#ventanaModalEliminar').show();
    document.getElementById('idCategoria').value = id;    
}



$('form input').on("focus", function () {
    $('#AlertaError').hide();
    $('#ErrorNombre').hide();
    $('#ErrorDescripcion').hide();
    $('#ErrorImagen').hide();
})