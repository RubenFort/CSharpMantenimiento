using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mantenimiento
{
    class ClassConexion : ClassDatos
    {
        private static ClassConexion _instance = new ClassConexion();
        SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-32EVP44\SQLEXPRESS;Initial Catalog=empleados;Integrated Security=True");

        public ClassConexion()
        {
            try
            {
                conect.Open();
                MessageBox.Show("Conexión establecida");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                conect.Close();
            }
        }

        public static ClassConexion GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ClassConexion();
            }
            return _instance;
        }

        public SqlConnection getConect()
        {
            return conect;
        }

        public void conectar()
        {
            
        }

    }
}
