namespace Sim_Botic
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.Btn_signup = new System.Windows.Forms.Button();
            this.Btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_signup
            // 
            this.Btn_signup.BackgroundImage = global::Sim_Botic.Properties.Resources.WhatsApp_Image_2025_01_06_at_15_03_45;
            this.Btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_signup.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_signup.ForeColor = System.Drawing.Color.White;
            this.Btn_signup.Location = new System.Drawing.Point(420, 592);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(195, 54);
            this.Btn_signup.TabIndex = 0;
            this.Btn_signup.Text = "Signup";
            this.Btn_signup.UseVisualStyleBackColor = true;
            this.Btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // Btn_login
            // 
            this.Btn_login.BackgroundImage = global::Sim_Botic.Properties.Resources.WhatsApp_Image_2025_01_06_at_15_03_45;
            this.Btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_login.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_login.Location = new System.Drawing.Point(103, 592);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(195, 54);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Sim_Botic.Properties.Resources.WhatsApp_Image_2025_01_06_at_15_03_45;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 719);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Btn_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_signup;
        private System.Windows.Forms.Button Btn_login;
    }
}

