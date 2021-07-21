using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

using CsvHelper;


namespace PlayingCardMaker
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;
        private List<Label> imageTexts = new List<Label>{};

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Specified File
                    filePath = openFileDialog.FileName;

                    CardImage.Image = Image.FromFile(filePath);

                    BackgroundLabel.Text = filePath;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            Label newText = new Label();
            newText.AutoSize = true;
            newText.BackColor = Color.Transparent;
            newText.Location = new Point(15, 15);
            newText.Text = "Test";
            CardImage.Controls.Add(newText);
            imageTexts.Add(newText);
            ComponentList.Items.Add(newText.Text);
        }

        private void ComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!NameInput.Focused)
            {
                Label selectedLabel = imageTexts[ComponentList.SelectedIndex];
                XPosition.Value = selectedLabel.Location.X;
                YPosition.Value = selectedLabel.Location.Y;
                Size.Value = (decimal)selectedLabel.Font.Size;
                NameInput.Text = selectedLabel.Text;
            }
        }

        private void XPosition_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            Label selectedLabel = imageTexts[ComponentList.SelectedIndex];
            selectedLabel.Location = new Point((int)XPosition.Value, selectedLabel.Location.Y);
        }

        private void Size_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            Label selectedLabel = imageTexts[ComponentList.SelectedIndex];
            Font newFont = new Font(selectedLabel.Font.FontFamily, (float)Size.Value, selectedLabel.Font.Style);
            selectedLabel.Font = newFont;
        }

        private void YPosition_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            Label selectedLabel = imageTexts[ComponentList.SelectedIndex];
            selectedLabel.Location = new Point(selectedLabel.Location.X, (int)YPosition.Value);
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            Label selectedLabel = imageTexts[ComponentList.SelectedIndex];
            selectedLabel.Text = NameInput.Text;
            ComponentList.Items[ComponentList.SelectedIndex] = selectedLabel.Text;
        }

        private void BackgroundLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateCardsButton_Click(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(@"C:\Users\thumb\OneDrive\Dokumente\PlayingCardCreator\GeneralSet\parameters.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<dynamic>();
                    Console.WriteLine();
                }
            }
        }

        private void CSVButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Specified File
                    filePath = openFileDialog.FileName;

                    CSVLabel.Text = filePath;
                }
            }
        }
    }
}
