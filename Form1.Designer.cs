namespace CalculatorActivity
{
    partial class Form1
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
            this.screenTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mAddButton = new System.Windows.Forms.Button();
            this.mMinusButton = new System.Windows.Forms.Button();
            this.mRecallButton = new System.Windows.Forms.Button();
            this.mClearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.memoryTab = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.viewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.memoryListBox = new System.Windows.Forms.ListBox();
            this.historyLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.memoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenTextBox
            // 
            this.screenTextBox.BackColor = System.Drawing.Color.White;
            this.screenTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.screenTextBox.Enabled = false;
            this.screenTextBox.Font = new System.Drawing.Font("Arial", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.screenTextBox.Location = new System.Drawing.Point(13, 87);
            this.screenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.screenTextBox.MaxLength = 16;
            this.screenTextBox.Name = "screenTextBox";
            this.screenTextBox.ReadOnly = true;
            this.screenTextBox.Size = new System.Drawing.Size(492, 67);
            this.screenTextBox.TabIndex = 0;
            this.screenTextBox.Text = "0";
            this.screenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 313);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(263, 313);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 238);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(138, 238);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 67);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(263, 238);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 67);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 163);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 67);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SkyBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(138, 163);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 67);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SkyBlue;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(263, 163);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 67);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.SkyBlue;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button0.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(13, 388);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(117, 67);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.BackColor = System.Drawing.Color.SkyBlue;
            this.plusMinusButton.FlatAppearance.BorderSize = 0;
            this.plusMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.plusMinusButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinusButton.Location = new System.Drawing.Point(263, 388);
            this.plusMinusButton.Margin = new System.Windows.Forms.Padding(4);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(117, 67);
            this.plusMinusButton.TabIndex = 11;
            this.plusMinusButton.Text = "+/-";
            this.plusMinusButton.UseVisualStyleBackColor = false;
            this.plusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.SkyBlue;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            this.decimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.decimalButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(138, 388);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(4);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(117, 67);
            this.decimalButton.TabIndex = 12;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.SkyBlue;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.equalButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(263, 463);
            this.equalButton.Margin = new System.Windows.Forms.Padding(4);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(117, 67);
            this.equalButton.TabIndex = 13;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // operationComboBox
            // 
            this.operationComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "÷"});
            this.operationComboBox.Location = new System.Drawing.Point(390, 497);
            this.operationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(115, 33);
            this.operationComboBox.TabIndex = 14;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.OperationComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.SkyBlue;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(13, 463);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 67);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.SkyBlue;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(138, 463);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 67);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Del";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // mAddButton
            // 
            this.mAddButton.BackColor = System.Drawing.Color.SkyBlue;
            this.mAddButton.FlatAppearance.BorderSize = 0;
            this.mAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mAddButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAddButton.Location = new System.Drawing.Point(388, 163);
            this.mAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.mAddButton.Name = "mAddButton";
            this.mAddButton.Size = new System.Drawing.Size(117, 67);
            this.mAddButton.TabIndex = 17;
            this.mAddButton.Text = "M+";
            this.mAddButton.UseVisualStyleBackColor = false;
            this.mAddButton.Click += new System.EventHandler(this.memoryOperation_Click);
            // 
            // mMinusButton
            // 
            this.mMinusButton.BackColor = System.Drawing.Color.SkyBlue;
            this.mMinusButton.FlatAppearance.BorderSize = 0;
            this.mMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mMinusButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMinusButton.Location = new System.Drawing.Point(388, 238);
            this.mMinusButton.Margin = new System.Windows.Forms.Padding(4);
            this.mMinusButton.Name = "mMinusButton";
            this.mMinusButton.Size = new System.Drawing.Size(117, 67);
            this.mMinusButton.TabIndex = 18;
            this.mMinusButton.Text = "M-";
            this.mMinusButton.UseVisualStyleBackColor = false;
            this.mMinusButton.Click += new System.EventHandler(this.memoryOperation_Click);
            // 
            // mRecallButton
            // 
            this.mRecallButton.BackColor = System.Drawing.Color.SkyBlue;
            this.mRecallButton.Enabled = false;
            this.mRecallButton.FlatAppearance.BorderSize = 0;
            this.mRecallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mRecallButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRecallButton.Location = new System.Drawing.Point(388, 388);
            this.mRecallButton.Margin = new System.Windows.Forms.Padding(4);
            this.mRecallButton.Name = "mRecallButton";
            this.mRecallButton.Size = new System.Drawing.Size(117, 67);
            this.mRecallButton.TabIndex = 19;
            this.mRecallButton.Text = "MR";
            this.mRecallButton.UseVisualStyleBackColor = false;
            this.mRecallButton.Click += new System.EventHandler(this.mRecallButton_Click);
            // 
            // mClearButton
            // 
            this.mClearButton.BackColor = System.Drawing.Color.SkyBlue;
            this.mClearButton.Enabled = false;
            this.mClearButton.FlatAppearance.BorderSize = 0;
            this.mClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mClearButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mClearButton.Location = new System.Drawing.Point(388, 313);
            this.mClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.mClearButton.Name = "mClearButton";
            this.mClearButton.Size = new System.Drawing.Size(117, 67);
            this.mClearButton.TabIndex = 20;
            this.mClearButton.Text = "MC";
            this.mClearButton.UseVisualStyleBackColor = false;
            this.mClearButton.Click += new System.EventHandler(this.mClearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(885, 25);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToTextToolStripMenuItem,
            this.importFromTextToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // exportToTextToolStripMenuItem
            // 
            this.exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
            this.exportToTextToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportToTextToolStripMenuItem.Text = "Export to Text";
            this.exportToTextToolStripMenuItem.Click += new System.EventHandler(this.ExportToTextToolStripMenuItem_Click);
            // 
            // importFromTextToolStripMenuItem
            // 
            this.importFromTextToolStripMenuItem.Name = "importFromTextToolStripMenuItem";
            this.importFromTextToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.importFromTextToolStripMenuItem.Text = "Import from Text";
            this.importFromTextToolStripMenuItem.Click += new System.EventHandler(this.ImportFromTextToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.historyTab);
            this.tabControl.Controls.Add(this.memoryTab);
            this.tabControl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(513, 29);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(363, 501);
            this.tabControl.TabIndex = 22;
            // 
            // historyTab
            // 
            this.historyTab.BackColor = System.Drawing.Color.White;
            this.historyTab.Controls.Add(this.historyLabel);
            this.historyTab.Controls.Add(this.clearHistoryButton);
            this.historyTab.Controls.Add(this.historyListBox);
            this.historyTab.Location = new System.Drawing.Point(4, 36);
            this.historyTab.Margin = new System.Windows.Forms.Padding(4);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(4);
            this.historyTab.Size = new System.Drawing.Size(355, 461);
            this.historyTab.TabIndex = 0;
            this.historyTab.Text = "History";
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearHistoryButton.Location = new System.Drawing.Point(265, 424);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(83, 30);
            this.clearHistoryButton.TabIndex = 2;
            this.clearHistoryButton.Text = "Clear";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Visible = false;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.HorizontalScrollbar = true;
            this.historyListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.historyListBox.ItemHeight = 18;
            this.historyListBox.Location = new System.Drawing.Point(-4, -1);
            this.historyListBox.Margin = new System.Windows.Forms.Padding(4);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(363, 400);
            this.historyListBox.TabIndex = 0;
            this.historyListBox.SelectedIndexChanged += new System.EventHandler(this.historyListBox_SelectedIndexChanged);
            // 
            // memoryTab
            // 
            this.memoryTab.BackColor = System.Drawing.Color.White;
            this.memoryTab.Controls.Add(this.memoryLabel);
            this.memoryTab.Controls.Add(this.memoryListBox);
            this.memoryTab.Location = new System.Drawing.Point(4, 36);
            this.memoryTab.Margin = new System.Windows.Forms.Padding(4);
            this.memoryTab.Name = "memoryTab";
            this.memoryTab.Padding = new System.Windows.Forms.Padding(4);
            this.memoryTab.Size = new System.Drawing.Size(355, 474);
            this.memoryTab.TabIndex = 1;
            this.memoryTab.Text = "Memory";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Browse Text Files";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Browse Text Files";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // viewRichTextBox
            // 
            this.viewRichTextBox.BackColor = System.Drawing.Color.White;
            this.viewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewRichTextBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRichTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.viewRichTextBox.Location = new System.Drawing.Point(13, 35);
            this.viewRichTextBox.Name = "viewRichTextBox";
            this.viewRichTextBox.ReadOnly = true;
            this.viewRichTextBox.Size = new System.Drawing.Size(492, 52);
            this.viewRichTextBox.TabIndex = 3;
            this.viewRichTextBox.Text = "";
            this.viewRichTextBox.SelectionChanged += new System.EventHandler(this.viewRichTextBox_SelectionChanged);
            // 
            // memoryListBox
            // 
            this.memoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.memoryListBox.FormattingEnabled = true;
            this.memoryListBox.HorizontalScrollbar = true;
            this.memoryListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.memoryListBox.ItemHeight = 18;
            this.memoryListBox.Location = new System.Drawing.Point(-4, -1);
            this.memoryListBox.Margin = new System.Windows.Forms.Padding(4);
            this.memoryListBox.Name = "memoryListBox";
            this.memoryListBox.Size = new System.Drawing.Size(363, 418);
            this.memoryListBox.TabIndex = 2;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(-2, 4);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(153, 18);
            this.historyLabel.TabIndex = 3;
            this.historyLabel.Text = "There\'s no history yet";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(-2, 4);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(235, 18);
            this.memoryLabel.TabIndex = 4;
            this.memoryLabel.Text = "There\'s nothing saved in memory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Operations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(885, 556);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.viewRichTextBox);
            this.Controls.Add(this.mAddButton);
            this.Controls.Add(this.screenTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mMinusButton);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.mClearButton);
            this.Controls.Add(this.mRecallButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.decimalButton);
            this.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.historyTab.ResumeLayout(false);
            this.historyTab.PerformLayout();
            this.memoryTab.ResumeLayout(false);
            this.memoryTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screenTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button mAddButton;
        private System.Windows.Forms.Button mMinusButton;
        private System.Windows.Forms.Button mRecallButton;
        private System.Windows.Forms.Button mClearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromTextToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.TabPage memoryTab;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.RichTextBox viewRichTextBox;
        private System.Windows.Forms.ListBox memoryListBox;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label label1;
    }
}

