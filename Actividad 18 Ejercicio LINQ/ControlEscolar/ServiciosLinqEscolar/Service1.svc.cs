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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<usuario> obtenerUsuarios()
        {
            List<usuario> usuariosBD = UsuarioDAO.obtenerUsuarios();
            return usuariosBD;
        }

        public Mensaje iniciarSesion(string username, string password)
        {
            Mensaje usuariosBD = UsuarioDAO.iniciarSesion(username, password);

            return usuariosBD;
        }

        public Boolean guardarUsuario(usuario usuarioNuevo)
        {
            Boolean guardadoConfirmacion = UsuarioDAO.guardarUsuario(usuarioNuevo);
            return guardadoConfirmacion;
        }

        public Boolean editarUsuario(usuario usuarioEdicion)
        {
            Boolean usuarioEditado = UsuarioDAO.editarUsuario(usuarioEdicion);
            return usuarioEditado;
        }

        public bool eliminarUsuario(int idUsuario)
        {
            Boolean usuarioBorrado = UsuarioDAO.eliminarUsuario(idUsuario);
            return usuarioBorrado;
        }
    }
}
