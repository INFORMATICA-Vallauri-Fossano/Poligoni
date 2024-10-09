namespace EsPoligoniAnrangoRamosGionsi
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
            this.txtLunghezzalato = new System.Windows.Forms.TextBox();
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.nudNumeroLati = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.lblApotema = new System.Windows.Forms.Label();
            this.lblAltezza = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.btnInserisciPoligono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroLati)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLunghezzalato
            // 
            this.txtLunghezzalato.Location = new System.Drawing.Point(12, 31);
            this.txtLunghezzalato.Name = "txtLunghezzalato";
            this.txtLunghezzalato.Size = new System.Drawing.Size(165, 22);
            this.txtLunghezzalato.TabIndex = 0;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.AllowUserToResizeColumns = false;
            this.dgvProperties.AllowUserToResizeRows = false;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Location = new System.Drawing.Point(328, 12);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.RowHeadersVisible = false;
            this.dgvProperties.RowHeadersWidth = 51;
            this.dgvProperties.RowTemplate.Height = 24;
            this.dgvProperties.Size = new System.Drawing.Size(460, 219);
            this.dgvProperties.TabIndex = 1;
            // 
            // nudNumeroLati
            // 
            this.nudNumeroLati.Location = new System.Drawing.Point(12, 90);
            this.nudNumeroLati.Name = "nudNumeroLati";
            this.nudNumeroLati.Size = new System.Drawing.Size(120, 22);
            this.nudNumeroLati.TabIndex = 1;
            this.nudNumeroLati.ValueChanged += new System.EventHandler(this.nudNumeroLati_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lunghezza del Lato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero dei Lati";
            // 
            // txtApotema
            // 
            this.txtApotema.Enabled = false;
            this.txtApotema.Location = new System.Drawing.Point(12, 165);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(165, 22);
            this.txtApotema.TabIndex = 2;
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Enabled = false;
            this.lblApotema.Location = new System.Drawing.Point(9, 146);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(154, 16);
            this.lblApotema.TabIndex = 6;
            this.lblApotema.Text = "Lunghezza dell\'Apotema";
            // 
            // lblAltezza
            // 
            this.lblAltezza.AutoSize = true;
            this.lblAltezza.Enabled = false;
            this.lblAltezza.Location = new System.Drawing.Point(9, 190);
            this.lblAltezza.Name = "lblAltezza";
            this.lblAltezza.Size = new System.Drawing.Size(142, 16);
            this.lblAltezza.TabIndex = 8;
            this.lblAltezza.Text = "Lunghezza dell\'Altezza";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Enabled = false;
            this.txtAltezza.Location = new System.Drawing.Point(12, 209);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(165, 22);
            this.txtAltezza.TabIndex = 3;
            // 
            // btnInserisciPoligono
            // 
            this.btnInserisciPoligono.Location = new System.Drawing.Point(202, 12);
            this.btnInserisciPoligono.Name = "btnInserisciPoligono";
            this.btnInserisciPoligono.Size = new System.Drawing.Size(120, 41);
            this.btnInserisciPoligono.TabIndex = 4;
            this.btnInserisciPoligono.Text = "INSERISCI";
            this.btnInserisciPoligono.UseVisualStyleBackColor = true;
            this.btnInserisciPoligono.Click += new System.EventHandler(this.btnInserisciPoligono_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.btnInserisciPoligono);
            this.Controls.Add(this.lblAltezza);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.lblApotema);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumeroLati);
            this.Controls.Add(this.dgvProperties);
            this.Controls.Add(this.txtLunghezzalato);
            this.Name = "Form1";
            this.Text = "Poligoni Regolari";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroLati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLunghezzalato;
        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.NumericUpDown nudNumeroLati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.Label lblAltezza;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Button btnInserisciPoligono;
    }
}

