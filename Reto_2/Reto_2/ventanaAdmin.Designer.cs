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
            this.lbl_formulario = new System.Windows.Forms.Label();
            this.lbl_OlvidarContra = new System.Windows.Forms.Label();
            this.Llbl_Clickaqui = new System.Windows.Forms.LinkLabel();
            this.gtxt_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_formulario
            // 
            this.lbl_formulario.AutoSize = true;
            this.lbl_formulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.lbl_formulario.Location = new System.Drawing.Point(252, 51);
            this.lbl_formulario.Name = "lbl_formulario";
            this.lbl_formulario.Size = new System.Drawing.Size(355, 39);
            this.lbl_formulario.TabIndex = 1;
            this.lbl_formulario.Text = "Formulario de Ingreso";
            // 
            // lbl_OlvidarContra
            // 
            this.lbl_OlvidarContra.AutoSize = true;
            this.lbl_OlvidarContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.lbl_OlvidarContra.Location = new System.Drawing.Point(331, 414);
            this.lbl_OlvidarContra.Name = "lbl_OlvidarContra";
            this.lbl_OlvidarContra.Size = new System.Drawing.Size(131, 13);
            this.lbl_OlvidarContra.TabIndex = 2;
            this.lbl_OlvidarContra.Text = "¿Olvidaste tu contraseña?";
            // 
            // Llbl_Clickaqui
            // 
            this.Llbl_Clickaqui.AutoSize = true;
            this.Llbl_Clickaqui.LinkColor = System.Drawing.Color.LimeGreen;
            this.Llbl_Clickaqui.Location = new System.Drawing.Point(468, 414);
            this.Llbl_Clickaqui.Name = "Llbl_Clickaqui";
            this.Llbl_Clickaqui.Size = new System.Drawing.Size(55, 13);
            this.Llbl_Clickaqui.TabIndex = 3;
            this.Llbl_Clickaqui.TabStop = true;
            this.Llbl_Clickaqui.Text = "Click aquí";
            this.Llbl_Clickaqui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbl_Clickaqui_LinkClicked);
            // 
            // gtxt_User
            // 
            this.gtxt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gtxt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_User.DefaultText = "";
            this.gtxt_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_User.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gtxt_User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gtxt_User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_User.Location = new System.Drawing.Point(308, 221);
            this.gtxt_User.Name = "gtxt_User";
            this.gtxt_User.PlaceholderText = "Identificacion";
            this.gtxt_User.SelectedText = "";
            this.gtxt_User.Size = new System.Drawing.Size(244, 37);
            this.gtxt_User.TabIndex = 4;
            // 
            // gtxt_password
            // 
            this.gtxt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gtxt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_password.DefaultText = "";
            this.gtxt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gtxt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gtxt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_password.Location = new System.Drawing.Point(308, 274);
            this.gtxt_password.Name = "gtxt_password";
            this.gtxt_password.PlaceholderText = "Contraseña";
            this.gtxt_password.SelectedText = "";
            this.gtxt_password.Size = new System.Drawing.Size(244, 37);
            this.gtxt_password.TabIndex = 5;
            // 
            // pb_Login
            // 
            this.pb_Login.BackColor = System.Drawing.Color.Gray;
            this.pb_Login.Image = global::Reto_2.Properties.Resources.Login1;
            this.pb_Login.InitialImage = global::Reto_2.Properties.Resources.Login;
            this.pb_Login.Location = new System.Drawing.Point(285, 109);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(289, 293);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 0;
            this.pb_Login.TabStop = false;
            // 
            // ventanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(884, 544);
            this.Controls.Add(this.gtxt_password);
            this.Controls.Add(this.gtxt_User);
            this.Controls.Add(this.Llbl_Clickaqui);
            this.Controls.Add(this.lbl_OlvidarContra);
            this.Controls.Add(this.lbl_formulario);
            this.Controls.Add(this.pb_Login);
            this.Name = "ventanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Login;
        private System.Windows.Forms.Label lbl_formulario;
        private System.Windows.Forms.Label lbl_OlvidarContra;
        private System.Windows.Forms.LinkLabel Llbl_Clickaqui;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_User;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_password;
    }
}