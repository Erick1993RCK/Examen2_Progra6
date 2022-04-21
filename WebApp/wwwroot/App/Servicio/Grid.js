"use strict";
var ServicioGrid;
(function (ServicioGrid) {
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro seleccionado?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Servicio/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    ServicioGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(ServicioGrid || (ServicioGrid = {}));
//# sourceMappingURL=Grid.js.map