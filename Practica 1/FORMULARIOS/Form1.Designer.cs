namespace Practica_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonC = new Button();
            Borrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            radiomultiplicacion = new RadioButton();
            radiosuma = new RadioButton();
            radiorest = new RadioButton();
            SuspendLayout();
            // 
            // botonC
            // 
            botonC.Location = new Point(401, 92);
            botonC.Name = "botonC";
            botonC.Size = new Size(75, 23);
            botonC.TabIndex = 0;
            botonC.Text = "CALCULAR";
            botonC.UseVisualStyleBackColor = true;
            botonC.Click += botonC_Click;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(401, 134);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(75, 23);
            Borrar.TabIndex = 1;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 87);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Operaciones";
            label1.Click += label1_Click;
            // 
            // radiomultiplicacion
            // 
            radiomultiplicacion.AutoSize = true;
            radiomultiplicacion.Location = new Point(535, 204);
            radiomultiplicacion.Name = "radiomultiplicacion";
            radiomultiplicacion.Size = new Size(101, 19);
            radiomultiplicacion.TabIndex = 7;
            radiomultiplicacion.TabStop = true;
            radiomultiplicacion.Text = "Multiplicacion";
            radiomultiplicacion.UseVisualStyleBackColor = true;
            // 
            // radiosuma
            // 
            radiosuma.AutoSize = true;
            radiosuma.Location = new Point(535, 122);
            radiosuma.Name = "radiosuma";
            radiosuma.Size = new Size(55, 19);
            radiosuma.TabIndex = 8;
            radiosuma.TabStop = true;
            radiosuma.Text = "Suma";
            radiosuma.UseVisualStyleBackColor = true;
            // 
            // radiorest
            // 
            radiorest.AutoSize = true;
            radiorest.Location = new Point(535, 163);
            radiorest.Name = "radiorest";
            radiorest.Size = new Size(50, 19);
            radiorest.TabIndex = 9;
            radiorest.TabStop = true;
            radiorest.Text = "resta";
            radiorest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radiorest);
            Controls.Add(radiosuma);
            Controls.Add(radiomultiplicacion);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Borrar);
            Controls.Add(botonC);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonC;
        private Button Borrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radiomultiplicacion;
        private RadioButton radiosuma;
        private RadioButton radiorest;
    }
}
