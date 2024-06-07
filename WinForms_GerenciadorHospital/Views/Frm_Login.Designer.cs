namespace WinForms_GerenciadorHospital
{
    partial class Frm_Login
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
            Btn_Logar = new Button();
            Txt_User = new TextBox();
            Txt_Senha = new TextBox();
            SuspendLayout();
            // 
            // Btn_Logar
            // 
            Btn_Logar.Location = new Point(188, 145);
            Btn_Logar.Name = "Btn_Logar";
            Btn_Logar.Size = new Size(100, 23);
            Btn_Logar.TabIndex = 0;
            Btn_Logar.Text = "Login";
            Btn_Logar.UseVisualStyleBackColor = true;
            Btn_Logar.Click += Btn_Logar_Click;
            // 
            // Txt_User
            // 
            Txt_User.Location = new Point(188, 32);
            Txt_User.Name = "Txt_User";
            Txt_User.Size = new Size(100, 23);
            Txt_User.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(188, 83);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.Size = new Size(100, 23);
            Txt_Senha.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 226);
            Controls.Add(Txt_Senha);
            Controls.Add(Txt_User);
            Controls.Add(Btn_Logar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Logar;
        private TextBox Txt_User;
        private TextBox Txt_Senha;
    }
}
