namespace QuickRand
{
    partial class Main
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
            this.OpNumberRadio = new System.Windows.Forms.RadioButton();
            this.OperationGB = new System.Windows.Forms.GroupBox();
            this.OpListRadio = new System.Windows.Forms.RadioButton();
            this.ListInputGB = new System.Windows.Forms.GroupBox();
            this.ManualButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ListInput = new System.Windows.Forms.ListBox();
            this.OutputGB = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.RandomButton = new System.Windows.Forms.Button();
            this.NumInputGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RangeToSpinner = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RangeFromSpinner = new System.Windows.Forms.NumericUpDown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OperationGB.SuspendLayout();
            this.ListInputGB.SuspendLayout();
            this.OutputGB.SuspendLayout();
            this.NumInputGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeToSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeFromSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // OpNumberRadio
            // 
            this.OpNumberRadio.AutoSize = true;
            this.OpNumberRadio.Location = new System.Drawing.Point(6, 19);
            this.OpNumberRadio.Name = "OpNumberRadio";
            this.OpNumberRadio.Size = new System.Drawing.Size(62, 17);
            this.OpNumberRadio.TabIndex = 0;
            this.OpNumberRadio.TabStop = true;
            this.OpNumberRadio.Text = "Number";
            this.OpNumberRadio.UseVisualStyleBackColor = true;
            this.OpNumberRadio.CheckedChanged += new System.EventHandler(this.OpNumberRadio_CheckedChanged);
            // 
            // OperationGB
            // 
            this.OperationGB.Controls.Add(this.OpListRadio);
            this.OperationGB.Controls.Add(this.OpNumberRadio);
            this.OperationGB.Location = new System.Drawing.Point(12, 12);
            this.OperationGB.Name = "OperationGB";
            this.OperationGB.Size = new System.Drawing.Size(260, 45);
            this.OperationGB.TabIndex = 1;
            this.OperationGB.TabStop = false;
            this.OperationGB.Text = "Operation Mode";
            // 
            // OpListRadio
            // 
            this.OpListRadio.AutoSize = true;
            this.OpListRadio.Location = new System.Drawing.Point(74, 19);
            this.OpListRadio.Name = "OpListRadio";
            this.OpListRadio.Size = new System.Drawing.Size(41, 17);
            this.OpListRadio.TabIndex = 1;
            this.OpListRadio.TabStop = true;
            this.OpListRadio.Text = "List";
            this.OpListRadio.UseVisualStyleBackColor = true;
            this.OpListRadio.CheckedChanged += new System.EventHandler(this.OpListRadio_CheckedChanged);
            // 
            // ListInputGB
            // 
            this.ListInputGB.Controls.Add(this.DeleteButton);
            this.ListInputGB.Controls.Add(this.ManualButton);
            this.ListInputGB.Controls.Add(this.AcceptButton);
            this.ListInputGB.Controls.Add(this.InputBox);
            this.ListInputGB.Controls.Add(this.ListInput);
            this.ListInputGB.Location = new System.Drawing.Point(12, 63);
            this.ListInputGB.Name = "ListInputGB";
            this.ListInputGB.Size = new System.Drawing.Size(260, 204);
            this.ListInputGB.TabIndex = 2;
            this.ListInputGB.TabStop = false;
            this.ListInputGB.Text = "Input";
            // 
            // ManualButton
            // 
            this.ManualButton.Location = new System.Drawing.Point(6, 174);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(167, 23);
            this.ManualButton.TabIndex = 3;
            this.ManualButton.Text = "Enter List...";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(179, 145);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(6, 147);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(167, 20);
            this.InputBox.TabIndex = 1;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // ListInput
            // 
            this.ListInput.FormattingEnabled = true;
            this.ListInput.HorizontalScrollbar = true;
            this.ListInput.Items.AddRange(new object[] {
            "It\'s a thing!"});
            this.ListInput.Location = new System.Drawing.Point(6, 19);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(248, 121);
            this.ListInput.TabIndex = 0;
            // 
            // OutputGB
            // 
            this.OutputGB.Controls.Add(this.OutputBox);
            this.OutputGB.Location = new System.Drawing.Point(12, 309);
            this.OutputGB.Name = "OutputGB";
            this.OutputGB.Size = new System.Drawing.Size(260, 54);
            this.OutputGB.TabIndex = 3;
            this.OutputGB.TabStop = false;
            this.OutputGB.Text = "Output";
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(7, 20);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(247, 26);
            this.OutputBox.TabIndex = 0;
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(13, 274);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(259, 29);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Randomise";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // NumInputGB
            // 
            this.NumInputGB.Controls.Add(this.label2);
            this.NumInputGB.Controls.Add(this.RangeToSpinner);
            this.NumInputGB.Controls.Add(this.label1);
            this.NumInputGB.Controls.Add(this.RangeFromSpinner);
            this.NumInputGB.Location = new System.Drawing.Point(12, 63);
            this.NumInputGB.Name = "NumInputGB";
            this.NumInputGB.Size = new System.Drawing.Size(260, 204);
            this.NumInputGB.TabIndex = 4;
            this.NumInputGB.TabStop = false;
            this.NumInputGB.Text = "Input";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RangeToSpinner
            // 
            this.RangeToSpinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeToSpinner.Location = new System.Drawing.Point(6, 100);
            this.RangeToSpinner.Name = "RangeToSpinner";
            this.RangeToSpinner.Size = new System.Drawing.Size(248, 26);
            this.RangeToSpinner.TabIndex = 2;
            this.RangeToSpinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RangeToSpinner.ValueChanged += new System.EventHandler(this.RangeToSpinner_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RangeFromSpinner
            // 
            this.RangeFromSpinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeFromSpinner.Location = new System.Drawing.Point(6, 44);
            this.RangeFromSpinner.Name = "RangeFromSpinner";
            this.RangeFromSpinner.Size = new System.Drawing.Size(248, 26);
            this.RangeFromSpinner.TabIndex = 0;
            this.RangeFromSpinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RangeFromSpinner.ValueChanged += new System.EventHandler(this.RangeFromSpinner_ValueChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(179, 174);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.OutputGB);
            this.Controls.Add(this.OperationGB);
            this.Controls.Add(this.ListInputGB);
            this.Controls.Add(this.NumInputGB);
            this.Name = "Main";
            this.Text = "QuickRand";
            this.OperationGB.ResumeLayout(false);
            this.OperationGB.PerformLayout();
            this.ListInputGB.ResumeLayout(false);
            this.ListInputGB.PerformLayout();
            this.OutputGB.ResumeLayout(false);
            this.OutputGB.PerformLayout();
            this.NumInputGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RangeToSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeFromSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton OpNumberRadio;
        private System.Windows.Forms.GroupBox OperationGB;
        private System.Windows.Forms.RadioButton OpListRadio;
        private System.Windows.Forms.GroupBox ListInputGB;
        private System.Windows.Forms.Button ManualButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.ListBox ListInput;
        private System.Windows.Forms.GroupBox OutputGB;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.GroupBox NumInputGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RangeToSpinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RangeFromSpinner;
        private System.Windows.Forms.Button DeleteButton;
    }
}

