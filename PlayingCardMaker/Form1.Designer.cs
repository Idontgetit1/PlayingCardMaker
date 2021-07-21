
namespace PlayingCardMaker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddBackgroundButton = new System.Windows.Forms.Button();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.AddTextButton = new System.Windows.Forms.Button();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComponentList = new System.Windows.Forms.ListBox();
            this.XPosition = new System.Windows.Forms.NumericUpDown();
            this.YPosition = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CSVButton = new System.Windows.Forms.Button();
            this.CSVLabel = new System.Windows.Forms.Label();
            this.SeperateFilesCheck = new System.Windows.Forms.CheckBox();
            this.CreateCardsButton = new System.Windows.Forms.Button();
            this.CreateMessageLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            this.SuspendLayout();
            // 
            // CardImage
            // 
            this.CardImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CardImage.Location = new System.Drawing.Point(279, 12);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(400, 622);
            this.CardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardImage.TabIndex = 0;
            this.CardImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AddBackgroundButton
            // 
            this.AddBackgroundButton.AccessibleName = "";
            this.AddBackgroundButton.Location = new System.Drawing.Point(12, 43);
            this.AddBackgroundButton.Name = "AddBackgroundButton";
            this.AddBackgroundButton.Size = new System.Drawing.Size(75, 23);
            this.AddBackgroundButton.TabIndex = 1;
            this.AddBackgroundButton.Text = "Background";
            this.AddBackgroundButton.UseVisualStyleBackColor = true;
            this.AddBackgroundButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.Location = new System.Drawing.Point(96, 48);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(152, 13);
            this.BackgroundLabel.TabIndex = 2;
            this.BackgroundLabel.Click += new System.EventHandler(this.BackgroundLabel_Click);
            // 
            // AddTextButton
            // 
            this.AddTextButton.Location = new System.Drawing.Point(13, 74);
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(75, 23);
            this.AddTextButton.TabIndex = 3;
            this.AddTextButton.Text = "Add Text";
            this.AddTextButton.UseVisualStyleBackColor = true;
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // AddImageButton
            // 
            this.AddImageButton.Location = new System.Drawing.Point(95, 73);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(75, 23);
            this.AddImageButton.TabIndex = 4;
            this.AddImageButton.Text = "Add Image";
            this.AddImageButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Components";
            // 
            // ComponentList
            // 
            this.ComponentList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ComponentList.FormattingEnabled = true;
            this.ComponentList.Location = new System.Drawing.Point(697, 43);
            this.ComponentList.Name = "ComponentList";
            this.ComponentList.Size = new System.Drawing.Size(227, 459);
            this.ComponentList.TabIndex = 6;
            this.ComponentList.SelectedIndexChanged += new System.EventHandler(this.ComponentList_SelectedIndexChanged);
            // 
            // XPosition
            // 
            this.XPosition.Location = new System.Drawing.Point(12, 173);
            this.XPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XPosition.Name = "XPosition";
            this.XPosition.Size = new System.Drawing.Size(75, 20);
            this.XPosition.TabIndex = 0;
            this.XPosition.ValueChanged += new System.EventHandler(this.XPosition_ValueChanged);
            // 
            // YPosition
            // 
            this.YPosition.Location = new System.Drawing.Point(93, 173);
            this.YPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YPosition.Name = "YPosition";
            this.YPosition.Size = new System.Drawing.Size(75, 20);
            this.YPosition.TabIndex = 7;
            this.YPosition.ValueChanged += new System.EventHandler(this.YPosition_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y Position";
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(187, 173);
            this.Size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(36, 20);
            this.Size.TabIndex = 10;
            this.Size.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Size";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(12, 128);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(208, 20);
            this.NameInput.TabIndex = 12;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // CSVButton
            // 
            this.CSVButton.Location = new System.Drawing.Point(697, 521);
            this.CSVButton.Name = "CSVButton";
            this.CSVButton.Size = new System.Drawing.Size(75, 23);
            this.CSVButton.TabIndex = 14;
            this.CSVButton.Text = "CSV File";
            this.CSVButton.UseVisualStyleBackColor = true;
            this.CSVButton.Click += new System.EventHandler(this.CSVButton_Click);
            // 
            // CSVLabel
            // 
            this.CSVLabel.Location = new System.Drawing.Point(778, 526);
            this.CSVLabel.Name = "CSVLabel";
            this.CSVLabel.Size = new System.Drawing.Size(152, 13);
            this.CSVLabel.TabIndex = 15;
            // 
            // SeperateFilesCheck
            // 
            this.SeperateFilesCheck.AutoSize = true;
            this.SeperateFilesCheck.Location = new System.Drawing.Point(697, 550);
            this.SeperateFilesCheck.Name = "SeperateFilesCheck";
            this.SeperateFilesCheck.Size = new System.Drawing.Size(174, 17);
            this.SeperateFilesCheck.TabIndex = 16;
            this.SeperateFilesCheck.Text = "Generate Seperate Card Files ?";
            this.SeperateFilesCheck.UseVisualStyleBackColor = true;
            // 
            // CreateCardsButton
            // 
            this.CreateCardsButton.Location = new System.Drawing.Point(697, 605);
            this.CreateCardsButton.Name = "CreateCardsButton";
            this.CreateCardsButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCardsButton.TabIndex = 17;
            this.CreateCardsButton.Text = "Create";
            this.CreateCardsButton.UseVisualStyleBackColor = true;
            this.CreateCardsButton.Click += new System.EventHandler(this.CreateCardsButton_Click);
            // 
            // CreateMessageLabel
            // 
            this.CreateMessageLabel.AutoSize = true;
            this.CreateMessageLabel.Location = new System.Drawing.Point(778, 610);
            this.CreateMessageLabel.Name = "CreateMessageLabel";
            this.CreateMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.CreateMessageLabel.TabIndex = 18;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 610);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 24);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(118, 610);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(93, 24);
            this.LoadButton.TabIndex = 20;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(937, 640);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreateMessageLabel);
            this.Controls.Add(this.CreateCardsButton);
            this.Controls.Add(this.SeperateFilesCheck);
            this.Controls.Add(this.CSVLabel);
            this.Controls.Add(this.CSVButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YPosition);
            this.Controls.Add(this.XPosition);
            this.Controls.Add(this.ComponentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.AddTextButton);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.AddBackgroundButton);
            this.Controls.Add(this.CardImage);
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CardImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddBackgroundButton;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Button AddTextButton;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ComponentList;
        private System.Windows.Forms.NumericUpDown XPosition;
        private System.Windows.Forms.NumericUpDown YPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CSVButton;
        private System.Windows.Forms.Label CSVLabel;
        private System.Windows.Forms.CheckBox SeperateFilesCheck;
        private System.Windows.Forms.Button CreateCardsButton;
        private System.Windows.Forms.Label CreateMessageLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

