$('#btnRegistrar').on("click", function () {    
    var descripcion = $('#descripcion').val();
    
    var validacion = descripcion == "";
    if (validacion) {
        $('#ErrorOperacionRegion').show();            
        $('#ErrorDescripcion').text('EL CAMPO DESCRIPCION ES OBLIGATORIO').show();      
        return false;
    }
    else {
        return true;
    }
});



function MostrarIdModalEliminarRegion(id) {
    $('#ventanaModalEliminar').show();
    document.getElementById('idRegion').value = id;
}




