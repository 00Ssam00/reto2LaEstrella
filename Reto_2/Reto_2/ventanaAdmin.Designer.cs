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
            this.btnEstado = new System.Windows.Forms.Button();
            this.busquedaRadicado = new System.Windows.Forms.TextBox();
            this.lblBuscarRadicado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_datos
            // 
            this.dvg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_datos.Location = new System.Drawing.Point(9, 10);
            this.dvg_datos.Margin = new System.Windows.Forms.Padding(2);
            this.dvg_datos.Name = "dvg_datos";
            this.dvg_datos.ReadOnly = true;
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
            this.btnHome.Location = new System.Drawing.Point(938, 463);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Size = new System.Drawing.Size(35, 35);
            this.btnHome.TabIndex = 2;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(375, 539);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(501, 539);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(112, 23);
            this.btnEstado.TabIndex = 4;
            this.btnEstado.Text = "CAMBIAR ESTADO";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // busquedaRadicado
            // 
            this.busquedaRadicado.Location = new System.Drawing.Point(375, 513);
            this.busquedaRadicado.Name = "busquedaRadicado";
            this.busquedaRadicado.Size = new System.Drawing.Size(100, 20);
            this.busquedaRadicado.TabIndex = 5;
            // 
            // lblBuscarRadicado
            // 
            this.lblBuscarRadicado.AutoSize = true;
            this.lblBuscarRadicado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarRadicado.Location = new System.Drawing.Point(366, 495);
            this.lblBuscarRadicado.Name = "lblBuscarRadicado";
            this.lblBuscarRadicado.Size = new System.Drawing.Size(120, 15);
            this.lblBuscarRadicado.TabIndex = 6;
            this.lblBuscarRadicado.Text = "Cuadro de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Busqueda por correo, tipo de solicitud, o radicado";
            // 
            // ventanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBuscarRadicado);
            this.Controls.Add(this.busquedaRadicado);
            this.Controls.Add(this.btnEstado);
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
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.TextBox busquedaRadicado;
        private System.Windows.Forms.Label lblBuscarRadicado;
        private System.Windows.Forms.Label label1;
    }
}