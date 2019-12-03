namespace main_lab_DATOS
{
    partial class frm_IngDatosLabo_Main
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
            this.btn_Heladera1 = new System.Windows.Forms.Button();
            this.btn_Heladera2 = new System.Windows.Forms.Button();
            this.btn_Ambiente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Heladera1
            // 
            this.btn_Heladera1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Heladera1.Location = new System.Drawing.Point(3, 45);
            this.btn_Heladera1.Name = "btn_Heladera1";
            this.btn_Heladera1.Size = new System.Drawing.Size(115, 36);
            this.btn_Heladera1.TabIndex = 0;
            this.btn_Heladera1.Text = "Heladera 1";
            this.btn_Heladera1.UseVisualStyleBackColor = true;
            this.btn_Heladera1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Heladera2
            // 
            this.btn_Heladera2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Heladera2.Location = new System.Drawing.Point(124, 45);
            this.btn_Heladera2.Name = "btn_Heladera2";
            this.btn_Heladera2.Size = new System.Drawing.Size(121, 36);
            this.btn_Heladera2.TabIndex = 1;
            this.btn_Heladera2.Text = "Heladera 2";
            this.btn_Heladera2.UseVisualStyleBackColor = true;
            this.btn_Heladera2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Ambiente
            // 
            this.btn_Ambiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ambiente.Location = new System.Drawing.Point(251, 45);
            this.btn_Ambiente.Name = "btn_Ambiente";
            this.btn_Ambiente.Size = new System.Drawing.Size(122, 36);
            this.btn_Ambiente.TabIndex = 2;
            this.btn_Ambiente.Text = "Ambiente";
            this.btn_Ambiente.UseVisualStyleBackColor = true;
            this.btn_Ambiente.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Heladera1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Ambiente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Heladera2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 169);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_Header, 3);
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(3, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lbl_Header.Size = new System.Drawing.Size(345, 35);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "Ingrese los datos por  favor: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(124, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_IngDatosLabo_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_IngDatosLabo_Main";
            this.Text = "Ingreso de Datos Laboratorio";
            this.Load += new System.EventHandler(this.frm_IngDatosLabo_Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Heladera1;
        private System.Windows.Forms.Button btn_Heladera2;
        private System.Windows.Forms.Button btn_Ambiente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button button1;
    }
}

