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
            tabPage2 = new TabPage();
            label1 = new Label();
            Nombrebox = new TextBox();
            apellidosbox = new TextBox();
            label2 = new Label();
            Fecha = new DateTimePicker();
            RegistrarB = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "REGISTRO";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(RegistrarB);
            tabPage2.Controls.Add(Fecha);
            tabPage2.Controls.Add(apellidosbox);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(Nombrebox);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Nombrebox
            // 
            Nombrebox.Location = new Point(47, 61);
            Nombrebox.Name = "Nombrebox";
            Nombrebox.Size = new Size(276, 23);
            Nombrebox.TabIndex = 1;
            // 
            // apellidosbox
            // 
            apellidosbox.Location = new Point(47, 124);
            apellidosbox.Name = "apellidosbox";
            apellidosbox.Size = new Size(276, 23);
            apellidosbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // Fecha
            // 
            Fecha.Location = new Point(47, 209);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(238, 23);
            Fecha.TabIndex = 4;
            // 
            // RegistrarB
            // 
            RegistrarB.Location = new Point(361, 267);
            RegistrarB.Name = "RegistrarB";
            RegistrarB.Size = new Size(75, 23);
            RegistrarB.TabIndex = 5;
            RegistrarB.Text = "Registrar";
            RegistrarB.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
    }
}