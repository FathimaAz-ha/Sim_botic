namespace Sim_Botic
{
    partial class GameBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.btnEasy_Click = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMedium = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnHard = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Final = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnEasy_Click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEasy_Click
            // 
            this.btnEasy_Click.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasy_Click.Image = global::Sim_Botic.Properties.Resources._23;
            this.btnEasy_Click.ImageRotate = 0F;
            this.btnEasy_Click.Location = new System.Drawing.Point(-225, 33);
            this.btnEasy_Click.Name = "btnEasy_Click";
            this.btnEasy_Click.Size = new System.Drawing.Size(575, 428);
            this.btnEasy_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEasy_Click.TabIndex = 0;
            this.btnEasy_Click.TabStop = false;
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedium.Image = global::Sim_Botic.Properties.Resources._32;
            this.btnMedium.ImageRotate = 0F;
            this.btnMedium.Location = new System.Drawing.Point(-295, 165);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(715, 426);
            this.btnMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMedium.TabIndex = 1;
            this.btnMedium.TabStop = false;
            this.btnMedium.UseTransparentBackground = true;
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHard.Image = global::Sim_Botic.Properties.Resources._42;
            this.btnHard.ImageRotate = 0F;
            this.btnHard.Location = new System.Drawing.Point(-181, 376);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(495, 415);
            this.btnHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHard.TabIndex = 2;
            this.btnHard.TabStop = false;
            this.btnHard.UseTransparentBackground = true;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = global::Sim_Botic.Properties.Resources._12;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(662, -13);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(438, 445);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 3;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::Sim_Botic.Properties.Resources.WhatsApp_Image_2025_01_06_at_15_03_45;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Location = new System.Drawing.Point(341, 467);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 54);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // questionTimer
            // 
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(726, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Sim_Botic.Properties.Resources.Colorful_Illustration_Login_Page_Desktop_Prototype__100_x_100_px___500_x_500_px_;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(230, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Questions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.Location = new System.Drawing.Point(341, 376);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "";
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.Size = new System.Drawing.Size(451, 48);
            this.txtAnswer.TabIndex = 14;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDifficulty.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(519, 123);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(213, 35);
            this.cmbDifficulty.TabIndex = 15;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(216, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select the level";
            // 
            // btn_Final
            // 
            this.btn_Final.BackgroundImage = global::Sim_Botic.Properties.Resources.WhatsApp_Image_2025_01_06_at_15_03_45;
            this.btn_Final.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Final.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Final.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Final.Location = new System.Drawing.Point(597, 467);
            this.btn_Final.Name = "btn_Final";
            this.btn_Final.Size = new System.Drawing.Size(195, 54);
            this.btn_Final.TabIndex = 18;
            this.btn_Final.Text = "Final";
            this.btn_Final.UseVisualStyleBackColor = true;
            this.btn_Final.Click += new System.EventHandler(this.btn_Final_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sim_Botic.Properties.Resources.WhatsApp_Image_2025_01_07_at_14_56_52;
            this.ClientSize = new System.Drawing.Size(1022, 803);
            this.Controls.Add(this.btn_Final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy_Click);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.guna2PictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            ((System.ComponentModel.ISupportInitialize)(this.btnEasy_Click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox btnEasy_Click;
        private Guna.UI2.WinForms.Guna2PictureBox btnMedium;
        private Guna.UI2.WinForms.Guna2PictureBox btnHard;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Final;
    }
}