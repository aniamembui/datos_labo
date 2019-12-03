using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregado para que vea el CS del form
using Registro_Heladera2;
using metodos;

namespace main_lab_DATOS
{
    public partial class frm_IngDatosLabo_Main : Form
    {
        
        public frm_IngDatosLabo_Main()
        {
            InitializeComponent();
        }
        /*
         * Obterner una propiedad del botón que genera el evento
         * http://stackoverflow.com/questions/10288214/get-the-text-of-dynamically-created-button-in-c
        You won't be able to get the text until after you populate it from the database (careful not to try and get the text too early).
        But this should work:
        ====>   string buttonText = FindControl("Button41").Text;
        Update
        Since you want the button text from within the click event, you can access the sender object:
        =======>>> CODIGO <<<<========
        Button button = sender as Button;
        string buttonText = button.Text;
        =======>>> FIN CODIGO <<<<========
        */


        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string txtNombre_Formulario = button.Text;

            Registro_Heladera2.Form1 frm_Heladera1 = new Registro_Heladera2.Form1( txtNombre_Formulario );
            frm_Heladera1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string txtNombre_Formulario = button.Text;


            Registro_Heladera2.Form1 frm_Heladera2 = new Registro_Heladera2.Form1(txtNombre_Formulario);
            frm_Heladera2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string txtNombre_Formulario = button.Text;

            Registro_Heladera2.Form1 frm_Ambiente = new Registro_Heladera2.Form1(txtNombre_Formulario);
            frm_Ambiente.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_IngDatosLabo_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
