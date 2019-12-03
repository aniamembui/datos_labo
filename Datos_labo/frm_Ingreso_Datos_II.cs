using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Heladera2
{
    public partial class Form1 : Form
    {
        public string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Datos_Lab");

        public Form1()
        {
            InitializeComponent();

            //------------------------------**********************************-------------------------
            //
            //Verifica que el DIRECTORIO exista, si no , lo crea.
            //
            //------------------------------**********************************-------------------------
            //MessageBox.Show(path, "Path");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                //MessageBox.Show(path, "Creando el directorio");
            }
        }
		
		// agregado como sobreacarga al constructor para setear por parámetro el texto del LABEL  ppal. al momento de instanciarlo.
	public Form1( string texto_label )
        {
            InitializeComponent();

			this.lbl_Main.Text = texto_label ;
			
            //------------------------------**********************************-------------------------
            //
            //Verifica que el DIRECTORIO exista, si no , lo crea.
            //
            //------------------------------**********************************-------------------------
            //MessageBox.Show(path, "Path");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                //MessageBox.Show(path, "Creando el directorio");
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {


        }


        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_Usuario.Text))
           //bool flag_usr     = true;
           bool flag_temp    = false;
           bool flag_humedad = false;
           bool flag_hora = false;

           //while (string.IsNullOrWhiteSpace(txt_Usuario.Text) && flag )
            if (string.IsNullOrWhiteSpace(txt_Usuario.Text))
            {
                MessageBox.Show("Por favor, complete el nombre de usuario.", "Formulario incompleto");
                //InitializeComponent();
                txt_Usuario.Focus();
                //txt_Usuario.Refresh();
                //flag_usr = true; 
            }

            if (txt_Usuario.Text.Length > 0)
            {
                //--------Validación de ingreso de Temperatura
                decimal temperatura;
                decimal.TryParse(txt_Temp.Text, out temperatura);
                Regex regularExpression = new Regex(@"^-?\d+(\,\d{1,2})?$");
                //anda OK, pero no admite negativos: ^\d+(\,\d{1,2})?$
                // signo NEGATIVO opcional, agregar : -?
                //string temp = txt_Temp.Text.ToString();
                Match match = regularExpression.Match(txt_Temp.Text);
                if (match.Success)
                {
                    //MessageBox.Show("Valid Number");
                    flag_temp = true;
                }
                else
                {
                    MessageBox.Show("Campo \"Temperatura\" vacío o inválido", "Formulario incompleto");

                    txt_Temp.Text = null;
                    txt_Temp.Focus();

                }
                //****************************************************
                //--------FIN DE Validación de ingreso de Temperatura

                //Comienzo validacion Humedad===============================================================

                if (flag_temp)
                {
                    decimal humedad;
                    decimal.TryParse(txt_Humedad.Text, out humedad);
                    regularExpression = new Regex(@"^\d{0,2}(\,\d{1,2})?$");
                    // Adminte SÖLO 2 dígitos y los decimales son opcionales :-) 
                    //anda OK, pero no admite negativos: ^\d+(\,\d{1,2})?$
                    // signo NEGATIVO opcional, agregar : -?
                    //string humed = txt_Humedad.Text.ToString();
                    match = regularExpression.Match(txt_Humedad.Text);
                    if (match.Success)
                    {
                        //MessageBox.Show("Valid Number");
                        flag_humedad = true;
                    }
                    else
                    {
                        MessageBox.Show("Campo \"Humedad\" vacío o inválido", "Formulario incompleto");

                        txt_Humedad.Text = null;
                        txt_Humedad.Focus();

                    }
                }
                //Fin validacion Humedad===============================================================

                //****************************************************
                //--------Comienzo DE Validación de ingreso de FORMATO HORA

                {
                    //--------Validación de ingreso de FORMATO HORA
                    if (flag_humedad)
                    {
                        regularExpression = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
                        //de http://stackoverflow.com/questions/884848/regular-expression-to-validate-valid-time
                        // signo NEGATIVO opcional, agregar : -?
                        //string temp = txt_Temp.Text.ToString();
                        match = regularExpression.Match(txt_Hora.Text);
                        if (match.Success)
                        {
                            //MessageBox.Show("Valid Number");
                            flag_hora = true;
                        }
                        else
                        {
                            MessageBox.Show("Campo \"Hora....\" vacío o inválido", "Formulario incompleto");

                            txt_Hora.Text = null;
                            txt_Hora.Focus();

                        }
                        //****************************************************
                        ////****************************************************
                    }//--------FIN DE Validación de ingreso de FORMATO HORA
                    //****************************************************

                    //if ((txt_Temp.TextLength > 0) && !(string.IsNullOrEmpty(txt_Usuario.Text)) && !(string.IsNullOrEmpty(txt_Humedad.Text))  /*&& flag*/ )
                    if (flag_temp && flag_humedad && flag_hora)
                    {
                        string str = txt_Usuario.Text + ";" + txt_Temp.Text + ";" + txt_Humedad.Text;

                        if ((temperatura < 2) || (temperatura > 8))
                        {

                            // aviso de confirmacion
                            string msg_aviso = temperatura + " se encuentra fuera del rango: desea confirmar dicha temperatura?";
                            DialogResult resultado = MessageBox.Show(msg_aviso, "Verifique por favor", MessageBoxButtons.YesNo);

                            if (resultado == DialogResult.Yes)
                            {
                                //A_File.AppendAllText(@"c:\users\Admin\file.txt", str + Environment.NewLine);

                                File.AppendAllText(path + "\\" + lbl_Main.Text + ".txt", str + ";" + txt_Hora.Text + ";" + dtP_Fecha.Text + ";" + System.Convert.ToString(DateTime.Now) + ";" + Environment.NewLine);
                            }
                            else //if (resultado == DialogResult.No)
                            {
                                txt_Temp.Text = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La temperatura ingresada se encuentra dentro del rango esperado. :-)");
                            // File.AppendAllText(@"@ruta\file.txt", str  + System.Convert.ToString(DateTime.Now) + ";" + Environment.NewLine);
                            //File.AppendAllText( filePath , str  + System.Convert.ToString(DateTime.Now) + ";" + Environment.NewLine);

                            File.AppendAllText(path + "\\" + lbl_Main.Text + ".txt", str + ";" + txt_Hora.Text + ";" + dtP_Fecha.Text + ";" + System.Convert.ToString(DateTime.Now) + ";" + Environment.NewLine);

                        }
                    }

                }// Fin de validacion : IF(FLAG)
            }
        }//FIN btn_Ingresar_Click

        private void txt_Temp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /*decimal d;
            if (decimal.TryParse(txt_Temp.Text, out d))
            {
                //valid 
                MessageBox.Show(d.ToString(), "Valido");
            }
            else
            {
                //invalid
                MessageBox.Show("Please enter a valid number");
                return;
            }*/
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_temp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Hora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     }     

          
    }
               
