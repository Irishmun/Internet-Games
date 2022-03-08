
namespace InternetGames
{
    partial class CheckersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckersWindow));
            this.PB_CheckersField = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CB_ChatMessage = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RB_ChatDisable = new System.Windows.Forms.RadioButton();
            this.RB_ChatEnable = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_WhiteChatState = new System.Windows.Forms.Label();
            this.LB_RedChatState = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_ChatMessages = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CheckersField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_CheckersField
            // 
            this.PB_CheckersField.Image = global::InternetGames.Properties.Resources.Checkers_Field;
            this.PB_CheckersField.InitialImage = global::InternetGames.Properties.Resources.Checkers_Field;
            this.PB_CheckersField.Location = new System.Drawing.Point(0, 0);
            this.PB_CheckersField.Name = "PB_CheckersField";
            this.PB_CheckersField.Size = new System.Drawing.Size(540, 360);
            this.PB_CheckersField.TabIndex = 0;
            this.PB_CheckersField.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::InternetGames.Properties.Resources.Checkers_Pieces;
            this.pictureBox2.Location = new System.Drawing.Point(269, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CB_ChatMessage
            // 
            this.CB_ChatMessage.FormattingEnabled = true;
            this.CB_ChatMessage.ItemHeight = 15;
            this.CB_ChatMessage.Items.AddRange(new object[] {
            "(Select a message to send)",
            "Nice try",
            "Good job",
            "Good game",
            "Good luck!",
            "It\'s your turn",
            "I\'m thinking...",
            "Play again?",
            "Yes",
            "No",
            "Hello",
            "Goodbye",
            "Thank you",
            "You\'re welcome",
            "It was luck",
            "Be right back...",
            "Okay, I\'m back",
            "Are you still there?",
            "Sorry, I have to go now",
            "I\'m going to play something else",
            ":-)",
            ":-(",
            "Uh oh...",
            "Oops!",
            "Ouch!",
            "Nice move",
            "Good jump",
            "Good double-jump",
            "King me!"});
            this.CB_ChatMessage.Location = new System.Drawing.Point(0, 440);
            this.CB_ChatMessage.MaxDropDownItems = 29;
            this.CB_ChatMessage.Name = "CB_ChatMessage";
            this.CB_ChatMessage.Size = new System.Drawing.Size(381, 23);
            this.CB_ChatMessage.TabIndex = 0;
            this.CB_ChatMessage.Text = "(Select a message to send)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RB_ChatDisable);
            this.panel1.Controls.Add(this.RB_ChatEnable);
            this.panel1.Location = new System.Drawing.Point(381, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 82);
            this.panel1.TabIndex = 3;
            // 
            // RB_ChatDisable
            // 
            this.RB_ChatDisable.AutoSize = true;
            this.RB_ChatDisable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RB_ChatDisable.Location = new System.Drawing.Point(5, 29);
            this.RB_ChatDisable.Name = "RB_ChatDisable";
            this.RB_ChatDisable.Size = new System.Drawing.Size(44, 19);
            this.RB_ChatDisable.TabIndex = 2;
            this.RB_ChatDisable.Text = "Off";
            this.RB_ChatDisable.UseVisualStyleBackColor = true;
            // 
            // RB_ChatEnable
            // 
            this.RB_ChatEnable.AutoSize = true;
            this.RB_ChatEnable.Checked = true;
            this.RB_ChatEnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RB_ChatEnable.Location = new System.Drawing.Point(5, 4);
            this.RB_ChatEnable.Name = "RB_ChatEnable";
            this.RB_ChatEnable.Size = new System.Drawing.Size(41, 19);
            this.RB_ChatEnable.TabIndex = 1;
            this.RB_ChatEnable.TabStop = true;
            this.RB_ChatEnable.Text = "On";
            this.RB_ChatEnable.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LB_WhiteChatState);
            this.panel2.Controls.Add(this.LB_RedChatState);
            this.panel2.Location = new System.Drawing.Point(435, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 100);
            this.panel2.TabIndex = 4;
            // 
            // LB_WhiteChatState
            // 
            this.LB_WhiteChatState.AutoSize = true;
            this.LB_WhiteChatState.Location = new System.Drawing.Point(4, 17);
            this.LB_WhiteChatState.Name = "LB_WhiteChatState";
            this.LB_WhiteChatState.Size = new System.Drawing.Size(66, 15);
            this.LB_WhiteChatState.TabIndex = 1;
            this.LB_WhiteChatState.Text = "White (Off)";
            // 
            // LB_RedChatState
            // 
            this.LB_RedChatState.AutoSize = true;
            this.LB_RedChatState.Location = new System.Drawing.Point(5, 2);
            this.LB_RedChatState.Name = "LB_RedChatState";
            this.LB_RedChatState.Size = new System.Drawing.Size(55, 15);
            this.LB_RedChatState.TabIndex = 0;
            this.LB_RedChatState.Text = "Red (Off)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(381, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 18);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat";
            // 
            // LV_ChatMessages
            // 
            this.LV_ChatMessages.HideSelection = false;
            this.LV_ChatMessages.Location = new System.Drawing.Point(0, 360);
            this.LV_ChatMessages.Name = "LV_ChatMessages";
            this.LV_ChatMessages.Size = new System.Drawing.Size(381, 81);
            this.LV_ChatMessages.TabIndex = 5;
            this.LV_ChatMessages.UseCompatibleStateImageBehavior = false;
            // 
            // CheckersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 463);
            this.Controls.Add(this.LV_ChatMessages);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CB_ChatMessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PB_CheckersField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 574);
            this.MinimumSize = new System.Drawing.Size(556, 43);
            this.Name = "CheckersWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.PB_CheckersField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_CheckersField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CB_ChatMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RB_ChatDisable;
        private System.Windows.Forms.RadioButton RB_ChatEnable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LB_WhiteChatState;
        private System.Windows.Forms.Label LB_RedChatState;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LV_ChatMessages;
    }
}

