using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace ABMproductosRicardo
{
    class Conexiones
    {
        OleDbConnection conexion;
        public OleDbConnection Pconexion { get => conexion; set => conexion = value; }
        OleDbCommand comando;
        public OleDbCommand Pcomando { get => comando; set => comando = value; }
        OleDbDataReader lector;
        public OleDbDataReader Plector { get => lector; set => lector = value; }
        DataTable tabla;
        public DataTable Ptabla { get => tabla; set => tabla = value; }
        string cadenaconexion;
        public string Pcadenaconexion { get => cadenaconexion; set => cadenaconexion = value; }

        public Conexiones(string strconeccion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            lector = null;
            tabla = new DataTable();
            cadenaconexion = strconeccion;
        }

        public void conectar()
        {
            conexion.ConnectionString = cadenaconexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public void Consultartabla(string nombretabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombretabla;
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            
        }

        public void Leertabla(string nombretabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombretabla;
            lector = comando.ExecuteReader();
        }

        public void consultas(string consultaSQL)
        {
            conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();
            desconectar();
        }
    }
}
