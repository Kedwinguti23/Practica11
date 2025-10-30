using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("El nombre unicamente debe contener letras.",
                                "Esta entrada es invalida",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                txtNombre.Text = string.Empty;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEdad.Text, @"^\d*$"))
            {
                MessageBox.Show("La edad unicamente debe contener numeros.",
                                "La entrada esinvalida",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                txtEdad.Text = string.Empty;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string edadTexto = txtEdad.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edadTexto))
            {
                MessageBox.Show(" Por favor completa todos los campos.",
                              "Campos vacios",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(edadTexto, out int edad))
            {
                if (edad >= 18 & edad <= 50)
                {
                    MessageBox.Show($" Se Bienvenido! {nombre}, acceso permitido.",
                             "La validacion fue exitosa",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No puedes entrar, debes ser mayor de edad",
                            "El acceso fue denegado",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                }
            }

            else {
                MessageBox.Show("La edad ingresada no es valida.",
                            "Error de formato",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
