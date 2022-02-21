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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.a2c2FindButton = new System.Windows.Forms.Button();
            this.a2c2OutputField = new System.Windows.Forms.RichTextBox();
            this.tabA2C2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabA2C2
            // 
            this.tabA2C2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabA2C2.Controls.Add(this.tabPage1);
            this.tabA2C2.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(144, 21);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.fileNameTextBox.TabIndex = 1;
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
            // a2c2OutputField
            // 
            this.a2c2OutputField.Location = new System.Drawing.Point(136, 108);
            this.a2c2OutputField.Name = "a2c2OutputField";
            this.a2c2OutputField.Size = new System.Drawing.Size(215, 100);
            this.a2c2OutputField.TabIndex = 3;
            this.a2c2OutputField.Text = "";
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabA2C2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox a2c2OutputField;
        private Button a2c2FindButton;
        private TextBox fileNameTextBox;
        private Label label1;
    }
}