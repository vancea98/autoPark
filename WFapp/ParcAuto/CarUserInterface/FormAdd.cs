using System;
using CarModel;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CarUserInterface;

namespace CarUserInterface
{
    public partial class FormAdd : Form
    {
        public Car carInfo { get; set; }
        
        public FormAdd()
        {
            InitializeComponent();
        }

        private void ButtonSaveToDisk_Click(object sender, EventArgs e)
        {


            carInfo.Id = int.Parse(textBoxAddId.Text);
            carInfo.Manufacturer = textBoxAddMarca.Text;
            carInfo.Model = textBoxAddModel.Text;
            carInfo.Price = decimal.Parse(textBoxAddPret.Text);
            carInfo.Year = int.Parse(textBoxAddAnFab.Text);
            carInfo.Sold = false;
            carInfo.Pictures.Add(new Picture { FilePath = textBoxPicturePath.Text, Name = "Picture1" });
            carInfo.Owner = Form1.autoPark.Vendors[0];

            string carAsJson = JsonConvert.SerializeObject(carInfo);

            File.WriteAllText(string.Format(@"C:\Users\mihai\OneDrive\Desktop\CV\WFapp\ParcAuto\Data\{0}.json", carInfo.Id), carAsJson); 

            this.Close();
        }

        private void ButtonBrowsePic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
                // image file path  
                textBoxPicturePath.Text = open.FileName;
            }

        }
    }
}
