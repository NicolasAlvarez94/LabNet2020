



function AgregarRegion() {
    var frm = new FormData();
    var descripcion = $('#descripcion').val();
    frm.append("Descripcion", descripcion);

    $.ajax({
        type: "POST",
        url: "Region/RegistrarRegion",
        data: frm,
        contentType: false,
        processData: false,
        success: function (data) {
            MostrarModalRegistrar();
        }
    });
}


function MostrarIdModalEliminarRegion(id) {
    $('#ventanaModalEliminar').show();
    document.getElementById('idRegion').value = id;   
}