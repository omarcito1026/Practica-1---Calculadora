namespace Practica_1
{
    partial class frn_Burbuja
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
            Ddesordenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Dordenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            OrdenarB = new Button();
            ((System.ComponentModel.ISupportInitialize)Ddesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dordenado).BeginInit();
            SuspendLayout();
            // 
            // Ddesordenado
            // 
            Ddesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Ddesordenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            Ddesordenado.Location = new Point(30, 45);
            Ddesordenado.Name = "Ddesordenado";
            Ddesordenado.Size = new Size(167, 336);
            Ddesordenado.TabIndex = 0;
            Ddesordenado.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.Name = "Column1";
            // 
            // Dordenado
            // 
            Dordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dordenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            Dordenado.Location = new Point(465, 45);
            Dordenado.Name = "Dordenado";
            Dordenado.Size = new Size(167, 336);
            Dordenado.TabIndex = 1;
            Dordenado.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // OrdenarB
            // 
            OrdenarB.Location = new Point(276, 127);
            OrdenarB.Name = "OrdenarB";
            OrdenarB.Size = new Size(75, 23);
            OrdenarB.TabIndex = 2;
            OrdenarB.Text = "Ordenar";
            OrdenarB.UseVisualStyleBackColor = true;
            OrdenarB.Click += OrdenarB_Click;
            // 
            // frn_Burbuja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrdenarB);
            Controls.Add(Dordenado);
            Controls.Add(Ddesordenado);
            Name = "frn_Burbuja";
            Text = "Ordenamiento burbuja";
            ((System.ComponentModel.ISupportInitialize)Ddesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dordenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Ddesordenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView Dordenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button OrdenarB;
    }
}