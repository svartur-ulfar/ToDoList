$(document).ready(function () {


    $.ajax({
        url: '/ToDoes/BuildTabel',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    });

});

/* when document is loaded, we're doing an ajax call
 * dor ajax to request to the url and then the result
 * is put in table div defined in Index.chtml*/


