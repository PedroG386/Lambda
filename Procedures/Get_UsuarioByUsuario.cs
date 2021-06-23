using ConexionBD;
using Entidades;
using System.Collections.Generic;

namespace Procedures
{
    public class Get_UsuarioByUsuario
    {

        public static Usuarios Get(string Usuario)
        {
            if (Usuario == null)
            {
                throw new System.ArgumentNullException(nameof(Usuario));
            }
            else
            {
                List<DbParameter> parametros = new List<DbParameter>
                {
                    new DbParameter(NombreParametro: "Usuario", TipoParametro: System.Data.ParameterDirection.Input, Usuario)

                    };

                CBD.DBManager conexion = new CBD.DBManager();
                return conexion.ExecuteSingle<Usuarios>("Get_UsuarioByUsuario", parametros);
            }
        }
    }
}
