namespace Reto_2
{
    partial class ventanaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAdmin));
            this.dvg_datos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_datos
            // 
            this.dvg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_datos.Location = new System.Drawing.Point(12, 12);
            this.dvg_datos.Name = "dvg_datos";
            this.dvg_datos.RowHeadersWidth = 51;
            this.dvg_datos.RowTemplate.Height = 24;
            this.dvg_datos.Size = new System.Drawing.Size(1289, 552);
            this.dvg_datos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reto_2.Properties.Resources.Captura_de_pantalla_2025_04_01_104725;
            this.pictureBox1.Location = new System.Drawing.Point(12, 604);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ventanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvg_datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaAdmin";
            this.Text = "ventanaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_datos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}