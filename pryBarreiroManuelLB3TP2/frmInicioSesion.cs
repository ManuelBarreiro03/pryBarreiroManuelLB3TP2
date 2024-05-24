using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBarreiroManuelLB3TP2
{
    public partial class frmInicioSEsion : Form
    {
        clsUsuario objUsuario = new clsUsuario();
        OleDbConnection conexionBD;
        DataSet objDS;
        string rutaArchivo, estadoConexion;
        public frmInicioSEsion()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string contra = txtContrasena.Text;
                objUsuario.ValidarUsuario(usuario, contra);
                objUsuario.RegistroLogInicioSesion();
                tssEstadoConexion.Text = objUsuario.estadoConexion;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInicioSEsion_Load(object sender, EventArgs e)
        {
            try
            {
                rutaArchivo = @"../../../resources/Archivos/BDusuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "BD Conectada";
                tssEstadoConexion.Text = estadoConexion;
            }
            catch (Exception error)
            {
                //estadoConexion = error.Message;
                MessageBox.Show(error.Message);
            }
        }
    }
}
