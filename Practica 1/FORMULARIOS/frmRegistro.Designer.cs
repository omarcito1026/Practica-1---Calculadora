namespace Practica_1
{
    partial class frmRegistro
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            RegistrarB = new Button();
            Fecha = new DateTimePicker();
            apellidosbox = new TextBox();
            label2 = new Label();
            Nombrebox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPersona = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 454);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RegistrarB);
            tabPage1.Controls.Add(Fecha);
            tabPage1.Controls.Add(apellidosbox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Nombrebox);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "REGISTRO";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // RegistrarB
            // 
            RegistrarB.Location = new Point(367, 262);
            RegistrarB.Name = "RegistrarB";
            RegistrarB.Size = new Size(75, 23);
            RegistrarB.TabIndex = 11;
            RegistrarB.Text = "Registrar";
            RegistrarB.UseVisualStyleBackColor = true;
            RegistrarB.Click += RegistrarB_Click;
            // 
            // Fecha
            // 
            Fecha.Location = new Point(53, 204);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(238, 23);
            Fecha.TabIndex = 10;
            // 
            // apellidosbox
            // 
            apellidosbox.Location = new Point(53, 119);
            apellidosbox.Name = "apellidosbox";
            apellidosbox.Size = new Size(276, 23);
            apellidosbox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 101);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellidos";
            // 
            // Nombrebox
            // 
            Nombrebox.Location = new Point(53, 56);
            Nombrebox.Name = "Nombrebox";
            Nombrebox.Size = new Size(276, 23);
            Nombrebox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(dgvPersona);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.Click += tabPage2_Click;
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Location = new Point(0, 3);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.Size = new Size(529, 316);
            dgvPersona.TabIndex = 0;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button RegistrarB;
        private DateTimePicker Fecha;
        private TextBox apellidosbox;
        private Label label2;
        private TextBox Nombrebox;
        private Label label1;
        private DataGridView dgvPersona;
    }
}