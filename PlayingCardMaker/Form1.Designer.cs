
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
            this.SizeLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CSVButton = new System.Windows.Forms.Button();
            this.CSVLabel = new System.Windows.Forms.Label();
            this.SeperateFilesCheck = new System.Windows.Forms.CheckBox();
            this.CreateCardsButton = new System.Windows.Forms.Button();
            this.CreateMessageLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.ImageHeight = new System.Windows.Forms.NumericUpDown();
            this.ImageWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // CardImage
            // 
            this.CardImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CardImage.Location = new System.Drawing.Point(282, 93);
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
            this.AddBackgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBackgroundButton.ForeColor = System.Drawing.Color.White;
            this.AddBackgroundButton.Location = new System.Drawing.Point(17, 147);
            this.AddBackgroundButton.Name = "AddBackgroundButton";
            this.AddBackgroundButton.Size = new System.Drawing.Size(75, 58);
            this.AddBackgroundButton.TabIndex = 1;
            this.AddBackgroundButton.Text = "Background";
            this.AddBackgroundButton.UseVisualStyleBackColor = true;
            this.AddBackgroundButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.Location = new System.Drawing.Point(101, 152);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(152, 48);
            this.BackgroundLabel.TabIndex = 2;
            this.BackgroundLabel.Click += new System.EventHandler(this.BackgroundLabel_Click);
            // 
            // AddTextButton
            // 
            this.AddTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTextButton.ForeColor = System.Drawing.Color.White;
            this.AddTextButton.Location = new System.Drawing.Point(17, 229);
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(75, 41);
            this.AddTextButton.TabIndex = 3;
            this.AddTextButton.Text = "Add Text";
            this.AddTextButton.UseVisualStyleBackColor = true;
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // AddImageButton
            // 
            this.AddImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImageButton.ForeColor = System.Drawing.Color.White;
            this.AddImageButton.Location = new System.Drawing.Point(99, 229);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(75, 41);
            this.AddImageButton.TabIndex = 4;
            this.AddImageButton.Text = "Add Image";
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(694, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Components";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ComponentList
            // 
            this.ComponentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ComponentList.ForeColor = System.Drawing.Color.White;
            this.ComponentList.FormattingEnabled = true;
            this.ComponentList.Location = new System.Drawing.Point(697, 128);
            this.ComponentList.Name = "ComponentList";
            this.ComponentList.Size = new System.Drawing.Size(227, 459);
            this.ComponentList.TabIndex = 6;
            this.ComponentList.SelectedIndexChanged += new System.EventHandler(this.ComponentList_SelectedIndexChanged);
            // 
            // XPosition
            // 
            this.XPosition.Location = new System.Drawing.Point(17, 380);
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
            this.YPosition.Location = new System.Drawing.Point(98, 380);
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y Position";
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(192, 380);
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
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.Color.White;
            this.SizeLabel.Location = new System.Drawing.Point(189, 364);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 11;
            this.SizeLabel.Text = "Size";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(17, 306);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(208, 20);
            this.NameInput.TabIndex = 12;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // CSVButton
            // 
            this.CSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSVButton.ForeColor = System.Drawing.Color.White;
            this.CSVButton.Location = new System.Drawing.Point(697, 585);
            this.CSVButton.Name = "CSVButton";
            this.CSVButton.Size = new System.Drawing.Size(75, 48);
            this.CSVButton.TabIndex = 14;
            this.CSVButton.Text = "CSV File";
            this.CSVButton.UseVisualStyleBackColor = true;
            this.CSVButton.Click += new System.EventHandler(this.CSVButton_Click);
            // 
            // CSVLabel
            // 
            this.CSVLabel.Location = new System.Drawing.Point(778, 590);
            this.CSVLabel.Name = "CSVLabel";
            this.CSVLabel.Size = new System.Drawing.Size(152, 38);
            this.CSVLabel.TabIndex = 15;
            // 
            // SeperateFilesCheck
            // 
            this.SeperateFilesCheck.AutoSize = true;
            this.SeperateFilesCheck.ForeColor = System.Drawing.Color.White;
            this.SeperateFilesCheck.Location = new System.Drawing.Point(697, 639);
            this.SeperateFilesCheck.Name = "SeperateFilesCheck";
            this.SeperateFilesCheck.Size = new System.Drawing.Size(174, 17);
            this.SeperateFilesCheck.TabIndex = 16;
            this.SeperateFilesCheck.Text = "Generate Seperate Card Files ?";
            this.SeperateFilesCheck.UseVisualStyleBackColor = true;
            // 
            // CreateCardsButton
            // 
            this.CreateCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCardsButton.ForeColor = System.Drawing.Color.White;
            this.CreateCardsButton.Location = new System.Drawing.Point(697, 673);
            this.CreateCardsButton.Name = "CreateCardsButton";
            this.CreateCardsButton.Size = new System.Drawing.Size(75, 44);
            this.CreateCardsButton.TabIndex = 17;
            this.CreateCardsButton.Text = "Create";
            this.CreateCardsButton.UseVisualStyleBackColor = true;
            this.CreateCardsButton.Click += new System.EventHandler(this.CreateCardsButton_Click);
            // 
            // CreateMessageLabel
            // 
            this.CreateMessageLabel.AutoSize = true;
            this.CreateMessageLabel.Location = new System.Drawing.Point(778, 699);
            this.CreateMessageLabel.Name = "CreateMessageLabel";
            this.CreateMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.CreateMessageLabel.TabIndex = 18;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 53);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(99, 0);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(93, 53);
            this.LoadButton.TabIndex = 20;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1180, 673);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 21;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.LoadButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 53);
            this.panel1.TabIndex = 22;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(97, 434);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 24;
            this.HeightLabel.Text = "Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.ForeColor = System.Drawing.Color.White;
            this.WidthLabel.Location = new System.Drawing.Point(14, 434);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 23;
            this.WidthLabel.Text = "Width";
            // 
            // ImageHeight
            // 
            this.ImageHeight.Location = new System.Drawing.Point(98, 450);
            this.ImageHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImageHeight.Name = "ImageHeight";
            this.ImageHeight.Size = new System.Drawing.Size(75, 20);
            this.ImageHeight.TabIndex = 26;
            this.ImageHeight.ValueChanged += new System.EventHandler(this.ImageHeight_ValueChanged);
            // 
            // ImageWidth
            // 
            this.ImageWidth.Location = new System.Drawing.Point(17, 450);
            this.ImageWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImageWidth.Name = "ImageWidth";
            this.ImageWidth.Size = new System.Drawing.Size(75, 20);
            this.ImageWidth.TabIndex = 25;
            this.ImageWidth.ValueChanged += new System.EventHandler(this.ImageWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1242, 727);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ImageHeight);
            this.Controls.Add(this.ImageWidth);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateMessageLabel);
            this.Controls.Add(this.CreateCardsButton);
            this.Controls.Add(this.SeperateFilesCheck);
            this.Controls.Add(this.CSVLabel);
            this.Controls.Add(this.CSVButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.SizeLabel);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playing Card Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageWidth)).EndInit();
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
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CSVButton;
        private System.Windows.Forms.Label CSVLabel;
        private System.Windows.Forms.CheckBox SeperateFilesCheck;
        private System.Windows.Forms.Button CreateCardsButton;
        private System.Windows.Forms.Label CreateMessageLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown ImageHeight;
        private System.Windows.Forms.NumericUpDown ImageWidth;
    }
}

