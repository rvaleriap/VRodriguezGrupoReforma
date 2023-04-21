document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("formulario").addEventListener('submit', validarFormulario);
});


function validarFormulario(evento) {
    evento.preventDefault();
    var txtNombre = document.getElementById('txtNombre').value;
    if (txtNombre.length == 0) {
        alert('No has escrito nada en el nombre');
        return;
    }
    var txtEdad = document.getElementById('txtEdad').value;
    if (txtEdad.length == 0) {
        alert('No has escrito nada en la edad');
        return;
    }
    if (txtEdad > 90) {
        alert('La Edad no es válida');
        return;
    } else {
        if (txtEdad < 10) {
            alert('La Edad no es válida');
            return;
        }
    }

    var txtDireccion = document.getElementById('txtDireccion').value;
    if (txtDireccion.length == 0) {
        alert('No has escrito nada en la direccion');
        return;
    }
    var txtCorreo = document.getElementById('txtCorreo').value;
    if (txtCorreo.length == 0) {
        alert('No has escrito nada en el correo');
        return;
    }
    var txtHPrincipal = document.getElementById('txtHPrincipal').value;
    if (txtHPrincipal.length == 0) {
        alert('No has escrito nada en la habilidad principal');
        return;
    }
    var txtHSecundaria = document.getElementById('txtHSecundaria').value;
    if (txtHSecundaria.length == 0) {
        alert('No has escrito nada en la habilidad secundaria');
        return;
    }

    this.submit();
}

   
  
