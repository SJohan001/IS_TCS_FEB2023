using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosLinqEscolar.Modelo
{
    public static class UsuarioDAO
    {
        public static List<usuario> obtenerUsuarios()
        {
            DataClassesEscolarUVDataContext conexionBD = getConnection();

            IQueryable<usuario> usuariosBD = from usuarioQuery in conexionBD.usuario
                                          select usuarioQuery;

            return usuariosBD.ToList();
        }

        //tarea
        public static Mensaje iniciarSesion(string username, string password)
        {
            DataClassesEscolarUVDataContext conexionBD = getConnection();

            var usuariosBD = (from usuarioQuery in conexionBD.usuario
                                             where username == usuarioQuery.username 
                                             && password == usuarioQuery.password
                                             select usuarioQuery).FirstOrDefault();

            Mensaje mensajeRespuesta = new Mensaje();

            if(usuariosBD == null)
            {
                mensajeRespuesta.error = true;
                mensajeRespuesta.mensaje = "Usuario no encontrado";
                mensajeRespuesta.usuarioLogin = usuariosBD;
            }
            else
            {
                mensajeRespuesta.error = false;
                mensajeRespuesta.mensaje = "Usuario encontrado";
                mensajeRespuesta.usuarioLogin = usuariosBD;
            }

            return mensajeRespuesta;
        }

        public static Boolean guardarUsuario(usuario usuarioNuevo)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuario = new usuario()
                {
                    nombre = usuarioNuevo.nombre,
                    apellidoPaterno = usuarioNuevo.apellidoPaterno,
                    apellidoMaterno = usuarioNuevo.apellidoMaterno,
                    username = usuarioNuevo.username,
                    password = usuarioNuevo.password
                };
                conexionBD.usuario.InsertOnSubmit(usuario);
                conexionBD.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Boolean editarUsuario(usuario usuarioEdicion)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuarioEdit = (from quertyUsuario in conexionBD.usuario
                                   where usuarioEdicion.idUsuario == quertyUsuario.idUsuario
                                   select quertyUsuario).FirstOrDefault();

                if (usuarioEdit != null)
                {
                    usuarioEdit.nombre = usuarioEdicion.nombre;
                    usuarioEdit.apellidoPaterno = usuarioEdicion.apellidoPaterno;
                    usuarioEdit.apellidoMaterno = usuarioEdicion.apellidoMaterno;
                    usuarioEdit.password = usuarioEdicion.password;
                    conexionBD.SubmitChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        
        public static Boolean eliminarUsuario(int idUsuario)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                usuario usuarioEliminar = (from quertyUsuario in conexionBD.usuario
                                   where idUsuario == quertyUsuario.idUsuario
                                   select quertyUsuario).FirstOrDefault();

                if (usuarioEliminar != null)
                {
                    conexionBD.usuario.DeleteOnSubmit(usuarioEliminar);
                    conexionBD.SubmitChanges();
                    return true;
                }
                else 
                    return false;

            }
            catch (Exception ex) { return false; }
        }

        public static DataClassesEscolarUVDataContext getConnection()
        {
            return new DataClassesEscolarUVDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["escolarUVConnectionString"].
                ConnectionString);
        }
    }
}