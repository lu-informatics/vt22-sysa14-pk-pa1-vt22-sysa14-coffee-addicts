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
            this.tabA2C2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.A3C2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a3c2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabA2C2
            // 
            this.tabA2C2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabA2C2.Controls.Add(this.tabPage1);
            this.tabA2C2.Controls.Add(this.A3C2);
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
    }
}