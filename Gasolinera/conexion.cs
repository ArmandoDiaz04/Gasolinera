using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

public class Conexion : IDisposable
{
    private readonly string cadenaConexion;

    public Conexion(string cadenaConexion)
    {
        this.cadenaConexion = cadenaConexion;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public SqlConnection ObtenerConexion()
    {
        return new SqlConnection(cadenaConexion);
    }

   
}
