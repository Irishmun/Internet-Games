
namespace InternetGames.PopUps
{
    partial class DebugInsertFEN
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
            this.BT_ConfirmFEN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NewFEN = new System.Windows.Forms.TextBox();
            this.BT_CancelFEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_ConfirmFEN
            // 
            this.BT_ConfirmFEN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_ConfirmFEN.Location = new System.Drawing.Point(12, 56);
            this.BT_ConfirmFEN.Name = "BT_ConfirmFEN";
            this.BT_ConfirmFEN.Size = new System.Drawing.Size(111, 23);
            this.BT_ConfirmFEN.TabIndex = 0;
            this.BT_ConfirmFEN.Text = "Confirm";
            this.BT_ConfirmFEN.UseVisualStyleBackColor = true;
            this.BT_ConfirmFEN.Click += new System.EventHandler(this.BT_ConfirmFEN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert FEN string";
            // 
            // TB_NewFEN
            // 
            this.TB_NewFEN.Location = new System.Drawing.Point(12, 27);
            this.TB_NewFEN.Name = "TB_NewFEN";
            this.TB_NewFEN.Size = new System.Drawing.Size(228, 23);
            this.TB_NewFEN.TabIndex = 2;
            // 
            // BT_CancelFEN
            // 
            this.BT_CancelFEN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_CancelFEN.Location = new System.Drawing.Point(129, 56);
            this.BT_CancelFEN.Name = "BT_CancelFEN";
            this.BT_CancelFEN.Size = new System.Drawing.Size(111, 23);
            this.BT_CancelFEN.TabIndex = 3;
            this.BT_CancelFEN.Text = "Cancel";
            this.BT_CancelFEN.UseVisualStyleBackColor = true;
            this.BT_CancelFEN.Click += new System.EventHandler(this.BT_CancelFEN_Click);
            // 
            // DebugInsertFEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 93);
            this.Controls.Add(this.BT_CancelFEN);
            this.Controls.Add(this.TB_NewFEN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_ConfirmFEN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DebugInsertFEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DebugInsertFEN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_ConfirmFEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_CancelFEN;
        internal System.Windows.Forms.TextBox TB_NewFEN;
    }
}