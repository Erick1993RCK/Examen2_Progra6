"use strict";
var ServicioEdit;
(function (ServicioEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(ServicioEdit || (ServicioEdit = {}));
//# sourceMappingURL=Edit.js.map