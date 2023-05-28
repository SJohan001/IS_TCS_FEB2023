using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServiciosLinqEscolar.Modelo;

namespace ServiciosLinqEscolar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<usuario> obtenerUsuarios();

        [OperationContract]
        Mensaje iniciarSesion(string username, string password);

        [OperationContract]
        Boolean guardarUsuario(usuario usuarioNuevo);

        [OperationContract]
        Boolean editarUsuario(usuario usuarioEdicion);

        [OperationContract]
        Boolean eliminarUsuario(int idUsuario);

    }
}
