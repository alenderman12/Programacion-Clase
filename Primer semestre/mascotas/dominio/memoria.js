export class Memoria {
    constructor(){}

    MemSet(clave, valor) {
        localStorage.setItem(clave, JSON.stringify(valor));
    }

    MemGet(clave) {
        const datos = localStorage.getItem(clave);

        if(datos) {
            return JSON.parse(datos);
        }
        return null;
    }
}