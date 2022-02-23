namespace GuiClient
{
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
            this.tabA2C2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.a2c2OutputField = new System.Windows.Forms.RichTextBox();
            this.a2c2FindButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.A3C2 = new System.Windows.Forms.TabPage();
            this.a3c2DataGridView = new System.Windows.Forms.DataGridView();
            this.a3c2TableNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.a4c1tab = new System.Windows.Forms.TabPage();
            this.a4c1AddBtn = new System.Windows.Forms.Button();
            this.a4c1DeleteBtn = new System.Windows.Forms.Button();
            this.a4c1dataGridView = new System.Windows.Forms.DataGridView();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a4c1FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.a4c1LastNameTextBox = new System.Windows.Forms.TextBox();
            this.a4c1JobTitleTextBox = new System.Windows.Forms.TextBox();
            this.a4c1PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.a4c1CityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabA2C2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.A3C2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a3c2DataGridView)).BeginInit();
            this.a4c1tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a4c1dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabA2C2
            // 
            this.tabA2C2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabA2C2.Controls.Add(this.tabPage1);
            this.tabA2C2.Controls.Add(this.A3C2);
            this.tabA2C2.Controls.Add(this.a4c1tab);
            this.tabA2C2.Location = new System.Drawing.Point(0, 0);
            this.tabA2C2.Name = "tabA2C2";
            this.tabA2C2.SelectedIndex = 0;
            this.tabA2C2.Size = new System.Drawing.Size(798, 446);
            this.tabA2C2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.a2c2OutputField);
            this.tabPage1.Controls.Add(this.a2c2FindButton);
            this.tabPage1.Controls.Add(this.fileNameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "A2C2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // a2c2OutputField
            // 
            this.a2c2OutputField.Location = new System.Drawing.Point(136, 108);
            this.a2c2OutputField.Name = "a2c2OutputField";
            this.a2c2OutputField.Size = new System.Drawing.Size(215, 100);
            this.a2c2OutputField.TabIndex = 3;
            this.a2c2OutputField.Text = "";
            // 
            // a2c2FindButton
            // 
            this.a2c2FindButton.Location = new System.Drawing.Point(288, 21);
            this.a2c2FindButton.Name = "a2c2FindButton";
            this.a2c2FindButton.Size = new System.Drawing.Size(75, 23);
            this.a2c2FindButton.TabIndex = 2;
            this.a2c2FindButton.Text = "Read";
            this.a2c2FindButton.UseVisualStyleBackColor = true;
            this.a2c2FindButton.Click += new System.EventHandler(this.OnA2C2FindButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(144, 21);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // A3C2
            // 
            this.A3C2.Controls.Add(this.a3c2DataGridView);
            this.A3C2.Controls.Add(this.a3c2TableNameComboBox);
            this.A3C2.Controls.Add(this.label2);
            this.A3C2.Location = new System.Drawing.Point(4, 24);
            this.A3C2.Name = "A3C2";
            this.A3C2.Padding = new System.Windows.Forms.Padding(3);
            this.A3C2.Size = new System.Drawing.Size(790, 418);
            this.A3C2.TabIndex = 1;
            this.A3C2.Text = "A3C2";
            this.A3C2.UseVisualStyleBackColor = true;
            // 
            // a3c2DataGridView
            // 
            this.a3c2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.a3c2DataGridView.Location = new System.Drawing.Point(34, 23);
            this.a3c2DataGridView.Name = "a3c2DataGridView";
            this.a3c2DataGridView.ReadOnly = true;
            this.a3c2DataGridView.RowTemplate.Height = 25;
            this.a3c2DataGridView.Size = new System.Drawing.Size(707, 235);
            this.a3c2DataGridView.TabIndex = 2;
            // 
            // a3c2TableNameComboBox
            // 
            this.a3c2TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a3c2TableNameComboBox.FormattingEnabled = true;
            this.a3c2TableNameComboBox.Location = new System.Drawing.Point(368, 291);
            this.a3c2TableNameComboBox.Name = "a3c2TableNameComboBox";
            this.a3c2TableNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.a3c2TableNameComboBox.TabIndex = 1;
            this.a3c2TableNameComboBox.SelectedIndexChanged += new System.EventHandler(this.A3c2TableNameComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table name:";
            // 
            // a4c1tab
            // 
            this.a4c1tab.Controls.Add(this.label7);
            this.a4c1tab.Controls.Add(this.label6);
            this.a4c1tab.Controls.Add(this.label5);
            this.a4c1tab.Controls.Add(this.label4);
            this.a4c1tab.Controls.Add(this.label3);
            this.a4c1tab.Controls.Add(this.a4c1CityTextBox);
            this.a4c1tab.Controls.Add(this.a4c1PhoneNumberTextBox);
            this.a4c1tab.Controls.Add(this.a4c1JobTitleTextBox);
            this.a4c1tab.Controls.Add(this.a4c1LastNameTextBox);
            this.a4c1tab.Controls.Add(this.a4c1FirstNameTextBox);
            this.a4c1tab.Controls.Add(this.a4c1AddBtn);
            this.a4c1tab.Controls.Add(this.a4c1DeleteBtn);
            this.a4c1tab.Controls.Add(this.a4c1dataGridView);
            this.a4c1tab.Location = new System.Drawing.Point(4, 24);
            this.a4c1tab.Name = "a4c1tab";
            this.a4c1tab.Padding = new System.Windows.Forms.Padding(3);
            this.a4c1tab.Size = new System.Drawing.Size(790, 418);
            this.a4c1tab.TabIndex = 2;
            this.a4c1tab.Text = "A4C1";
            this.a4c1tab.UseVisualStyleBackColor = true;
            // 
            // a4c1AddBtn
            // 
            this.a4c1AddBtn.Location = new System.Drawing.Point(293, 370);
            this.a4c1AddBtn.Name = "a4c1AddBtn";
            this.a4c1AddBtn.Size = new System.Drawing.Size(75, 23);
            this.a4c1AddBtn.TabIndex = 2;
            this.a4c1AddBtn.Text = "Add";
            this.a4c1AddBtn.UseVisualStyleBackColor = true;
            this.a4c1AddBtn.Click += new System.EventHandler(this.a4c1AddBtn_Click);
            // 
            // a4c1DeleteBtn
            // 
            this.a4c1DeleteBtn.Location = new System.Drawing.Point(415, 370);
            this.a4c1DeleteBtn.Name = "a4c1DeleteBtn";
            this.a4c1DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.a4c1DeleteBtn.TabIndex = 1;
            this.a4c1DeleteBtn.Text = "Delete";
            this.a4c1DeleteBtn.UseVisualStyleBackColor = true;
            this.a4c1DeleteBtn.Click += new System.EventHandler(this.OnA4c1DeleteBtn_Click);
            // 
            // a4c1dataGridView
            // 
            this.a4c1dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.a4c1dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First_Name,
            this.Last_Name,
            this.Job_Title,
            this.Phone_No,
            this.City});
            this.a4c1dataGridView.Location = new System.Drawing.Point(3, 6);
            this.a4c1dataGridView.Name = "a4c1dataGridView";
            this.a4c1dataGridView.RowTemplate.Height = 25;
            this.a4c1dataGridView.Size = new System.Drawing.Size(784, 248);
            this.a4c1dataGridView.TabIndex = 0;
            this.a4c1dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.a4c1dataGridView_CellEndEdit);
            this.a4c1dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.a4c1dataGridView_DataError);
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "First_Name";
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            // 
            // Last_Name
            // 
            this.Last_Name.DataPropertyName = "Last_Name";
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            // 
            // Job_Title
            // 
            this.Job_Title.DataPropertyName = "Job_Title";
            this.Job_Title.HeaderText = "Job Title";
            this.Job_Title.Name = "Job_Title";
            // 
            // Phone_No
            // 
            this.Phone_No.DataPropertyName = "Phone_No_";
            this.Phone_No.HeaderText = "Phone Number";
            this.Phone_No.Name = "Phone_No";
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // a4c1FirstNameTextBox
            // 
            this.a4c1FirstNameTextBox.Location = new System.Drawing.Point(83, 279);
            this.a4c1FirstNameTextBox.Name = "a4c1FirstNameTextBox";
            this.a4c1FirstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.a4c1FirstNameTextBox.TabIndex = 3;
            // 
            // a4c1LastNameTextBox
            // 
            this.a4c1LastNameTextBox.Location = new System.Drawing.Point(83, 329);
            this.a4c1LastNameTextBox.Name = "a4c1LastNameTextBox";
            this.a4c1LastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.a4c1LastNameTextBox.TabIndex = 4;
            // 
            // a4c1JobTitleTextBox
            // 
            this.a4c1JobTitleTextBox.Location = new System.Drawing.Point(293, 279);
            this.a4c1JobTitleTextBox.Name = "a4c1JobTitleTextBox";
            this.a4c1JobTitleTextBox.Size = new System.Drawing.Size(100, 23);
            this.a4c1JobTitleTextBox.TabIndex = 5;
            // 
            // a4c1PhoneNumberTextBox
            // 
            this.a4c1PhoneNumberTextBox.Location = new System.Drawing.Point(293, 329);
            this.a4c1PhoneNumberTextBox.Name = "a4c1PhoneNumberTextBox";
            this.a4c1PhoneNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.a4c1PhoneNumberTextBox.TabIndex = 6;
            // 
            // a4c1CityTextBox
            // 
            this.a4c1CityTextBox.Location = new System.Drawing.Point(534, 279);
            this.a4c1CityTextBox.Name = "a4c1CityTextBox";
            this.a4c1CityTextBox.Size = new System.Drawing.Size(100, 23);
            this.a4c1CityTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Job Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "City";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabA2C2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabA2C2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.A3C2.ResumeLayout(false);
            this.A3C2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a3c2DataGridView)).EndInit();
            this.a4c1tab.ResumeLayout(false);
            this.a4c1tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a4c1dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabA2C2;
        private TabPage tabPage1;
        private TabPage A3C2;
        private RichTextBox a2c2OutputField;
        private Button a2c2FindButton;
        private TextBox fileNameTextBox;
        private Label label1;
        private DataGridView a3c2DataGridView;
        private ComboBox a3c2TableNameComboBox;
        private Label label2;
        private TabPage a4c1tab;
        private Button a4c1AddBtn;
        private Button a4c1DeleteBtn;
        private DataGridView a4c1dataGridView;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Last_Name;
        private DataGridViewTextBoxColumn Job_Title;
        private DataGridViewTextBoxColumn Phone_No;
        private DataGridViewTextBoxColumn City;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox a4c1CityTextBox;
        private TextBox a4c1PhoneNumberTextBox;
        private TextBox a4c1JobTitleTextBox;
        private TextBox a4c1LastNameTextBox;
        private TextBox a4c1FirstNameTextBox;
    }
}