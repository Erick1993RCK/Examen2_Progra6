"use strict";
var SolicitudEdit;
(function (SolicitudEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(SolicitudEdit || (SolicitudEdit = {}));
//# sourceMappingURL=Edit.js.map