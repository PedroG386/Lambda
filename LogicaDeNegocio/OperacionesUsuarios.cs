using System;
using System.Collections.Generic;
using System.Text;
using Procedures;
using Entidades;

namespace LogicaDeNegocio
{
    public class OperacionesUsuarios
    {
        
      public  static Usuarios GetUsuarioLogin(string Usuario)
        {
            return Get_UsuarioByUsuario.Get(Usuario);
        }

    }
}
