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
        private List<Component> imageComponents = new List<Component>{};

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
            newText.Text = "New Text";
            CardImage.Controls.Add(newText);
            Component newLabelComponent = new Component()
            {
                isText = true,
                label = newText
            };
            imageComponents.Add(newLabelComponent);
            ComponentList.Items.Add(newText.Text);
            ComponentList.SelectedIndex = ComponentList.Items.Count - 1;
        }

        private void ComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!NameInput.Focused)
            {
                if (imageComponents[ComponentList.SelectedIndex].isText)
                {
                    Size.Visible = true;
                    SizeLabel.Visible = true;
                    WidthLabel.Visible = false;
                    ImageWidth.Visible = false;
                    HeightLabel.Visible = false;
                    ImageHeight.Visible = false;
                    Label selectedLabel = imageComponents[ComponentList.SelectedIndex].label;
                    XPosition.Value = selectedLabel.Location.X;
                    YPosition.Value = selectedLabel.Location.Y;
                    Size.Value = (decimal)selectedLabel.Font.Size;
                    NameInput.Text = selectedLabel.Text;
                }
                else
                {
                    Size.Visible = false;
                    SizeLabel.Visible = false;
                    WidthLabel.Visible = true;
                    ImageWidth.Visible = true;
                    HeightLabel.Visible = true;
                    ImageHeight.Visible = true;
                    PictureBox selectedPicture = imageComponents[ComponentList.SelectedIndex].image;
                    XPosition.Value = selectedPicture.Location.X;
                    YPosition.Value = selectedPicture.Location.Y;
                    NameInput.Text = selectedPicture.Name;
                    ImageWidth.Value = selectedPicture.Width;
                    ImageHeight.Value = selectedPicture.Height;
                }
            }
        }

        private void XPosition_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            if (imageComponents[ComponentList.SelectedIndex].isText)
            {
                Label selectedLabel = imageComponents[ComponentList.SelectedIndex].label;
                selectedLabel.Location = new Point((int)XPosition.Value, selectedLabel.Location.Y);
            }
            else
            {
                PictureBox selectedPicture = imageComponents[ComponentList.SelectedIndex].image;
                selectedPicture.Location = new Point((int)XPosition.Value, selectedPicture.Location.Y);
            }
        }

        private void Size_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            if (imageComponents[ComponentList.SelectedIndex].isText)
            {
                Label selectedLabel = imageComponents[ComponentList.SelectedIndex].label;
                Font newFont = new Font(selectedLabel.Font.FontFamily, (float)Size.Value, selectedLabel.Font.Style);
                selectedLabel.Font = newFont;
            }
        }

        private void YPosition_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            if (imageComponents[ComponentList.SelectedIndex].isText)
            {
                Label selectedLabel = imageComponents[ComponentList.SelectedIndex].label;
                selectedLabel.Location = new Point(selectedLabel.Location.X, (int)YPosition.Value);
            }
            else
            {
                PictureBox selectedPicture = imageComponents[ComponentList.SelectedIndex].image;
                selectedPicture.Location = new Point(selectedPicture.Location.X, (int)YPosition.Value);
            }
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            if (imageComponents[ComponentList.SelectedIndex].isText)
            {
                Label selectedLabel = imageComponents[ComponentList.SelectedIndex].label;
                selectedLabel.Text = NameInput.Text;
                ComponentList.Items[ComponentList.SelectedIndex] = selectedLabel.Text;
            }
            else
            {
                PictureBox selectedPicture = imageComponents[ComponentList.SelectedIndex].image;
                selectedPicture.Name = NameInput.Text;
                ComponentList.Items[ComponentList.SelectedIndex] = selectedPicture.Name;
            }
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
            else if (imageComponents.Count <= 0)
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
                                foreach (Component component in imageComponents)
                                {
                                    if (component.isText)
                                    {
                                        //if Component is Text
                                        if (component.label.Text == headers[headerIndex])
                                        {
                                            //if Label hast CSV Header simmilarities
                                            if ((string)dataTable.Rows[i][headerIndex] != "")
                                            {
                                                //if text is not empty
                                                SolidBrush stringBrush = new SolidBrush(System.Drawing.Color.Black);
                                                float factor = (float)img.Width / CardImage.Width;
                                                Console.WriteLine("Image Size Factor: " + img.Width + " / " + CardImage.Width + ": " + factor);
                                                float relX = component.label.Location.X * factor;
                                                Console.WriteLine(relX);
                                                float relY = component.label.Location.Y * factor;
                                                Console.WriteLine(relY);

                                                System.Drawing.Font stringFont = new System.Drawing.Font("Arial", component.label.Font.Size * factor);
                                                g.DrawString((string)dataTable.Rows[i][headerIndex], stringFont, stringBrush, relX, relY);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //if Component is Image
                                        if (component.image.Name == headers[headerIndex])
                                        {
                                            //if Image is in headers / in CSV File
                                            if ((string)dataTable.Rows[i][headerIndex] != "")
                                            {
                                                //if path is not empty
                                                float factorWidth = (float)img.Width / CardImage.Width;
                                                float factorHeight = (float)img.Width / CardImage.Width;
                                                float relX = component.image.Location.X * factorWidth;
                                                float relY = component.image.Location.Y * factorHeight;
                                                float relWidth = component.image.Width * factorWidth;
                                                float relHeight = component.image.Height * factorHeight;

                                                //get Image from DataTable
                                                string imagePath = (string)dataTable.Rows[i][headerIndex];
                                                Image tempImg = Image.FromFile(imagePath);

                                                g.DrawImage(tempImg, relX, relY, relWidth, relHeight);
                                            }
                                        }
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
                    List<SerImage> imageList = new List<SerImage>();

                    foreach (Component component in imageComponents)
                    {
                        if (component.isText)
                        {
                            SerLabel serLabel = new SerLabel()
                            {
                                X = component.label.Location.X,
                                Y = component.label.Location.Y,
                                Size = component.label.Font.Size,
                                Text = component.label.Text
                            };

                            labelList.Add(serLabel);
                        }
                        else
                        {
                            SerImage serImage = new SerImage()
                            {
                                X = component.image.Location.X,
                                Y = component.image.Location.Y,
                                SizeX = component.image.Width,
                                SizeY = component.image.Height,
                                Name = component.image.Name
                            };

                            imageList.Add(serImage);
                        }
                    }

                    Save save = new Save()
                    {
                        labels = labelList,
                        images = imageList,
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
                        Component newComponent = new Component()
                        {
                            isText = true,
                            label = newText
                        };
                        imageComponents.Add(newComponent);
                        ComponentList.Items.Add(newText.Text);
                    }

                    foreach (SerImage serImage in load.images)
                    {
                        PictureBox newPictureBox = new PictureBox();
                        newPictureBox.Location = new Point(serImage.X, serImage.Y);
                        newPictureBox.Name = serImage.Name;
                        newPictureBox.Width = serImage.SizeX;
                        newPictureBox.Height = serImage.SizeY;
                        CardImage.Controls.Add(newPictureBox);
                        Component newComponent = new Component()
                        {
                            isText = false,
                            image = newPictureBox
                        };
                        imageComponents.Add(newComponent);
                        ComponentList.Items.Add(newPictureBox.Name);
                    }

                    if (ComponentList.Items.Count > 0)
                    {
                        ComponentList.SelectedIndex = 0;
                    }
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageWidth_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            PictureBox selectedPictureBox = imageComponents[ComponentList.SelectedIndex].image;
            selectedPictureBox.Width = (int)ImageWidth.Value;
        }

        private void ImageHeight_ValueChanged(object sender, EventArgs e)
        {
            //Get currently Selected Element
            PictureBox selectedPictureBox = imageComponents[ComponentList.SelectedIndex].image;
            selectedPictureBox.Height = (int)ImageHeight.Value;
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            Image boxImage = new Bitmap(1000, 1000, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(boxImage))
            {
                g.FillRectangle(
                    Brushes.White, 0, 0, boxImage.Width, boxImage.Height);
            }
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Height = 50;
            newPictureBox.Width = 50;
            newPictureBox.Location = new Point(15, 15);
            newPictureBox.Name = "New Image";
            CardImage.Controls.Add(newPictureBox);
            Component newPictureComponent = new Component()
            {
                isText = false,
                image = newPictureBox
            };
            imageComponents.Add(newPictureComponent);
            ComponentList.Items.Add(newPictureComponent.image.Name);
            ComponentList.SelectedIndex = ComponentList.Items.Count - 1;
        }
    }

    class Save
    {
        public List<SerLabel> labels;
        public List<SerImage> images;
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

    class SerImage
    {
        public int X;
        public int Y;
        public string Name;
        public int SizeX;
        public int SizeY;
    }

    class Component
    {
        public bool isText;
        public Label label;
        public PictureBox image;
    }
}
