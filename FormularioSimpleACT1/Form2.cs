using FormularioSimpleACT1.DataAccess;
using System;
using System.Windows.Forms;

namespace FormularioSimpleACT1
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexion dataAccess = new Conexion();
            // Obtiene la informacion del cuadro de texto Servidor,Base de datos y contrseñay lo asigna a la variable 
            string servidor = txtServidor.Text;
            string usuario = txtUsuario.Text;
            string bd = txtBaseDeDatos.Text; 
            string contraseña = txtContraseña.Text;
            // Construye una cadena de conexión 
            string cadena = $"Server={servidor}; Database={bd}; User={usuario}; Password={contraseña};"; 

            if (dataAccess.IntentoDeConexion(cadena)) // Llama al IntentoDeConexion de la instancia dataAccess y verifica
            {
                dgv.DataSource = dataAccess.ObtenerDatos(cadena); // Si la conexión es exitosa
            }
            else
            {
                MessageBox.Show("No se puede establecer conexión"); // Si la conexión no es exitosa, muestra un mensaje de error 
            }
        }
    }
}
