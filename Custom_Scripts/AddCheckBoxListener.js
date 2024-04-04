/*adding an event listener to all of the checkboxes that have active check as their class,
 * which is setup in the table so it is set that class active check. on change it's gonna call the function
 * and the functio is gonna firstly get a reference to itself, find di id
 * form the html attribute, find the value from "prop",
 * once it's done is gonna do an ajax request to the URL,
 * it's gonna do a post HTTP. That's gonna call AjaxEdit function . (the rooting system is
 * gonna look at this URL and convert that into a controller action and it's gonna call at 
 * the method below )*/

$(document).ready(function () {

    $('.ActiveCheck').change(function () {
        /*getting reference to the element itself*/

        var self = $(this);
        var id = self.attr('id');
        var value = self.prop('checked');



        $.ajax({

            url: 'ToDoes/AJAXEdit',
            data: {
                id: id,
                value: value
            },
            type: 'POST',
            success: function (result) {
                $('#tableDiv').html(result);
            }

        });

    });

});