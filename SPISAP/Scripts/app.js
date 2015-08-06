
$( document ).ready(function() {

    // ::: SETTINGS DEFAULTS ::: //

    $('#paisnac').val("VE");
    $('#nacionalidad').val("VE");
    $('#paissso').val("VE");
    $('#paisfamiliar').val("VE");

    $('#primerapellido').focus();


    // ::::: DROPDOWNLIST ::::: //

    // <--DATOS PERSONALES--> //

    /* Estado Civil */
    $("#edocivil").change("click", function () {
        if ($("#edocivil").val() != " " && $("#sexo").val() != " ") {
            if ($('#edocivil').val() === "Solt." && $('#sexo').val() === "F") {
                $('#tratamiento').val("Srta.");
            }
            if ($('#edocivil').val() != "Solt." && $('#sexo').val() === "F") {
                $('#tratamiento').val("Sra.");
            }
            if ($('#sexo').val() === "M") {
                $('#tratamiento').val("Sr.");
            }
        }
        //alert($('#tratamiento').val());
    });

    /* Sexo */
    $("#sexo").change("click", function () {

        if ($("#sexo").val() != " " && $("#edocivil").val() != " ") {
            if ($('#edocivil').val() === "Solt." && $('#sexo').val() === "F") {
                $('#tratamiento').val("Srta.");
            }
            if ($('#edocivil').val() != "Solt." && $('#sexo').val() === "F") {
                $('#tratamiento').val("Sra.");
            }
            if ($('#sexo').val() === "M") {
                $('#tratamiento').val("Sr.");
            }
        }

        $.getJSON('/Employee/GetChemiseList/' + $('#sexo').val(), function (data) {
            var items = '<option value=" ">Seleccione una Talla</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#chemise').html(items);
        });

        $.getJSON('/Employee/GetPantalonList/' + $('#sexo').val(), function (data) {
            var items = '<option value=" ">Seleccione una Talla</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#pantalon').html(items);
        });

        $.getJSON('/Employee/GetCalzadoList/' + $('#sexo').val(), function (data) {
            var items = '<option value=" ">Seleccione una Talla</option>';

            if ($('#sexo').val() != " ") {
                $.each(data, function (i, district) {
                    items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
                });
            }

            $('#calzado').html(items);
        });

    });


    $('#paisnac').change(function () {
//$.getJSON('@Url.Action("/GetMunicipioList/")' + $('#estadosso').val(), function (data) {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#paisnac').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#nacionalidad').html(items);
            $('#nacionalidad').val($('#paisnac').val());
        });

        $.getJSON('/Employee/GetEstadoList/' + $('#paisnac').val(), function (data) {
            var items = '<option value=" ">Seleccione un Estado</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#edonac').html(items);
        });

    });


    // DATOS_DE_DIRECCIÓN //
    $('#estadosso').change(function () {
//$.getJSON('@Url.Action("/GetMunicipioList/")' + $('#estadosso').val(), function (data) {
        $.getJSON('/Employee/GetMunicipioList/' + $('#estadosso').val(), function (data) {
            var items = '<option value=" ">Seleccione un Municipio</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#municipiosso').html(items);
            items = '<option value=" ">Seleccione una Parroquia</option>';
            $('#parroquiasso').html(items);
        });
    });

    $('#municipiosso').change(function () {
        //$.getJSON('@Url.Action("/GetMunicipioList/")' + $('#estadosso').val(), function (data) {
        $.getJSON('/Employee/GetParroquiaList/' + $('#municipiosso').val(), function (data) {
            var items = '<option value=" ">Seleccione una Parroquia</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#parroquiasso').html(items);
        });
    });

    // DATOS_DE_FORMACIÓN //
    $('#nivel1').change(function () {
        
        //$.getJSON('@Url.Action("/GetMunicipioList/")' + $('#estadosso').val(), function (data) {
        $.getJSON('/Employee/GetCondicionList/' + $('#nivel1').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#condicion1').html(items);
        });

        $.getJSON('/Employee/GetEspecialidadList/' + $('#nivel1').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#especialidad1').html(items);
        });

    });
    $('#nivel2').change(function () {

        //$.getJSON('@Url.Action("/GetMunicipioList/")' + $('#estadosso').val(), function (data) {
        $.getJSON('/Employee/GetCondicionList/' + $('#nivel2').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#condicion2').html(items);
        });

        $.getJSON('/Employee/GetEspecialidadList/' + $('#nivel2').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#especialidad2').html(items);
        });

    });
    $('#nivel3').change(function () {

        //$.getJSON('@Url.Action("/GetMunicipioList/")' + $('#estadosso').val(), function (data) {
        $.getJSON('/Employee/GetCondicionList/' + $('#nivel3').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#condicion3').html(items);
        });

        $.getJSON('/Employee/GetEspecialidadList/' + $('#nivel3').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#especialidad3').html(items);
        });

    });
    // ::::: DROPDOWNLIST ::::: //


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
    //$("#add_row_formacion").trigger("click");
    $("#add_row_experiencia").trigger("click");


});