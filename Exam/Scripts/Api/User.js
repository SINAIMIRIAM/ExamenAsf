$(document).ready(function () {
 
     
});

function Save() {
    var xmodel = new FormData();
    xmodel.append('email', $('#email').val());
    xmodel.append('password', $('#password').val());
    xmodel.append('username', $('#username').val());
    xmodel.append('name', $('#name').val());

    CallAsyncObject(
        'https://localhost:44357/' + 'Home/Save'
        , xmodel
        , function functionSuccessCallBack(xData) {
            var sData = xData.data;
            if (sData.Success) {

                $('#ModalSuccess').modal('show');
                $('#email').val('');
                $('#password').val('');
                $('#username').val('');
                $('#name').val('');
            }

            else {
                $('#ModalError').modal('show');
            }
        });
}
$(document).on("click", "#Save", function (e) {
    $('#lForm').validate({
        rules: {
            username: {
                required: true
            },
            name: {
                required: true
            },
            password: {
                required: true
            },
            email: {
                required: true,
                email: true
            },
        },
        messages: {
            username: {
                required: "*Campo requerido."

            },
            name: {
                required: "*Campo requerido."
               
            },
            password: {
                required: "* Ingrese su contraseña."
                //minlength: "Your username must consist of at least 2 characters"
            },
            email: {
                required: "*Campo requerido.",
                email: "* Ingrese una cuenta de correo electrónico válida."
            },
        },
        errorElement: "em",
        errorPlacement: function (error, element) {
            // Add the `help-block` class to the error element
            error.addClass("help-block");
            // Add `has-feedback` class to the parent div.form-group
            // in order to add icons to inputs
            element.parents(".col-sm-10").addClass("has-feedback");
            if (element.prop("type") === "checkbox") {
                error.insertAfter(element.parent("label"));
            } else {
                error.insertAfter(element);
            }
        },
        
        submitHandler: function () {
            Save();
         }
       
    }); // end validate

});