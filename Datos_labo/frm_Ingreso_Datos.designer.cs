namespace Registro_Heladera2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Temperatura = new System.Windows.Forms.Label();
            this.lbl_Humedad = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Temp = new System.Windows.Forms.TextBox();
            this.txt_Humedad = new System.Windows.Forms.TextBox();
            this.lbl_RegHora = new System.Windows.Forms.Label();
            this.txt_Hora = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Main = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.dtP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(26, 61);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Usuario.Size = new System.Drawing.Size(93, 25);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            this.lbl_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Temperatura
            // 
            this.lbl_Temperatura.AutoSize = true;
            this.lbl_Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temperatura.Location = new System.Drawing.Point(26, 116);
            this.lbl_Temperatura.Name = "lbl_Temperatura";
            this.lbl_Temperatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Temperatura.Size = new System.Drawing.Size(145, 25);
            this.lbl_Temperatura.TabIndex = 1;
            this.lbl_Temperatura.Text = "Temperatura";
            // 
            // lbl_Humedad
            // 
            this.lbl_Humedad.AutoSize = true;
            this.lbl_Humedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Humedad.Location = new System.Drawing.Point(26, 171);
            this.lbl_Humedad.Name = "lbl_Humedad";
            this.lbl_Humedad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Humedad.Size = new System.Drawing.Size(111, 25);
            this.lbl_Humedad.TabIndex = 2;
            this.lbl_Humedad.Text = "Humedad";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(290, 67);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(141, 20);
            this.txt_Usuario.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(91, 332);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 38);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar Dato";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(270, 340);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_Temp
            // 
            this.txt_Temp.Location = new System.Drawing.Point(391, 122);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.Size = new System.Drawing.Size(40, 20);
            this.txt_Temp.TabIndex = 2;
            this.txt_Temp.TextChanged += new System.EventHandler(this.txt_temp_TextChanged);
            // 
            // txt_Humedad
            // 
            this.txt_Humedad.Location = new System.Drawing.Point(391, 177);
            this.txt_Humedad.Name = "txt_Humedad";
            this.txt_Humedad.Size = new System.Drawing.Size(40, 20);
            this.txt_Humedad.TabIndex = 3;
            // 
            // lbl_RegHora
            // 
            this.lbl_RegHora.AutoSize = true;
            this.lbl_RegHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegHora.Location = new System.Drawing.Point(26, 224);
            this.lbl_RegHora.Name = "lbl_RegHora";
            this.lbl_RegHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_RegHora.Size = new System.Drawing.Size(196, 25);
            this.lbl_RegHora.TabIndex = 11;
            this.lbl_RegHora.Text = "Hora del Registro";
            // 
            // txt_Hora
            // 
            this.txt_Hora.Location = new System.Drawing.Point(391, 230);
            this.txt_Hora.Mask = "00:00";
            this.txt_Hora.Name = "txt_Hora";
            this.txt_Hora.Size = new System.Drawing.Size(40, 20);
            this.txt_Hora.TabIndex = 4;
            this.txt_Hora.ValidatingType = typeof(System.DateTime);
            this.txt_Hora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_Hora_MaskInputRejected);
            // 
            // lbl_Main
            // 
            this.lbl_Main.AutoSize = true;
            this.lbl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Main.Location = new System.Drawing.Point(120, 9);
            this.lbl_Main.Name = "lbl_Main";
            this.lbl_Main.Size = new System.Drawing.Size(0, 25);
            this.lbl_Main.TabIndex = 13;
            this.lbl_Main.Click += new System.EventHandler(this.lbl_Main_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(20, 270);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(211, 25);
            this.lbl_Fecha.TabIndex = 17;
            this.lbl_Fecha.Text = "Fecha del Registro";
            // 
            // dtP_Fecha
            // 
            this.dtP_Fecha.Location = new System.Drawing.Point(237, 275);
            this.dtP_Fecha.Name = "dtP_Fecha";
            this.dtP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtP_Fecha.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 393);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.dtP_Fecha);
            this.Controls.Add(this.lbl_Main);
            this.Controls.Add(this.txt_Hora);
            this.Controls.Add(this.lbl_RegHora);
            this.Controls.Add(this.txt_Humedad);
            this.Controls.Add(this.txt_Temp);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Humedad);
            this.Controls.Add(this.lbl_Temperatura);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "Form1";
            this.Text = "Ingreso de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Temperatura;
        private System.Windows.Forms.Label lbl_Humedad;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_Temp;
        private System.Windows.Forms.TextBox txt_Humedad;
        private System.Windows.Forms.Label lbl_RegHora;
        private System.Windows.Forms.MaskedTextBox txt_Hora;
        private System.Windows.Forms.Label lbl_Main;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.DateTimePicker dtP_Fecha;
    }
}

