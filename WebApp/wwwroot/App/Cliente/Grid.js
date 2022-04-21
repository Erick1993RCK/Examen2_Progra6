"use strict";
var ClienteGrid;
(function (ClienteGrid) {
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro seleccionado?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Cliente/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    ClienteGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(ClienteGrid || (ClienteGrid = {}));
//# sourceMappingURL=Grid.js.map