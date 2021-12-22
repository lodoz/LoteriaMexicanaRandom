var espanol = {
    "emptyTable": "Sin registros",
    "info": "Mostrando _START_ a _END_ de _TOTAL_ registros",
    "infoEmpty": "Mostrando 0 a 0 de 0 entradas",
    "infoFiltered": "(Filtrado de _MAX_ total registros)",
    "lengthMenu": "Mostrar _MENU_ registros",
    "loadingRecords": "Cargando...",
    "processing": "En proceso...",
    "search": "Buscar:",
    "zeroRecords": "No se encontraron registros",
    "paginate": {
        "first": "Primera",
        "last": "Ultima",
        "next": "Siguiente",
        "previous": "Anterior"
    },
    "aria": {
        "sortAscending": ":  activar para ordenar la columna ascendente",
        "sortDescending": ":  activar para ordenar la columna descendente"
    }
};

function DateToFormat(data) {
    if (data.data == null)
        return "";

    var dateTime = data.data.split("T");
    var date = dateTime[0].split("-");
    var time = dateTime[1].split(":");

    var toSt = date[2] + "-" + date[1] + "-" + date[0] + " " + time[0] + ":" + time[1];
    return toSt;
}