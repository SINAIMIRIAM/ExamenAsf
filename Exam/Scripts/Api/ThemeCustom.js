function CallAsyncObject(url, model, functionSuccessCallBack) {

    $.ajax({
        url: url,
        type: 'POST',
        data: model,
        cache: false,
        processData: false,
        contentType: false,
        beforeSend: function () { },
        success: function (xData) {
            functionSuccessCallBack(xData);
        },
        error: function (xhr, status) {
            console.log('Disculpe, existió un problema');
        },
        complete: function (xhr, status) {
        }
    });
}
function CallAsyncJSONEmpty(url, functionSuccessCallBack) {

    $.ajax({
        url: url,
        cache: false,
        data: {},
        type: 'POST',
        dataType: 'json',
        beforeSend: function () {
         
        },
        success: function (xData) {
            functionSuccessCallBack(xData);
        },
        error: function () {
            console.log('Disculpe, existió un problema');
        },
        complete: function () {
        }
    });
}