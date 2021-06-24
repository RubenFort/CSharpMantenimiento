using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento
{
    class ClassDbObject:ClassDatos
    {
        private ClassConexion ctx = ClassConexion.GetInstance();

        public void insertar()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();//Instruccion Transacqt-SQL o procedimiento almacenado que se ejecuta en una BD SQLServer
                cmd.Connection = ctx.getConect();
                //ctx.getConect().Open();
                //conect.Open();
                cmd.CommandText = ("insertar");//Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando, en este caso, procedimiento almacenado
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@edad", SqlDbType.Int);
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@departamento", SqlDbType.VarChar, 200);

                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@edad"].Value = edad;
                cmd.Parameters["@direccion"].Value = direccion;
                cmd.Parameters["@departamento"].Value = departamento;

                cmd.ExecuteNonQuery();//Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas

                MessageBox.Show("Los datos fueron insertados correctamente");

                Form1 obj = new Form1();
                obj.Show();
                ctx.getConect().Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ctx.getConect().Close();
            }
        }

        public void actualizar()
        {
            try
            {
                //SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-32EVP44\SQLEXPRESS;Initial Catalog=empleados;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();//Instruccion Transacqt-SQL o procedimiento almacenado que se ejecuta en una BD SQLServer
                cmd.Connection = ctx.getConect();
                //conect.Open();
                cmd.CommandText = ("actualizar");//Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando, en este caso, procedimiento almacenado
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@edad", SqlDbType.Int);
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@departamento", SqlDbType.VarChar, 200);

                cmd.Parameters["@codigo"].Value = codigo;
                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@edad"].Value = edad;
                cmd.Parameters["@direccion"].Value = direccion;
                cmd.Parameters["@departamento"].Value = departamento;

                cmd.ExecuteNonQuery();//Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas

                Form1 obj = new Form1();
                obj.Show();//Aparece otro formulario
                MessageBox.Show("Datos actualizados");
                ctx.getConect().Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ctx.getConect().Close();
            }
        }

        public void buscar(DataGridView datGrid)
        {
            try
            {
                //SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-32EVP44\SQLEXPRESS;Initial Catalog=empleados;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();//Instruccion Transacqt-SQL o procedimiento almacenado que se ejecuta en una BD SQLServer
                SqlDataAdapter dAdapter;//Adaptar datos al grid
                DataTable dTable = new DataTable();//Rellenar el grid
                cmd.Connection = ctx.getConect();
                //conect.Open();
                cmd.CommandText = "buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters["@codigo"].Value = codigo;

                dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(dTable);//Agrega filas a table o las actualiza para hacerlas coincidir con el modelo de datos

                datGrid.DataSource = dTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ctx.getConect().Close();
            }
        }

        public void eliminar(DataGridView datGrid)
        {
            try
            {
                //SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-32EVP44\SQLEXPRESS;Initial Catalog=empleados;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();//Instruccion Transacqt-SQL o procedimiento almacenado que se ejecuta en una BD SQLServer
                SqlDataAdapter dAdapter;//Adaptar datos al grid
                DataTable dTable = new DataTable();//Rellenar el grid
                cmd.Connection = ctx.getConect();
                //conect.Open();
                cmd.CommandText = "eliminar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters["@codigo"].Value = codigo;

                dAdapter = new SqlDataAdapter(cmd);
                dAdapter.Fill(dTable);//Agrega filas a table o las actualiza para hacerlas coincidir con el modelo de datos

                datGrid.DataSource = dTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ctx.getConect().Close();
            }
        }

        public void visualizar(DataGridView datGrid)
        {
            try
            {
                //SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-32EVP44\SQLEXPRESS;Initial Catalog=empleados;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();//Instruccion Transacqt-SQL o procedimiento almacenado que se ejecuta en una BD SQLServer
                SqlDataAdapter da;//Adaptar datos al grid
                DataTable table = new DataTable();//Rellenar el grid
                cmd.Connection = ctx.getConect();
                //conect.Open();
                cmd.CommandText = "select * from datos";
                /*cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters["@codigo"].Value = codigo;*/

                da = new SqlDataAdapter(cmd);
                da.Fill(table);//Agrega filas a table o lads actualiza para hacerlas coincidir con el modelo de datos

                datGrid.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ctx.getConect().Close();
            }
        }

    }
}
