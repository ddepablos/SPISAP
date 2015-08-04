
$( document ).ready(function() {

    //alert('Okey Dokey !!');

    // configurar los valores por defecto para los nuevos registros.
    $('#pais').val("VE");
    $('#nacionalidad').val("VE");
    $('#paissso').val("VE");

    // Formación Académica //
    $("#add_row_formacion").on("click", function () {

        var newid = 0;
        $.each($("#tab_formacion tr"), function () {
            if (parseInt($(this).data("id")) > newid) {
                newid = parseInt($(this).data("id"));
            }
        });
        newid++;

        var tr = $("<tr></tr>", {
            id: "trformacion" + newid,        //id: "addr"+newid,
            "data-id": newid
        });

        $.each($("#tab_formacion tbody tr:nth(0) td"), function () {
            var cur_td = $(this);

            var children = cur_td.children();

            // add new td and element if it has a nane
            if ($(this).data("name") != undefined) {
                var td = $("<td></td>", {
                    "data-name": $(cur_td).data("name")
                });

                var c = $(cur_td).find($(children[0]).prop('tagName')).clone().val("");
                c.attr("name", $(cur_td).data("name") + newid);
                c.appendTo($(td));
                td.appendTo($(tr));
            } else {
                var td = $("<td></td>", {
                    'text': $('#tab_formacion tr').length
                }).appendTo($(tr));
            }
        });

        // add the new row
        $(tr).appendTo($('#tab_formacion'));

        $(tr).find("td button.row-remove").on("click", function () {
            $(this).closest("tr").remove();
        });

    });

    // Experiencia Laboral //
    $("#add_row_experiencia").on("click", function () {

        var newid = 0;
        $.each($("#tab_exp tr"), function () {
            if (parseInt($(this).data("id")) > newid) {
                newid = parseInt($(this).data("id"));
            }
        });
        newid++;

        var tr = $("<tr></tr>", {
            id: "exp" + newid,
            "data-id": newid
        });

        $.each($("#tab_exp tbody tr:nth(0) td"), function () {
            var cur_td = $(this);

            var children = cur_td.children();

            // add new td and element if it has a nane
            if ($(this).data("name") != undefined) {
                var td = $("<td></td>", {
                    "data-name": $(cur_td).data("name")
                });

                var c = $(cur_td).find($(children[0]).prop('tagName')).clone().val("");
                c.attr("name", $(cur_td).data("name") + newid);
                c.appendTo($(td));
                td.appendTo($(tr));
            } else {
                var td = $("<td></td>", {
                    'text': $('#tab_exp tr').length
                }).appendTo($(tr));
            }
        });

        // add the new row
        $(tr).appendTo($('#tab_exp'));

        $(tr).find("td button.row-remove").on("click", function () {
            $(this).closest("tr").remove();
        });

    });

    // Datos Familiares //
    $("#add_row").on("click", function () {
        // Dynamic Rows Code

        // Get max row id and set new id
        var newid = 0;
        $.each($("#tab_logic tr"), function () {
            if (parseInt($(this).data("id")) > newid) {
                newid = parseInt($(this).data("id"));
            }
        });
        newid++;

        var tr = $("<tr></tr>", {
            id: "addr" + newid,
            "data-id": newid
        });

        // loop through each td and create new elements with name of newid
        $.each($("#tab_logic tbody tr:nth(0) td"), function () {
            var cur_td = $(this);

            var children = cur_td.children();

            // add new td and element if it has a nane
            if ($(this).data("name") != undefined) {
                var td = $("<td></td>", {
                    "data-name": $(cur_td).data("name")
                });

                var c = $(cur_td).find($(children[0]).prop('tagName')).clone().val("");
                c.attr("name", $(cur_td).data("name") + newid);
                c.appendTo($(td));
                td.appendTo($(tr));
            } else {
                var td = $("<td></td>", {
                    'text': $('#tab_logic tr').length
                }).appendTo($(tr));
            }
        });

        // add delete button and td
        /*
        $("<td></td>").append(
            $("<button class='btn btn-danger glyphicon glyphicon-remove row-remove'></button>")
                .click(function() {
                    $(this).closest("tr").remove();
                })
        ).appendTo($(tr));
        */

        // add the new row
        $(tr).appendTo($('#tab_logic'));

        $(tr).find("td button.row-remove").on("click", function () {
            $(this).closest("tr").remove();
        });
    });

    // Sortable Code
    var fixHelperModified = function (e, tr) {
        var $originals = tr.children();
        var $helper = tr.clone();

        $helper.children().each(function (index) {
            $(this).width($originals.eq(index).width())
        });

        return $helper;
    };

    /*    $(".table-sortable tbody").sortable({
            helper: fixHelperModified      
        }).disableSelection();
    
        $(".table-sortable thead").disableSelection();*/

    $("#add_row").trigger("click");
    $("#add_row_formacion").trigger("click");
    $("#add_row_experiencia").trigger("click");


});