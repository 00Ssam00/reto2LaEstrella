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
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.busquedaRadicado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_datos
            // 
            this.dvg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_datos.Location = new System.Drawing.Point(9, 10);
            this.dvg_datos.Margin = new System.Windows.Forms.Padding(2);
            this.dvg_datos.Name = "dvg_datos";
            this.dvg_datos.RowHeadersWidth = 51;
            this.dvg_datos.RowTemplate.Height = 24;
            this.dvg_datos.Size = new System.Drawing.Size(967, 448);
            this.dvg_datos.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHome.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHome.ImageRotate = 0F;
            this.btnHome.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Location = new System.Drawing.Point(9, 491);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Size = new System.Drawing.Size(35, 35);
            this.btnHome.TabIndex = 2;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(98, 527);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "XXXX";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // busquedaRadicado
            // 
            this.busquedaRadicado.Location = new System.Drawing.Point(98, 491);
            this.busquedaRadicado.Name = "busquedaRadicado";
            this.busquedaRadicado.Size = new System.Drawing.Size(100, 20);
            this.busquedaRadicado.TabIndex = 5;
            // 
            // ventanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 609);
            this.Controls.Add(this.busquedaRadicado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dvg_datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ventanaAdmin";
            this.Text = "ventanaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_datos;
        private Guna.UI2.WinForms.Guna2ImageButton btnHome;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox busquedaRadicado;
    }
}