import { Memoria } from "./memoria.js";
let memoria = new Memoria();

class Usuario {
    constructor(pId, pNombre, pTelefono, pEmail, pDireccion) {
        this.id = pId;
        this.nombre = pNombre;
        this.telefono = pTelefono;
        this.email = pEmail;
        this.direccion = pDireccion;
    }

    usuarios = memoria.MemGet(2);
    actualIdUsuario = memoria.MemGet("idUsuario");

    Agregar() {
        let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
        let contrasena = document.getElementById('contrasena').value.trim();

        if (!nombreUsuario || !contrasena) {
            alert("Complete todos los campos");
            return;
        }

        if (BuscarPosicionPorNombre(nombreUsuario) !== -1) {
            alert("Este usuario ya existe");
            return;
        }

        const usuario = { id: actualIdUsuario, nombreUsuario, contrasena };
        usuarios.push(usuario);
        actualIdUsuario++;
        memoria.MemSet("idUsuario", actualIdUsuario);
        memoria.MemSet(2, usuarios);
        Listars();
        LimpiarCajas();
    }

    Eliminar() {
        let id = parseInt(document.getElementById('lista').value);
        let posicion = BuscarPosicion(id);

        if (posicion != -1) {
            usuarios.splice(posicion, 1);
            for (let i = posicion; i < usuarios.length; i++) {
                const usuario = usuarios[i];

                usuario.id = usuario.id - 1;
            }
            memoria.MemSet("idUsuario", --actualIdUsuario);
            Listars();
        }

        memoria.MemSet(2, usuarios);
        Listars();
        document.getElementById('lista').value = 1;
    }

    Modificar() {
        let id = parseInt(document.getElementById('lista').value);
        let posicion = BuscarPosicion(id);
        let nombreUsuario = document.getElementById('nombre-usuario').value.trim();
        let contrasena = document.getElementById('contrasena').value.trim();

        if (posicion === -1) {
            alert("Seleccione el usuario a modificar");
            return;
        }

        if (!nombreUsuario || !contrasena) {
            alert("Complete todos los campos");
            return;
        }

        usuarios[posicion] = { id, nombreUsuario, contrasena };
        memoria.MemSet(2, usuarios);
        Listars();
        LimpiarCajas();
    }

    Listars() {
        let lista = document.getElementById('lista').options;
        lista.length = 0;

        for (let usuario of usuarios) {
            let elemento = new Option(`${usuario.id} : ${usuario.nombreUsuario}`, usuario.id);
            lista.add(elemento);
        }
        memoria.MemSet(2, usuarios);
    }

    Seleccionar() {
        let id = parseInt(document.getElementById('lista').value);

        for (let usuario of usuarios) {
            if (usuario.id === id) {
                document.getElementById('nombre-usuario').value = usuario.nombreUsuario;
                document.getElementById('contrasena').value = usuario.contrasena;
            }
        }
    }

    LimpiarCajas() {
        document.getElementById('nombre-usuario').value = "";
        document.getElementById('contrasena').value = "";
        document.getElementById('lista').value = 0;
    }

    BuscarPosicion(id) {
        for (let i = 0; i < usuarios.length; i++) {
            if (usuarios[i].id === id) {
                return i;
            }
        }
        return -1;
    }

    BuscarPosicionPorNombre(nombreUsuario) {
        for (let i = 0; i < usuarios.length; i++) {
            if (usuarios[i].nombreUsuario === nombreUsuario) {
                return i;
            }
        }
        return -1;
    }
}