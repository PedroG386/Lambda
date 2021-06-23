using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConexionBD
{
  public  class DbParameter
    {
        public string Name { get; set; }
        public ParameterDirection Direction { get; set; }
        public object Value { get; set; }

        public DbParameter(string NombreParametro, ParameterDirection TipoParametro, object ValorParametro)
        {
            Name = NombreParametro;
            Direction = TipoParametro;
            Value = ValorParametro;
        }
    }
}
