using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>(); // cream o noua lista pentru cosul de cumparaturi
        BindingSource itemsBinding = new BindingSource(); // cream noua legatura pentru iteme
        BindingSource cartBinding = new BindingSource(); // legatura iteme din cos
        BindingSource vendorsBindig = new BindingSource(); // idem vendors
        private decimal storeProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); // initializam DataSource a noii legaturi cu lista de iteme din magazin // UPDATE afisarea itemelor unde sold = false
            itemsListBox.DataSource = itemsBinding; //  initializam DataSource a itemsListBox ului cu noua legatura formata

            itemsListBox.DisplayMember = "Display"; 
            itemsListBox.ValueMember = "Display"; // Dupa ce am creat o noua metoda Display a obiectului Item afisam in itemsListBox(form) datele itemelor stocate in itemsBinding

            cartBinding.DataSource = shoppingCartData; // repetam procesul si pentru lista cosului de cumparaturi
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBindig.DataSource = store.Vendors; // repetam procesul si pentru lista cosului de cumparaturi
            vendorListBox.DataSource = vendorsBindig;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";

        }
       
        
        public void SetupData()
        {
            // Populam lista de iteme
            // DummyData

            store.Vendors.Add(new Vendor { FirstName = "Mihai", LastName = "Vancea" });
            store.Vendors.Add(new Vendor { FirstName = "Diana", LastName = "Petrescu", Commission = .4 });
            store.Vendors.Add(new Vendor { FirstName = "George", LastName = "Dinu", Commission = .3 });

            store.Items.Add(new Item { Title = "Lambo", Description = "Masina rapida", Price = 40000.40M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Harley Davidson", Description = "Motor pt roakeri", Price = 4000.00M, Owner = store.Vendors[2] });
            store.Items.Add(new Item { Title = "Mustang", Description = "Masina frumoasa", Price = 55000.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Tesla", Description = "Masina inteligenta", Price = 66000.60M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Dacie", Description = "Masina frumoasa", Price = 1000M, Owner = store.Vendors[0] });

            store.Name = "Beauties";


        }

        private void AddToCart_Click(object sender, EventArgs e)  // metoda eventului click al butonului Add To Cart
        {
            // Apelarea elementului selectat din lista de iteme
            // Copierea lui in shopping cart
            // Eliminarea lui din lista magazinului

            Item SelectedItem = (Item)itemsListBox.SelectedItem; // in variabila SelectedItem salvam singurul element selectat

            shoppingCartData.Add(SelectedItem); // adaugam elementul selectat in cos

            cartBinding.ResetBindings(false); // daca am schimba complet tipul listei cum ar fi din items in vendors ar trebui scris true in rest mereu false
        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            // Marcheaza fiecare item ca sold
            // Salvarea datelor intr un fisier text
            // Clear the cart

            foreach (Item item in shoppingCartData) // pentru fiecare item din cos
            {
                item.Sold = true; // marcheaza ca vandut
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price; // calculeaza plata proprietarului
                storeProfit += (1-(decimal)item.Owner.Commission) * item.Price; // calucleaza profitul magazinului
            }


            shoppingCartData.Clear(); // clear the cart

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); // reactualizarea listei cu itemele din magazin unde sold == false

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBindig.ResetBindings(false);
        }
    }
}
