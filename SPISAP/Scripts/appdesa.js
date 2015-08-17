
$(document).ready(function () {

    // ::: SETTINGS DEFAULTS ::: //
    $('#paisnac').val("VE");
    $('#nacionalidad').val("VE");

    $('#paissso').val("VE");
    $('#paisfamiliar').val("VE");

    $('#paissso').val("VE");

    $('#username').focus();
    //$('#cedula').focus();
    $('#ficha').focus();

    // ::::: DROPDOWNLIST ::::: //

    // <--DATOS PERSONALES--> //

    $('input[type=text]').focusout(function () {
        alert('qwoie');
        return this.value.toUpperCase();
    });

    /* Estado Civil */
    $("#edocivil").change(function () {

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
            $('#tratamientovalue').val( $('#tratamiento').val() );
        }

    });

    /* Sexo */
    $("#sexo").change(function () {

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
            var items = '<option value=" ">Seleccione un valor.</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#chemise').html(items);
        });

        $.getJSON('/Employee/GetPantalonList/' + $('#sexo').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor.</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#pantalon').html(items);
        });

        $.getJSON('/Employee/GetCalzadoList/' + $('#sexo').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor.</option>';
            if ($('#sexo').val() != " " || $('#sexo').val() != null) {
                $.each(data, function (i, district) {
                    items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
                });
            }
            $('#calzado').html(items);
            if ($('#sexo').val() == "" || $('#sexo').val() == null) {
                var items = '<option value=" ">Seleccione un valor.</option>';
                $('#calzado').html(items);
            }
        });


    });


    $('#paisnac').change(function () {

        $.getJSON('/Employee/GetNacionalidadList/' + $('#paisnac').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#nacionalidad').html(items);
            $('#nacionalidad').val($('#paisnac').val());
        });

        $.getJSON('/Employee/GetEstadoList/' + $('#paisnac').val(), function (data) {
            var items = '<option value=" ">Seleccione un valor.</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#edonac').html(items);
        });

    });


    //  D A T O S   D E   D I R E C C I Ó N  //
    $('#estadosso').change(function () {
        $.getJSON('/Employee/GetMunicipioList/' + $('#estadosso').val(), function (data) {
            var items = '<option value="">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#municipiosso').html(items);
            //items = '<option value="">Seleccione un valor¿</option>';
            $('#parroquiasso').html(items);
        });
    });

    $('#municipiosso').change(function () {
        $.getJSON('/Employee/GetParroquiaList/' + $('#municipiosso').val(), function (data) {
            var items = '<option value="">Seleccione un valor</option>';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#parroquiasso').html(items);
        });
    });


    //  D A T O S   F A M I L I A R E S  //
    $('#fpais1').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais1').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac1').html(items);
            $('#fnac1').val($('#fpais1').val());
        });
    });
    $('#fpais2').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais2').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac2').html(items);
            $('#fnac2').val($('#fpais2').val());
        });
    });
    $('#fpais3').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais3').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac3').html(items);
            $('#fnac3').val($('#fpais3').val());
        });
    });
    $('#fpais4').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais4').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac4').html(items);
            $('#fnac4').val($('#fpais4').val());
        });
    });
    $('#fpais5').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais5').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac5').html(items);
            $('#fnac5').val($('#fpais5').val());
        });
    });
    $('#fpais6').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais6').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac6').html(items);
            $('#fnac6').val($('#fpais6').val());
        });
    });
    $('#fpais7').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais7').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac7').html(items);
            $('#fnac7').val($('#fpais7').val());
        });
    });
    $('#fpais8').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais8').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac8').html(items);
            $('#fnac8').val($('#fpais8').val());
        });
    });
    $('#fpais9').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais9').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac9').html(items);
            $('#fnac9').val($('#fpais9').val());
        });
    });
    $('#fpais10').change(function () {
        $.getJSON('/Employee/GetNacionalidadList/' + $('#fpais10').val(), function (data) {
            var items = '';
            $.each(data, function (i, district) {
                items += "<option value='" + district.Value + "'>" + district.Text + "</option>";
            });
            $('#fnac10').html(items);
            $('#fnac10').val($('#fpais10').val());
        });
    });


    // DATOS_DE_FORMACIÓN //
    $('#nivel1').change(function () {

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

});