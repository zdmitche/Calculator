namespace Calculator
{
    partial class ZaculatorProgrammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaculatorProgrammer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.ModuloButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.HexRadio = new System.Windows.Forms.RadioButton();
            this.DecRadio = new System.Windows.Forms.RadioButton();
            this.OctRadio = new System.Windows.Forms.RadioButton();
            this.BinRadio = new System.Windows.Forms.RadioButton();
            this.container = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonReciprocal = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editToolStripMenuItem.Text = "Standard";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Checked = true;
            this.programmerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AButton
            // 
            this.AButton.Enabled = false;
            this.AButton.Location = new System.Drawing.Point(96, 85);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(39, 30);
            this.AButton.TabIndex = 115;
            this.AButton.TabStop = false;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // EButton
            // 
            this.EButton.Enabled = false;
            this.EButton.Location = new System.Drawing.Point(96, 224);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(39, 30);
            this.EButton.TabIndex = 113;
            this.EButton.TabStop = false;
            this.EButton.Text = "E";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // DButton
            // 
            this.DButton.Enabled = false;
            this.DButton.Location = new System.Drawing.Point(96, 189);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(39, 30);
            this.DButton.TabIndex = 112;
            this.DButton.TabStop = false;
            this.DButton.Text = "D";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // BButton
            // 
            this.BButton.Enabled = false;
            this.BButton.Location = new System.Drawing.Point(96, 119);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(39, 30);
            this.BButton.TabIndex = 107;
            this.BButton.TabStop = false;
            this.BButton.Text = "B";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // ModuloButton
            // 
            this.ModuloButton.Location = new System.Drawing.Point(52, 211);
            this.ModuloButton.Name = "ModuloButton";
            this.ModuloButton.Size = new System.Drawing.Size(39, 36);
            this.ModuloButton.TabIndex = 104;
            this.ModuloButton.TabStop = false;
            this.ModuloButton.Text = "Mod";
            this.ModuloButton.UseVisualStyleBackColor = true;
            this.ModuloButton.Click += new System.EventHandler(this.ModuloButton_Click);
            // 
            // CButton
            // 
            this.CButton.Enabled = false;
            this.CButton.Location = new System.Drawing.Point(96, 154);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(39, 30);
            this.CButton.TabIndex = 98;
            this.CButton.TabStop = false;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // display
            // 
            this.display.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(8, 39);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(343, 31);
            this.display.TabIndex = 74;
            this.display.TabStop = false;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.UseWaitCursor = true;
            // 
            // HexRadio
            // 
            this.HexRadio.AutoSize = true;
            this.HexRadio.Location = new System.Drawing.Point(9, 9);
            this.HexRadio.Name = "HexRadio";
            this.HexRadio.Size = new System.Drawing.Size(44, 17);
            this.HexRadio.TabIndex = 0;
            this.HexRadio.Text = "Hex";
            this.HexRadio.UseVisualStyleBackColor = true;
            this.HexRadio.CheckedChanged += new System.EventHandler(this.HexRadio_CheckedChanged);
            // 
            // DecRadio
            // 
            this.DecRadio.AutoSize = true;
            this.DecRadio.Checked = true;
            this.DecRadio.Location = new System.Drawing.Point(9, 32);
            this.DecRadio.Name = "DecRadio";
            this.DecRadio.Size = new System.Drawing.Size(45, 17);
            this.DecRadio.TabIndex = 1;
            this.DecRadio.TabStop = true;
            this.DecRadio.Text = "Dec";
            this.DecRadio.UseVisualStyleBackColor = true;
            this.DecRadio.CheckedChanged += new System.EventHandler(this.DecRadio_CheckedChanged);
            // 
            // OctRadio
            // 
            this.OctRadio.AutoSize = true;
            this.OctRadio.Location = new System.Drawing.Point(9, 57);
            this.OctRadio.Name = "OctRadio";
            this.OctRadio.Size = new System.Drawing.Size(42, 17);
            this.OctRadio.TabIndex = 2;
            this.OctRadio.Text = "Oct";
            this.OctRadio.UseVisualStyleBackColor = true;
            this.OctRadio.CheckedChanged += new System.EventHandler(this.OctRadio_CheckedChanged);
            // 
            // BinRadio
            // 
            this.BinRadio.AutoSize = true;
            this.BinRadio.Location = new System.Drawing.Point(9, 81);
            this.BinRadio.Name = "BinRadio";
            this.BinRadio.Size = new System.Drawing.Size(40, 17);
            this.BinRadio.TabIndex = 3;
            this.BinRadio.Text = "Bin";
            this.BinRadio.UseVisualStyleBackColor = true;
            this.BinRadio.CheckedChanged += new System.EventHandler(this.BinRadio_CheckedChanged);
            // 
            // container
            // 
            this.container.Controls.Add(this.BinRadio);
            this.container.Controls.Add(this.OctRadio);
            this.container.Controls.Add(this.DecRadio);
            this.container.Controls.Add(this.HexRadio);
            this.container.Location = new System.Drawing.Point(8, 85);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(83, 120);
            this.container.TabIndex = 122;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FButton
            // 
            this.FButton.Enabled = false;
            this.FButton.Location = new System.Drawing.Point(96, 259);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(39, 30);
            this.FButton.TabIndex = 125;
            this.FButton.Text = "F";
            this.FButton.UseVisualStyleBackColor = true;
            this.FButton.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(8, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 36);
            this.button1.TabIndex = 126;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(52, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 36);
            this.button2.TabIndex = 127;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(8, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 36);
            this.button3.TabIndex = 128;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Enabled = false;
            this.buttonSquareRoot.Location = new System.Drawing.Point(315, 85);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(37, 35);
            this.buttonSquareRoot.TabIndex = 151;
            this.buttonSquareRoot.TabStop = false;
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            // 
            // buttonNegate
            // 
            this.buttonNegate.Location = new System.Drawing.Point(272, 85);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(37, 35);
            this.buttonNegate.TabIndex = 150;
            this.buttonNegate.TabStop = false;
            this.buttonNegate.Text = "±";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.buttonNegate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(229, 85);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 36);
            this.buttonClear.TabIndex = 149;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Location = new System.Drawing.Point(186, 85);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(37, 36);
            this.buttonClearEntry.TabIndex = 148;
            this.buttonClearEntry.TabStop = false;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(141, 85);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(39, 36);
            this.buttonBackspace.TabIndex = 147;
            this.buttonBackspace.TabStop = false;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(316, 212);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(36, 77);
            this.buttonEquals.TabIndex = 146;
            this.buttonEquals.TabStop = false;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(272, 254);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(37, 35);
            this.buttonPlus.TabIndex = 145;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operatorClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(272, 211);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(37, 35);
            this.buttonMinus.TabIndex = 144;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "−";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operatorClick);
            // 
            // buttonReciprocal
            // 
            this.buttonReciprocal.Enabled = false;
            this.buttonReciprocal.Location = new System.Drawing.Point(315, 170);
            this.buttonReciprocal.Name = "buttonReciprocal";
            this.buttonReciprocal.Size = new System.Drawing.Size(37, 35);
            this.buttonReciprocal.TabIndex = 143;
            this.buttonReciprocal.TabStop = false;
            this.buttonReciprocal.Text = "1/x";
            this.buttonReciprocal.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(272, 170);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(37, 35);
            this.buttonMultiplication.TabIndex = 142;
            this.buttonMultiplication.TabStop = false;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.operatorClick);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Enabled = false;
            this.buttonPercent.Location = new System.Drawing.Point(315, 128);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(37, 35);
            this.buttonPercent.TabIndex = 141;
            this.buttonPercent.TabStop = false;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(272, 128);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(37, 35);
            this.buttonDivision.TabIndex = 140;
            this.buttonDivision.TabStop = false;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.operatorClick);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Enabled = false;
            this.buttonDecimal.Location = new System.Drawing.Point(229, 254);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(37, 35);
            this.buttonDecimal.TabIndex = 139;
            this.buttonDecimal.TabStop = false;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            // 
            // buttonNum0
            // 
            this.buttonNum0.Location = new System.Drawing.Point(141, 254);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(81, 35);
            this.buttonNum0.TabIndex = 138;
            this.buttonNum0.TabStop = false;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Location = new System.Drawing.Point(228, 211);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(38, 36);
            this.buttonNum3.TabIndex = 137;
            this.buttonNum3.TabStop = false;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.Location = new System.Drawing.Point(185, 211);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(37, 36);
            this.buttonNum2.TabIndex = 136;
            this.buttonNum2.TabStop = false;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.Location = new System.Drawing.Point(140, 211);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(39, 36);
            this.buttonNum1.TabIndex = 135;
            this.buttonNum1.TabStop = false;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Location = new System.Drawing.Point(228, 169);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(38, 36);
            this.buttonNum6.TabIndex = 134;
            this.buttonNum6.TabStop = false;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Location = new System.Drawing.Point(185, 169);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(37, 36);
            this.buttonNum5.TabIndex = 133;
            this.buttonNum5.TabStop = false;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Location = new System.Drawing.Point(140, 169);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(39, 36);
            this.buttonNum4.TabIndex = 132;
            this.buttonNum4.TabStop = false;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Location = new System.Drawing.Point(228, 127);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(38, 36);
            this.buttonNum9.TabIndex = 131;
            this.buttonNum9.TabStop = false;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Location = new System.Drawing.Point(185, 127);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(37, 36);
            this.buttonNum8.TabIndex = 130;
            this.buttonNum8.TabStop = false;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Location = new System.Drawing.Point(140, 127);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(39, 36);
            this.buttonNum7.TabIndex = 129;
            this.buttonNum7.TabStop = false;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // ZaculatorProgrammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 298);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonReciprocal);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FButton);
            this.Controls.Add(this.container);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.ModuloButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZaculatorProgrammer";
            this.Text = "Zaculator Programmer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZaculatorProgrammer_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zaculator_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button ModuloButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.RadioButton HexRadio;
        private System.Windows.Forms.RadioButton DecRadio;
        private System.Windows.Forms.RadioButton OctRadio;
        private System.Windows.Forms.RadioButton BinRadio;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonReciprocal;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
    }
}