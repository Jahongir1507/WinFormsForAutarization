namespace WinFormsForAutarization
{
    partial class LoginForm
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
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordField
            // 
            this.PasswordField.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordField.Location = new System.Drawing.Point(112, 232);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(305, 54);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginField.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginField.Location = new System.Drawing.Point(112, 172);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(305, 54);
            this.loginField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autarization";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsForAutarization.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(53, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsForAutarization.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(53, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(112, 311);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(231, 46);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegistrationButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationButton.Location = new System.Drawing.Point(112, 378);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(231, 45);
            this.RegistrationButton.TabIndex = 6;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 498);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.PasswordField);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox PasswordField;
        private TextBox loginField;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button LoginButton;
        private Button RegistrationButton;
    }
}