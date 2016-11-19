using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DispoUtil
    {
        private DateTime _FechaInicio;
        private DateTime _FechaFinal;

        public DateTime FechaInicio
        {
            get
            {
                return _FechaInicio;
            }

            set
            {
                _FechaInicio = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return _FechaFinal;
            }

            set
            {
                _FechaFinal = value;
            }
        }

        //Constructores de la clase
        public DispoUtil()
        {

        }

        public DispoUtil(DateTime fechainicial, DateTime fechafinal)
        {
            this.FechaInicio = fechainicial;
            this.FechaFinal = fechafinal;
        }

        //Metodos de consulta
        public DataTable Consultar(DispoUtil UtilDispo)
        {
            DataTable DtResultado = new DataTable("Kpis");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Select_DispUti";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DtFechaIni = new SqlParameter();
                DtFechaIni.ParameterName = "@FechaInicio";
                DtFechaIni.SqlDbType = SqlDbType.DateTime;
                DtFechaIni.Value = UtilDispo.FechaInicio;
                SqlCmd.Parameters.Add(DtFechaIni);

                SqlParameter DtFechaFinal = new SqlParameter();
                DtFechaFinal.ParameterName = "@FechaFinal";
                DtFechaFinal.SqlDbType = SqlDbType.DateTime;
                DtFechaFinal.Value = UtilDispo.FechaFinal;
                SqlCmd.Parameters.Add(DtFechaFinal);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return DtResultado;
        }

    }
}
