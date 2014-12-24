namespace QuickRand
{
    partial class ListEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ListBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.Location = new System.Drawing.Point(13, 29);
            this.ListBox.Multiline = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(359, 298);
            this.ListBox.TabIndex = 0;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(298, 333);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Entry: Enter each list item on a different line.";
            // 
            // ListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "List Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ListBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label1;
    }
}