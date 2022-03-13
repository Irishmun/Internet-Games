
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Resign = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Draw = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Reconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Debug = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIDebug_SetFEN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIDebug_SkipTurn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.forceWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_OpponentColor = new System.Windows.Forms.Label();
            this.LB_YourColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CheckersField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_CheckersField
            // 
            this.PB_CheckersField.Image = global::InternetGames.Properties.Resources.Checkers_Field;
            this.PB_CheckersField.InitialImage = global::InternetGames.Properties.Resources.Checkers_Field;
            this.PB_CheckersField.Location = new System.Drawing.Point(0, 25);
            this.PB_CheckersField.Name = "PB_CheckersField";
            this.PB_CheckersField.Size = new System.Drawing.Size(540, 360);
            this.PB_CheckersField.TabIndex = 0;
            this.PB_CheckersField.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::InternetGames.Properties.Resources.Checkers_Pieces;
            this.pictureBox2.Location = new System.Drawing.Point(269, 104);
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
            this.CB_ChatMessage.Location = new System.Drawing.Point(0, 465);
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
            this.panel1.Location = new System.Drawing.Point(381, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 84);
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
            this.panel2.Location = new System.Drawing.Point(435, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 103);
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
            this.panel3.Location = new System.Drawing.Point(381, 385);
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
            this.LV_ChatMessages.Location = new System.Drawing.Point(0, 385);
            this.LV_ChatMessages.Name = "LV_ChatMessages";
            this.LV_ChatMessages.Size = new System.Drawing.Size(381, 81);
            this.LV_ChatMessages.TabIndex = 5;
            this.LV_ChatMessages.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Game,
            this.TSMI_Help,
            this.TSMI_Debug});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Game
            // 
            this.TSMI_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Resign,
            this.TSMI_Draw,
            this.TSMI_Reconnect,
            this.toolStripSeparator1,
            this.TSMI_Quit});
            this.TSMI_Game.Name = "TSMI_Game";
            this.TSMI_Game.Size = new System.Drawing.Size(50, 20);
            this.TSMI_Game.Text = "Game";
            // 
            // TSMI_Resign
            // 
            this.TSMI_Resign.Name = "TSMI_Resign";
            this.TSMI_Resign.Size = new System.Drawing.Size(130, 22);
            this.TSMI_Resign.Text = "Resign";
            // 
            // TSMI_Draw
            // 
            this.TSMI_Draw.Name = "TSMI_Draw";
            this.TSMI_Draw.Size = new System.Drawing.Size(130, 22);
            this.TSMI_Draw.Text = "Draw";
            // 
            // TSMI_Reconnect
            // 
            this.TSMI_Reconnect.Name = "TSMI_Reconnect";
            this.TSMI_Reconnect.Size = new System.Drawing.Size(130, 22);
            this.TSMI_Reconnect.Text = "Reconnect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // TSMI_Quit
            // 
            this.TSMI_Quit.Name = "TSMI_Quit";
            this.TSMI_Quit.Size = new System.Drawing.Size(130, 22);
            this.TSMI_Quit.Text = "Exit";
            this.TSMI_Quit.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ViewHelp,
            this.toolStripSeparator2,
            this.TSMI_About});
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(44, 20);
            this.TSMI_Help.Text = "Help";
            // 
            // TSMI_ViewHelp
            // 
            this.TSMI_ViewHelp.Name = "TSMI_ViewHelp";
            this.TSMI_ViewHelp.Size = new System.Drawing.Size(158, 22);
            this.TSMI_ViewHelp.Text = "View Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(158, 22);
            this.TSMI_About.Text = "About Checkers";
            // 
            // TSMI_Debug
            // 
            this.TSMI_Debug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIDebug_SetFEN,
            this.TSMIDebug_SkipTurn,
            this.toolStripSeparator3,
            this.forceWinToolStripMenuItem,
            this.forceLoseToolStripMenuItem});
            this.TSMI_Debug.Name = "TSMI_Debug";
            this.TSMI_Debug.Size = new System.Drawing.Size(54, 20);
            this.TSMI_Debug.Text = "Debug";
            // 
            // TSMIDebug_SetFEN
            // 
            this.TSMIDebug_SetFEN.Name = "TSMIDebug_SetFEN";
            this.TSMIDebug_SetFEN.Size = new System.Drawing.Size(180, 22);
            this.TSMIDebug_SetFEN.Text = "Set FEN";
            this.TSMIDebug_SetFEN.Click += new System.EventHandler(this.TSMIDebug_SetFEN_Click);
            // 
            // TSMIDebug_SkipTurn
            // 
            this.TSMIDebug_SkipTurn.Name = "TSMIDebug_SkipTurn";
            this.TSMIDebug_SkipTurn.Size = new System.Drawing.Size(180, 22);
            this.TSMIDebug_SkipTurn.Text = "Skip Turn";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // forceWinToolStripMenuItem
            // 
            this.forceWinToolStripMenuItem.Name = "forceWinToolStripMenuItem";
            this.forceWinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forceWinToolStripMenuItem.Text = "Force Win";
            // 
            // forceLoseToolStripMenuItem
            // 
            this.forceLoseToolStripMenuItem.Name = "forceLoseToolStripMenuItem";
            this.forceLoseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forceLoseToolStripMenuItem.Text = "Force Lose";
            // 
            // LB_OpponentColor
            // 
            this.LB_OpponentColor.BackColor = System.Drawing.Color.Transparent;
            this.LB_OpponentColor.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_OpponentColor.Location = new System.Drawing.Point(8, 29);
            this.LB_OpponentColor.Name = "LB_OpponentColor";
            this.LB_OpponentColor.Size = new System.Drawing.Size(98, 45);
            this.LB_OpponentColor.TabIndex = 7;
            this.LB_OpponentColor.Text = "Opponent";
            this.LB_OpponentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_YourColor
            // 
            this.LB_YourColor.BackColor = System.Drawing.Color.Transparent;
            this.LB_YourColor.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_YourColor.Location = new System.Drawing.Point(431, 289);
            this.LB_YourColor.Name = "LB_YourColor";
            this.LB_YourColor.Size = new System.Drawing.Size(100, 43);
            this.LB_YourColor.TabIndex = 8;
            this.LB_YourColor.Text = "Your";
            this.LB_YourColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 488);
            this.Controls.Add(this.LB_YourColor);
            this.Controls.Add(this.LB_OpponentColor);
            this.Controls.Add(this.LV_ChatMessages);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CB_ChatMessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PB_CheckersField);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 531);
            this.MinimumSize = new System.Drawing.Size(560, 43);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Game;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Debug;
        private System.Windows.Forms.ToolStripMenuItem TSMIDebug_SetFEN;
        private System.Windows.Forms.ToolStripMenuItem TSMIDebug_SkipTurn;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Resign;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Draw;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Reconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Quit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ViewHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem forceWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceLoseToolStripMenuItem;
        private System.Windows.Forms.Label LB_OpponentColor;
        private System.Windows.Forms.Label LB_YourColor;
    }
}

