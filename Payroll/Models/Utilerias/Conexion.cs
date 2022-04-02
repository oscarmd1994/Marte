using System;
using System.Data.SqlClient;

namespace Payroll.Models.Utilerias
{
    public class Conexion :  Encrypt
    {
        static readonly string Server = "201.149.34.185,15002";
        //static readonly string Server = "192.168.189.10";
        //static readonly string Db = "IPSNet_Copia";
        static readonly string Db = "PayrollM";
        //static readonly string User = "IPSNet";
        static readonly string User = "PayrollM";
        //static readonly string Pass = "IPSNet2";
        static readonly string Pass = "M@rteN@mina";
        protected SqlConnection conexion { get; set; }
        protected SqlConnectionStringBuilder connection { get; set;}
        protected SqlConnection Conectar()
        {
            try {
                conexion = new SqlConnection("Data Source=" + Server + ";Initial Catalog=" + Db + ";User ID=" + User + ";Password=" + Pass + ";Integrated Security=False");
                conexion.Open();
                return conexion;
            } catch (Exception exc) {
                Console.WriteLine(exc);
                return null;
            }
        }

    }
}