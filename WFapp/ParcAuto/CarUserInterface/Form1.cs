using CarModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CarUserInterface
{
    public partial class Form1 : Form
    {
        public static AutoPark autoPark = new AutoPark();
        private List<Car> shoppingCartData = new List<Car>(); // cream o noua lista pentru cosul de cumparaturi
        BindingSource carsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource(); // legatura iteme din cos
        BindingSource vendorsBindig = new BindingSource(); // idem vendors
        decimal storeProfit = 0;
        public static Car detaliedCar;

        public Form1()
        {
            InitializeComponent();
            SetupDummyData();

            carsBinding.DataSource = autoPark.Cars.Where(x => x.Sold == false).ToList();
            listBoxCars.DataSource = carsBinding;

            listBoxCars.DisplayMember = "Display";
            listBoxCars.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            listBoxCart.DataSource = cartBinding;

            listBoxCart.DisplayMember = "Display";
            listBoxCart.ValueMember = "Display";

            vendorsBindig.DataSource = autoPark.Vendors; // repetam procesul si pentru lista cosului de cumparaturi
            listBoxVendors.DataSource = vendorsBindig;

            listBoxVendors.DisplayMember = "Display";
            listBoxVendors.ValueMember = "Display";

        }

        private void SetupDummyData()
        {
            autoPark.Vendors.Add(new Vendor { FirstName = "Vancea", LastName = "Mihai", Commission = .6 });
            autoPark.Vendors.Add(new Vendor { FirstName = "Petrescu", LastName = "Diana" });
            autoPark.Vendors.Add(new Vendor { FirstName = "Busa", LastName = "Mihaitz", Commission = .4 });


            autoPark.Cars.Add(new Car {
                Id = 1111,
                Manufacturer = "Manufacturer_1",
                Model = "Model_1", Price = 10000M,
                Owner = autoPark.Vendors[0],
                Combustibil = "Benzina",
                Km = 11111,
                Year = 2000,
                Status = true,
                Pictures = new List<Picture>()
                {
                    new Picture()
                    {
                        Name = "Picture1",
                        FilePath = @"C:\Users\mihai\OneDrive\Desktop\CV\WFapp\ParcAuto\Pictures\1111\Picture1.jpg"
                    }
                    
                }
            });
            autoPark.Cars.Add(new Car { Id = 1112, Manufacturer = "Manufacturer_2", Model = "Model_2", Price = 12000M, Owner = autoPark.Vendors[1], Combustibil = "Motorina", Km = 22222, Year = 2010, Status = true,
                Pictures = new List<Picture>()
                {
                    new Picture()
                    {
                        Name = "Picture1",
                        FilePath = @"C:\Users\mihai\OneDrive\Desktop\CV\WFapp\ParcAuto\Pictures\1112\Picture1.jpg"
                    }

                }
            });
            autoPark.Cars.Add(new Car { Id = 1113, Manufacturer = "Manufacturer_3", Model = "Model_3", Price = 13000M, Owner = autoPark.Vendors[0], Km = 33333, Year = 1998, Status = false,
                Pictures = new List<Picture>()
                {
                    new Picture()
                    {
                        Name = "Picture1",
                        FilePath = @"C:\Users\mihai\OneDrive\Desktop\CV\WFapp\ParcAuto\Pictures\1113\Picture1.jpg"
                    }

                }
            });
            autoPark.Cars.Add(new Car { Id = 1114, Manufacturer = "Manufacturer_4", Model = "Model_4", Price = 14000M, Owner = autoPark.Vendors[2], Combustibil = "Benzina", Year = 2005, Status = false,
                Pictures = new List<Picture>()
                {
                    new Picture()
                    {
                        Name = "Picture1",
                        FilePath = @"C:\Users\mihai\OneDrive\Desktop\CV\WFapp\ParcAuto\Pictures\1114\Picture1.jpg"
                    }

                }
            });
            autoPark.Name = "Beauties";
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (FormAdd formAdd = new FormAdd() { carInfo = new Car() })
            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                    autoPark.Cars.Add(formAdd.carInfo);
            }
            
            



        }

        private void ButtonMoreDetails_Click(object sender, EventArgs e)
        {
            Car SelectedItem = (Car)listBoxCars.SelectedItem;

            detaliedCar = SelectedItem;

            FormDetails formDetails = new FormDetails();
            formDetails.ShowDialog();
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            // Apelarea elementului selectat din lista de iteme
            // Copierea lui in shopping cart
            // Eliminarea lui din lista magazinului

            Car SelectedItem = (Car)listBoxCars.SelectedItem; // in variabila SelectedItem salvam singurul element selectat

            shoppingCartData.Add(SelectedItem); // adaugam elementul selectat in cos

            cartBinding.ResetBindings(false);
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            // Marcheaza fiecare item ca sold
            // Salvarea datelor intr un fisier text
            // Clear the cart

            foreach (Car car in shoppingCartData) // pentru fiecare item din cos
            {
                car.Sold = true; // marcheaza ca vandut
                car.Owner.PaymentDue += (decimal)car.Owner.Commission * car.Price; // calculeaza plata proprietarului
                storeProfit += (1 - (decimal)car.Owner.Commission) * car.Price; // calucleaza profitul magazinului
            }


            shoppingCartData.Clear(); // clear the cart

            carsBinding.DataSource = autoPark.Cars.Where(x => x.Sold == false).ToList(); // reactualizarea listei cu itemele din magazin unde sold == false

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            carsBinding.ResetBindings(false);
            vendorsBindig.ResetBindings(false);

            
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            //listBoxCars.SelectedItems.Clear();
            //for (int i = listBoxCars.Items.Count - 1; i >=0 ; i--)
            //{
            //    if (listBoxCars.Items[i].ToString().ToLower().Contains(textBox_Id.Text.ToString().ToLower()))
            //        listBoxCars.SetSelected(i, true);
            //}
            listBoxCars.SelectedIndex = listBoxCars.FindString(textBox_Id.Text.ToString());
            itemsFound.Text = listBoxCars.SelectedItems.Count.ToString();
   
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\mihai\OneDrive\Desktop\CV\WFapp\ParcAuto\Data");
            FileInfo[] files = directoryInfo.GetFiles("*.json");
            string str = "";
            foreach (FileInfo file in files)
            {
                str = file.FullName;
                
                Car c1 = JsonConvert.DeserializeObject<Car>(File.ReadAllText(str));
                file.Delete();
                autoPark.Cars.Add(c1);
            }

            //Car c1 = JsonConvert.DeserializeObject<Car>(File.ReadAllText(@"C:\Users\mihai\Desktop\TemaPOO\ParcAuto\Data\1116.json"));
            //autoPark.Cars.Add(c1);
            carsBinding.DataSource = autoPark.Cars.Where(x => x.Sold == false).ToList();
            listBoxCars.DataSource = carsBinding;
            carsBinding.ResetBindings(false);


        }
    }
}
