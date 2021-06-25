using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//Para arrancar utilidades

namespace Mantenimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    ClassDbObject obj_DBconexion = new ClassDbObject();
    private void btnBuscar_Click(object sender, EventArgs e)
    {
            obj_DBconexion.setCodigo(int.Parse(txtCodigo2.Text));
            obj_DBconexion.buscar(dataGridView1);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
            obj_DBconexion.setNombre(txtNombre.Text);
            obj_DBconexion.setApellido(txtApellido.Text);
            obj_DBconexion.setEdad(int.Parse(txtEdad.Text));
            obj_DBconexion.setDireccion(txtDireccion.Text);
            obj_DBconexion.setDepartamento(txtDepartamento.Text);
            obj_DBconexion.insertar();
        Hide();
    }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obj_DBconexion.visualizar(dataGridView1);
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj_form = new Form1();
            obj_form.Show();
            Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            obj_DBconexion.setCodigo(int.Parse(txtCodigo.Text));
            obj_DBconexion.setNombre(txtNombre.Text);
            obj_DBconexion.setApellido(txtApellido.Text);
            obj_DBconexion.setEdad(int.Parse(txtEdad.Text));
            obj_DBconexion.setDireccion(txtDireccion.Text);
            obj_DBconexion.setDepartamento(txtDepartamento.Text);
            obj_DBconexion.actualizar();
            Hide();//Desaparece el fomulario
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj_DBconexion.setCodigo(int.Parse(txtCodigo.Text));
            obj_DBconexion.eliminar(dataGridView1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
