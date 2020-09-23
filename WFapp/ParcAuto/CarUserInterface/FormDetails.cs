using System;
using CarModel;
using CarUserInterface;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarUserInterface
{
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.detaliedCar.Id.ToString();
            textBox2.Text = Form1.detaliedCar.Manufacturer;
            textBox3.Text = Form1.detaliedCar.Model;
            textBox4.Text = Form1.detaliedCar.Price.ToString();
            textBox5.Text = Form1.detaliedCar.Year.ToString();
            textBox6.Text = Form1.detaliedCar.Combustibil;
            textBox7.Text = Form1.detaliedCar.Km.ToString();
            pictureBox1.Image = new Bitmap (Form1.detaliedCar.Pictures[0].FilePath.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (Form1.detaliedCar.Status == true)
                checkBoxFirstHand.CheckState = CheckState.Checked;
            else
                checkBoxSecondHand.CheckState = CheckState.Checked;
            // poze + butoane REMINDER

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Form1.detaliedCar.Model = textBox3.Text;
            Form1.detaliedCar.Manufacturer = textBox2.Text;
            Form1.detaliedCar.Price = decimal.Parse(textBox4.Text);
            Form1.detaliedCar.Year = int.Parse(textBox5.Text);
            Form1.detaliedCar.Combustibil = textBox6.Text;
            Form1.detaliedCar.Km = int.Parse(textBox7.Text);

            this.Close();
        }
    }
}
