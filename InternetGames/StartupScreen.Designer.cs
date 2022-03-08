
namespace InternetGames
{
    partial class StartupScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupScreen));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BT_StartupPlay = new System.Windows.Forms.Button();
            this.BT_StartupQuit = new System.Windows.Forms.Button();
            this.BT_StartupHelp = new System.Windows.Forms.Button();
            this.LB_StartupPrivacy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_InternetPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(11, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show this every time.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BT_StartupPlay
            // 
            this.BT_StartupPlay.Location = new System.Drawing.Point(155, 333);
            this.BT_StartupPlay.Name = "BT_StartupPlay";
            this.BT_StartupPlay.Size = new System.Drawing.Size(75, 23);
            this.BT_StartupPlay.TabIndex = 0;
            this.BT_StartupPlay.Text = "Play";
            this.BT_StartupPlay.UseVisualStyleBackColor = true;
            this.BT_StartupPlay.Click += new System.EventHandler(this.BT_StartupPlay_Click);
            // 
            // BT_StartupQuit
            // 
            this.BT_StartupQuit.Location = new System.Drawing.Point(236, 333);
            this.BT_StartupQuit.Name = "BT_StartupQuit";
            this.BT_StartupQuit.Size = new System.Drawing.Size(75, 23);
            this.BT_StartupQuit.TabIndex = 1;
            this.BT_StartupQuit.Text = "Quit";
            this.BT_StartupQuit.UseVisualStyleBackColor = true;
            this.BT_StartupQuit.Click += new System.EventHandler(this.BT_StartupQuit_Click);
            // 
            // BT_StartupHelp
            // 
            this.BT_StartupHelp.Location = new System.Drawing.Point(317, 333);
            this.BT_StartupHelp.Name = "BT_StartupHelp";
            this.BT_StartupHelp.Size = new System.Drawing.Size(75, 23);
            this.BT_StartupHelp.TabIndex = 2;
            this.BT_StartupHelp.Text = "Help";
            this.BT_StartupHelp.UseVisualStyleBackColor = true;
            this.BT_StartupHelp.Click += new System.EventHandler(this.BT_StartupHelp_Click);
            // 
            // LB_StartupPrivacy
            // 
            this.LB_StartupPrivacy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_StartupPrivacy.Location = new System.Drawing.Point(12, 215);
            this.LB_StartupPrivacy.Margin = new System.Windows.Forms.Padding(0);
            this.LB_StartupPrivacy.Name = "LB_StartupPrivacy";
            this.LB_StartupPrivacy.Size = new System.Drawing.Size(380, 84);
            this.LB_StartupPrivacy.TabIndex = 5;
            this.LB_StartupPrivacy.Text = resources.GetString("LB_StartupPrivacy.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::InternetGames.Properties.Resources.StartupHeader;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 200);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LB_InternetPrompt
            // 
            this.LB_InternetPrompt.Location = new System.Drawing.Point(12, 299);
            this.LB_InternetPrompt.Name = "LB_InternetPrompt";
            this.LB_InternetPrompt.Size = new System.Drawing.Size(381, 30);
            this.LB_InternetPrompt.TabIndex = 6;
            this.LB_InternetPrompt.Text = "If you are not already connected to the Internet, you will be prompted to do so i" +
    "n the next screen. Click \'Play\' to continue.";
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 368);
            this.Controls.Add(this.LB_InternetPrompt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_StartupPrivacy);
            this.Controls.Add(this.BT_StartupHelp);
            this.Controls.Add(this.BT_StartupQuit);
            this.Controls.Add(this.BT_StartupPlay);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartupScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartupScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BT_StartupPlay;
        private System.Windows.Forms.Button BT_StartupQuit;
        private System.Windows.Forms.Button BT_StartupHelp;
        private System.Windows.Forms.Label LB_StartupPrivacy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_InternetPrompt;
    }
}