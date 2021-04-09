$(document).ready(function () {
    LoadDatatable();

});
function LoadDatatable() {
    var AjaxPath = 'https://localhost:44357/'+'Home/GetAll';

    CallAsyncJSONEmpty(AjaxPath,
        function functionSuccessCallBack(xData) {
            var response = xData.data;

            if (response.Success === true) {

                    ShowDataTable(response.Value);
                
            }
            else {

              
            }

        }
    );
}
function ShowDataTable(DataList) {
    $('#TblData').DataTable({
        scrollX: true,
        destroy: true,
        data: DataList,
        columns: [
            { title: 'LLAVE USUARIO ', data: 'LLAVE_USUARIO', class: 'text-center' },
            { title: 'NOMBRE', data: 'NOMBRE', class: 'text-center' },
            //{ title: 'Cliente UUID', data: 'CustomerCode', class: 'text-center' },
            { title: 'USUARIO', data: 'USUARIO', class: 'text-center' },
            { title: 'EMAIL', data: 'EMAIL', class: 'text-center' },
            {
                //Add link columns
                class: 'text-center',
                title: 'ver',
                data: function (row, type, val, meta) {
                    var generadorIcono = IconsGenerator.GenerateButtonEdit(row.LLAVE_USUARIO);
                    return generadorIcono;
                }
            }
           
        ],
    });
}
$(document).on('click', '.btnEdit', function () {

    var AjaxPath = 'https://localhost:44357/' + 'Home/Edit';

    var Id = $(this).attr("refEdit");
   
    var formData = new FormData();
    formData.append('Id', Id);

    CallAsyncObject(
        AjaxPath,
        formData,
        function functionSuccessCallBack(xData) {
            var response = xData.data;
            if (response.Success) {
                Edit(response.Value);
                $('#Edit').modal('show');

            }
            else {

            }
        }
    )
});
function Edit(data) {
    $('#NOMBRE').val(data.NOMBRE);
    $('#LLAVE_USUARIO').val(data.LLAVE_USUARIO);
   
}

