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
using CsvHelper.Configuration;
using Newtonsoft.Json;

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
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*";

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
            ComponentList.SelectedIndex = ComponentList.Items.Count - 1;
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

        public static System.Drawing.Image Indexed2Image(System.Drawing.Image img, System.Drawing.Imaging.PixelFormat fmt)
        {
            //System.Drawing.Image bmp = new Bitmap(img.Width, img.Height, fmt);
            System.Drawing.Image bmp = new Bitmap(img.Width, img.Height, fmt);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(img, 0, 0);
            gr.Dispose();
            return bmp;
        }

        private void CreateCardsButton_Click(object sender, EventArgs e)
        {
            
            if (BackgroundLabel.Text == "")
            {
                CreateMessageLabel.Text = "No Background Image";
            }
            else if (imageTexts.Count <= 0)
            {
                CreateMessageLabel.Text = "No Components Created";
            }
            else if (CSVLabel.Text == "")
            {
                CreateMessageLabel.Text = "No CSV File Selected";
            }
            else
            {
                string filePath = string.Empty;
                string folderPath = string.Empty;

                if (!SeperateFilesCheck.Checked)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        saveFileDialog.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
                        saveFileDialog.FileName = "cards.png";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Specified File
                            filePath = saveFileDialog.FileName;
                        }
                    }
                }
                else
                {
                    using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                    {
                        folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                        if (folderDialog.ShowDialog() == DialogResult.OK)
                        {
                            folderPath = folderDialog.SelectedPath;
                        }

                    }
                }

                
                if (File.Exists(CSVLabel.Text))
                {
                    CsvReader csv = new CsvReader(File.OpenText(CSVLabel.Text), CultureInfo.InvariantCulture);
                    csv.Read();
                    csv.ReadHeader();

                    List<string> headers = csv.HeaderRecord.ToList();
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(new System.Data.DataColumn(header));
                    }

                    while (csv.Read())
                    {
                        System.Data.DataRow row = dataTable.NewRow();

                        foreach (System.Data.DataColumn column in dataTable.Columns)
                        {
                            row[column.ColumnName] = csv.GetField(column.DataType, column.ColumnName);
                        }

                        dataTable.Rows.Add(row);
                    }
                    //Added all Data to DataTable

                    List<Image> imgList = new List<Image>();

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Bitmap imgLoad = (Bitmap)Image.FromFile(BackgroundLabel.Text);
                        Image img = Indexed2Image(imgLoad, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        using (Graphics g = Graphics.FromImage(img))
                        {
                            for (int headerIndex = 0; headerIndex < headers.Count; headerIndex++)
                            {
                                foreach (Label label in imageTexts)
                                {
                                    if (label.Text == headers[headerIndex])
                                    {

                                        
                                        SolidBrush stringBrush = new SolidBrush(System.Drawing.Color.Black);
                                        float factor = (float)img.Width / CardImage.Width;
                                        Console.WriteLine("Image Size Factor: " + img.Width + " / " + CardImage.Width + ": " + factor);
                                        float relX = label.Location.X * factor;
                                        Console.WriteLine(relX);
                                        float relY = label.Location.Y * factor;
                                        Console.WriteLine(relY);
                                        
                                        System.Drawing.Font stringFont = new System.Drawing.Font("Arial", label.Font.Size * factor);
                                        g.DrawString((string)dataTable.Rows[i][headerIndex], stringFont, stringBrush, relX, relY);
                                    }
                                }
                            }
                        }
                        imgList.Add(img);
                        //img.Save("IMG" + i + ".png");
                    }

                    //if seperate Files is checked
                    if (SeperateFilesCheck.Checked)
                    {
                        for (int i = 0; i < imgList.Count; i++)
                        {
                            imgList[i].Save(folderPath + "/IMG_" + i + ".png");
                        }
                    }
                    else
                    {
                        int GridSize = (int)Math.Ceiling(Math.Sqrt(imgList.Count));
                        int width = imgList[0].Width;
                        int height = imgList[0].Height;
                        Image GridImage = new Bitmap(GridSize * width, GridSize * height);
                        using (Graphics g = Graphics.FromImage(GridImage))
                        {
                            int ImageCount = 0;
                            for (int x = 0; x < GridSize; x++)
                            {
                                for (int y = 0; y < GridSize; y++)
                                {
                                    if (ImageCount >= imgList.Count)
                                    {
                                        break;
                                    }

                                    PointF Position = new PointF(x * width, y * height);
                                    g.DrawImage(imgList[ImageCount], Position);
                                    ImageCount++;
                                }
                            }
                        }
                        GridImage.Save(filePath);
                    }

                }
            }
        }

        private void CSVButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Specified File
                    filePath = openFileDialog.FileName;

                    CSVLabel.Text = filePath;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "Card Creator Save Files (*.ccsv)|*.ccsv|All files (*.*)|*.*";
                saveFileDialog.FileName = "save.ccsv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Specified File
                    filePath = saveFileDialog.FileName;

                    List<SerLabel> labelList = new List<SerLabel>();

                    foreach (Label label in imageTexts)
                    {
                        SerLabel serLabel = new SerLabel()
                        {
                            X = label.Location.X,
                            Y = label.Location.Y,
                            Size = label.Font.Size,
                            Text = label.Text
                        };

                        labelList.Add(serLabel);
                    }

                    Save save = new Save()
                    {
                        labels = labelList,
                        Background = BackgroundLabel.Text,
                        CSVFile = CSVLabel.Text
                    };

                    string json = JsonConvert.SerializeObject(save, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                }
            }
            

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Card Creator Save Files (*.ccsv)|*.ccsv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Specified File
                    filePath = openFileDialog.FileName;

                    string jsonString = File.ReadAllText(filePath);

                    Save load = JsonConvert.DeserializeObject<Save>(jsonString);

                    BackgroundLabel.Text = load.Background;
                    CardImage.Image = Image.FromFile(load.Background);
                    CSVLabel.Text = load.CSVFile;

                    foreach (SerLabel serLabel in load.labels)
                    {
                        Label newText = new Label();
                        newText.AutoSize = true;
                        newText.BackColor = Color.Transparent;
                        newText.Location = new Point(serLabel.X, serLabel.Y);
                        newText.Text = serLabel.Text;
                        Font newFont = new Font(newText.Font.FontFamily, (float)serLabel.Size, newText.Font.Style);
                        newText.Font = newFont;
                        CardImage.Controls.Add(newText);
                        imageTexts.Add(newText);
                        ComponentList.Items.Add(newText.Text);
                    }
                }
            }
            
        }
    }

    class Save
    {
        public List<SerLabel> labels;
        public string Background;
        public string CSVFile;
    }

    class SerLabel
    {
        public int X;
        public int Y;
        public string Text;
        public float Size;
    }
}
