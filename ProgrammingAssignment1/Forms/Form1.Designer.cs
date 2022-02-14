namespace ProgrammingAssignment1;

partial class Form1
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
            this.insertButton = new System.Windows.Forms.Button();
            this.beansDataGridView = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eanBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButtonBeans = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.beanComboBox = new System.Windows.Forms.ComboBox();
            this.waterComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.beanLabel = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.coffeeTab_beanWeightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.grindSizeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.coffeeDataGridView = new System.Windows.Forms.DataGridView();
            this.coffeeTab_grindSizeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beansDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Location = new System.Drawing.Point(436, 463);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(80, 23);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Add";
            this.insertButton.UseCompatibleTextRendering = true;
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.OnInsertButton);
            // 
            // beansDataGridView
            // 
            this.beansDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beansDataGridView.Location = new System.Drawing.Point(3, 51);
            this.beansDataGridView.Name = "beansDataGridView";
            this.beansDataGridView.RowTemplate.Height = 25;
            this.beansDataGridView.Size = new System.Drawing.Size(946, 296);
            this.beansDataGridView.TabIndex = 1;
            this.beansDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.OnCellEdit);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(126, 377);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(240, 23);
            this.nameBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 517);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.searchTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.eanBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.deleteButtonBeans);
            this.tabPage1.Controls.Add(this.beansDataGridView);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.insertButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(952, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(531, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(126, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(240, 23);
            this.searchTextBox.TabIndex = 11;
            this.searchTextBox.TextChanged += new System.EventHandler(this.OnBeansSearchInput);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Title";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(538, 416);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 23);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // eanBox
            // 
            this.eanBox.Location = new System.Drawing.Point(126, 416);
            this.eanBox.Name = "eanBox";
            this.eanBox.Size = new System.Drawing.Size(240, 23);
            this.eanBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // deleteButtonBeans
            // 
            this.deleteButtonBeans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButtonBeans.Location = new System.Drawing.Point(794, 15);
            this.deleteButtonBeans.Name = "deleteButtonBeans";
            this.deleteButtonBeans.Size = new System.Drawing.Size(80, 23);
            this.deleteButtonBeans.TabIndex = 0;
            this.deleteButtonBeans.Text = "Delete";
            this.deleteButtonBeans.UseVisualStyleBackColor = true;
            this.deleteButtonBeans.Click += new System.EventHandler(this.OnDeleteButtonBeans_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.beanComboBox);
            this.tabPage2.Controls.Add(this.waterComboBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.beanLabel);
            this.tabPage2.Controls.Add(this.waterLabel);
            this.tabPage2.Controls.Add(this.coffeeTab_beanWeightTextBox);
            this.tabPage2.Controls.Add(this.weightLabel);
            this.tabPage2.Controls.Add(this.grindSizeLabel);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.coffeeDataGridView);
            this.tabPage2.Controls.Add(this.coffeeTab_grindSizeTextBox);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // beanComboBox
            // 
            this.beanComboBox.FormattingEnabled = true;
            this.beanComboBox.Location = new System.Drawing.Point(549, 413);
            this.beanComboBox.Name = "beanComboBox";
            this.beanComboBox.Size = new System.Drawing.Size(275, 23);
            this.beanComboBox.TabIndex = 29;
            // 
            // waterComboBox
            // 
            this.waterComboBox.FormattingEnabled = true;
            this.waterComboBox.Location = new System.Drawing.Point(549, 371);
            this.waterComboBox.Name = "waterComboBox";
            this.waterComboBox.Size = new System.Drawing.Size(275, 23);
            this.waterComboBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Title";
            // 
            // beanLabel
            // 
            this.beanLabel.AutoSize = true;
            this.beanLabel.Location = new System.Drawing.Point(452, 413);
            this.beanLabel.Name = "beanLabel";
            this.beanLabel.Size = new System.Drawing.Size(33, 15);
            this.beanLabel.TabIndex = 23;
            this.beanLabel.Text = "Bean";
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(452, 374);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(38, 15);
            this.waterLabel.TabIndex = 21;
            this.waterLabel.Text = "Water";
            // 
            // coffeeTab_beanWeightTextBox
            // 
            this.coffeeTab_beanWeightTextBox.Location = new System.Drawing.Point(126, 410);
            this.coffeeTab_beanWeightTextBox.Name = "coffeeTab_beanWeightTextBox";
            this.coffeeTab_beanWeightTextBox.Size = new System.Drawing.Size(240, 23);
            this.coffeeTab_beanWeightTextBox.TabIndex = 20;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(43, 413);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(74, 15);
            this.weightLabel.TabIndex = 19;
            this.weightLabel.Text = "Bean Weight";
            // 
            // grindSizeLabel
            // 
            this.grindSizeLabel.AutoSize = true;
            this.grindSizeLabel.Location = new System.Drawing.Point(43, 374);
            this.grindSizeLabel.Name = "grindSizeLabel";
            this.grindSizeLabel.Size = new System.Drawing.Size(59, 15);
            this.grindSizeLabel.TabIndex = 18;
            this.grindSizeLabel.Text = "Grind Size";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(794, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // coffeeDataGridView
            // 
            this.coffeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coffeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coffeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.coffeeDataGridView.Location = new System.Drawing.Point(3, 45);
            this.coffeeDataGridView.Name = "coffeeDataGridView";
            this.coffeeDataGridView.RowTemplate.Height = 25;
            this.coffeeDataGridView.Size = new System.Drawing.Size(946, 296);
            this.coffeeDataGridView.TabIndex = 16;
            this.coffeeDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.coffeeDataGridView_CellValidating);
            // 
            // coffeeTab_grindSizeTextBox
            // 
            this.coffeeTab_grindSizeTextBox.Location = new System.Drawing.Point(126, 371);
            this.coffeeTab_grindSizeTextBox.Name = "coffeeTab_grindSizeTextBox";
            this.coffeeTab_grindSizeTextBox.Size = new System.Drawing.Size(240, 23);
            this.coffeeTab_grindSizeTextBox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(436, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnAddCoffee);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(885, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.beansDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button insertButton;
    private DataGridView beansDataGridView;
    private TextBox nameBox;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private Button deleteButtonBeans;
    private TabPage tabPage2;
    private Label label1;
    private TextBox textBox3;
    private Label label5;
    private TextBox textBox2;
    private Label label4;
    private TextBox eanBox;
    private Label label3;
    private Label label2;
    private Label label6;
    private Button button3;
    private Label label7;
    private TextBox searchTextBox;
    private ComboBox comboBox1;
    private ComboBox waterComboBox;
    private Label label8;
    private TextBox textBox1;
    private Label label9;
    private Label beanLabel;
    private Label waterLabel;
    private TextBox coffeeTab_beanWeightTextBox;
    private Label weightLabel;
    private Label grindSizeLabel;
    private Button button1;
    private DataGridView coffeeDataGridView;
    private TextBox coffeeTab_grindSizeTextBox;
    private Button button2;
    private ComboBox beanComboBox;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
}
