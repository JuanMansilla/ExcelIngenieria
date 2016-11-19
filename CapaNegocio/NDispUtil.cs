using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NDispUtil
    {

        public static DataTable FechIniFIn(DateTime FechaInicio, DateTime FechaFinal)
        {
            DispoUtil Obj = new DispoUtil();
            Obj.FechaInicio = FechaInicio;
            Obj.FechaFinal = FechaFinal;
            return Obj.Consultar(Obj);
        }



    }
}
