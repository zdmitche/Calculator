namespace Calculator
{
    partial class UnitConversion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.unitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromValueTextBox = new System.Windows.Forms.TextBox();
            this.fromUnitComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toUnitComboBox = new System.Windows.Forms.ComboBox();
            this.toValueTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the type of unit you want to convert";
            // 
            // unitTypeComboBox
            // 
            this.unitTypeComboBox.FormattingEnabled = true;
            this.unitTypeComboBox.Items.AddRange(new object[] {
            "Angle",
            "Area",
            "Energy",
            "Length",
            "Power",
            "Pressure",
            "Temperature",
            "Time",
            "Velocity",
            "Volume",
            "Weight/Mass"});
            this.unitTypeComboBox.Location = new System.Drawing.Point(17, 33);
            this.unitTypeComboBox.Name = "unitTypeComboBox";
            this.unitTypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.unitTypeComboBox.TabIndex = 1;
            this.unitTypeComboBox.Text = "Select Unit Type";
            this.unitTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.unitTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // fromValueTextBox
            // 
            this.fromValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromValueTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fromValueTextBox.Location = new System.Drawing.Point(17, 79);
            this.fromValueTextBox.Name = "fromValueTextBox";
            this.fromValueTextBox.Size = new System.Drawing.Size(204, 20);
            this.fromValueTextBox.TabIndex = 3;
            this.fromValueTextBox.Text = "Enter Value";
            this.fromValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromValueTextBox_KeyPress);
            this.fromValueTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fromValueTextBox_MouseDown);
            // 
            // fromUnitComboBox
            // 
            this.fromUnitComboBox.FormattingEnabled = true;
            this.fromUnitComboBox.Location = new System.Drawing.Point(17, 105);
            this.fromUnitComboBox.Name = "fromUnitComboBox";
            this.fromUnitComboBox.Size = new System.Drawing.Size(204, 21);
            this.fromUnitComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // toUnitComboBox
            // 
            this.toUnitComboBox.FormattingEnabled = true;
            this.toUnitComboBox.Location = new System.Drawing.Point(17, 197);
            this.toUnitComboBox.Name = "toUnitComboBox";
            this.toUnitComboBox.Size = new System.Drawing.Size(204, 21);
            this.toUnitComboBox.TabIndex = 7;
            // 
            // toValueTextBox
            // 
            this.toValueTextBox.Enabled = false;
            this.toValueTextBox.Location = new System.Drawing.Point(17, 171);
            this.toValueTextBox.Name = "toValueTextBox";
            this.toValueTextBox.ReadOnly = true;
            this.toValueTextBox.Size = new System.Drawing.Size(204, 20);
            this.toValueTextBox.TabIndex = 6;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(91, 134);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(59, 21);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // UnitConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toUnitComboBox);
            this.Controls.Add(this.toValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromUnitComboBox);
            this.Controls.Add(this.fromValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "UnitConversion";
            this.Size = new System.Drawing.Size(242, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unitTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromValueTextBox;
        private System.Windows.Forms.ComboBox fromUnitComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox toUnitComboBox;
        private System.Windows.Forms.TextBox toValueTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}
