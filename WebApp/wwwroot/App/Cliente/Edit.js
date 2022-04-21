"use strict";
var ClienteEdit;
(function (ClienteEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(ClienteEdit || (ClienteEdit = {}));
//# sourceMappingURL=Edit.js.map