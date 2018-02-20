namespace PasswordChecker
{
    partial class FrmPasswordCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsrPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCompPass = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your password:";
            // 
            // txtUsrPass
            // 
            this.txtUsrPass.Location = new System.Drawing.Point(59, 25);
            this.txtUsrPass.Name = "txtUsrPass";
            this.txtUsrPass.Size = new System.Drawing.Size(100, 20);
            this.txtUsrPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(70, 51);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCompPass
            // 
            this.txtCompPass.Location = new System.Drawing.Point(59, 80);
            this.txtCompPass.Name = "txtCompPass";
            this.txtCompPass.Size = new System.Drawing.Size(100, 20);
            this.txtCompPass.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(214, 9);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmPasswordCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 111);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtCompPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsrPass);
            this.Controls.Add(this.label1);
            this.Name = "FrmPasswordCheck";
            this.Text = "Password Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsrPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCompPass;
        private System.Windows.Forms.Button btnQuit;
    }
}

