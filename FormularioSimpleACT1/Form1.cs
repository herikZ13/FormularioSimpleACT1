using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormularioSimpleACT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // paso 1 validar que ambas contraseñas sean iguales 
            // paso 2 validar que la contraseña cuente
            // 12 caracteres,mayusculas,minusculas , 3 simbolos especiales y Al menos uno sea numero 
            //^(?=(?:[^A-Z]*[A-Z]){1})(?=(?:[^a-z]*[a-z]){1})(?=(?:\D*\d){1})(?=(?:[^\W_]*[\W_]){3}[^\W_]*$)[A-Za-z\d\W_]{12}$
            // 1Ss456@!!234
            string regexPattern = @"^(?=(?:[^A-Z]*[A-Z]){1})(?=(?:[^a-z]*[a-z]){1})(?=(?:\D*\d){1})(?=(?:[^\W_]*[\W_]){3}[^\W_]*$)[A-Za-z\d\W_]{12}$";
            string primeraContrasena = txtPrimeracontraseña.Text;
            string segundaContrasena = txtrepetircontraseña.Text;

            if (!primeraContrasena.Equals(segundaContrasena))
            {
                MessageBox.Show("la contraseñas NO son iguales", "VERIFIQUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(primeraContrasena, regexPattern))
            {
                MessageBox.Show("la contraseña NO ES VALIDA", "VERIFIQUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("la contraseña ES VALIDA", "EXITO!");

        }
    }
}
