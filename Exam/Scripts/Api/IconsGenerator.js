var IconsGenerator =
    (function () {

        var objReturn =
        {

            GenerateButtonEdit
                :
                function (data) {

                    return '<a class="btn btn-xxs btn-primary btn-sm btnEdit" refEdit="' + data + '" href="#" data-toggle="tooltip" data-placement="top" title="">ver  &nbsp; <i class="fas fa-edit"></i></a>';
                }
            
        };
        return objReturn;
    })();