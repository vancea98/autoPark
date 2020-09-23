namespace CarUserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelNume = new System.Windows.Forms.Label();
            this.buttonX = new System.Windows.Forms.Button();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPageHome = new MetroFramework.Controls.MetroTabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.itemsFound = new System.Windows.Forms.Label();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.tabPageShop = new MetroFramework.Controls.MetroTabPage();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVendors = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.tabPageAbout = new MetroFramework.Controls.MetroTabPage();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelTitle.Controls.Add(this.labelNume);
            this.panelTitle.Controls.Add(this.buttonX);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(571, 54);
            this.panelTitle.TabIndex = 0;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.Teal;
            this.labelNume.Location = new System.Drawing.Point(12, 9);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(247, 39);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "C# AutoParkUI";
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonX.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.Color.Teal;
            this.buttonX.Location = new System.Drawing.Point(514, 0);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(57, 54);
            this.buttonX.TabIndex = 0;
            this.buttonX.Text = "X";
            this.buttonX.UseMnemonic = false;
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHome);
            this.tabControl.Controls.Add(this.tabPageShop);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl.Location = new System.Drawing.Point(0, 51);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(571, 358);
            this.tabControl.TabIndex = 1;
            this.tabControl.UseSelectable = true;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.buttonLoad);
            this.tabPageHome.Controls.Add(this.label4);
            this.tabPageHome.Controls.Add(this.itemsFound);
            this.tabPageHome.Controls.Add(this.buttonMoreDetails);
            this.tabPageHome.Controls.Add(this.buttonAddToCart);
            this.tabPageHome.Controls.Add(this.listBoxCars);
            this.tabPageHome.Controls.Add(this.buttonAdd);
            this.tabPageHome.Controls.Add(this.buttonSearch);
            this.tabPageHome.Controls.Add(this.textBox_Marca);
            this.tabPageHome.Controls.Add(this.textBox_Model);
            this.tabPageHome.Controls.Add(this.textBox_Id);
            this.tabPageHome.Controls.Add(this.labelMarca);
            this.tabPageHome.Controls.Add(this.labelModel);
            this.tabPageHome.Controls.Add(this.labelId);
            this.tabPageHome.HorizontalScrollbarBarColor = true;
            this.tabPageHome.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageHome.HorizontalScrollbarSize = 10;
            this.tabPageHome.Location = new System.Drawing.Point(4, 38);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(563, 316);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.VerticalScrollbarBarColor = true;
            this.tabPageHome.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageHome.VerticalScrollbarSize = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Items Found";
            // 
            // itemsFound
            // 
            this.itemsFound.AutoSize = true;
            this.itemsFound.Location = new System.Drawing.Point(85, 252);
            this.itemsFound.Name = "itemsFound";
            this.itemsFound.Size = new System.Drawing.Size(13, 13);
            this.itemsFound.TabIndex = 25;
            this.itemsFound.Text = "0";
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.Location = new System.Drawing.Point(256, 279);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(133, 34);
            this.buttonMoreDetails.TabIndex = 24;
            this.buttonMoreDetails.Text = "MORE DETAILS";
            this.buttonMoreDetails.UseVisualStyleBackColor = true;
            this.buttonMoreDetails.Click += new System.EventHandler(this.ButtonMoreDetails_Click);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(427, 279);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(133, 34);
            this.buttonAddToCart.TabIndex = 22;
            this.buttonAddToCart.Text = "ADD TO CART";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.ButtonAddToCart_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 21;
            this.listBoxCars.Location = new System.Drawing.Point(256, 9);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(298, 256);
            this.listBoxCars.TabIndex = 21;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(222, 34);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "ADD A CAR";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(64, 184);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(173, 39);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(64, 158);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(173, 20);
            this.textBox_Marca.TabIndex = 12;
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(64, 126);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(173, 20);
            this.textBox_Model.TabIndex = 13;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(64, 92);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(173, 20);
            this.textBox_Id.TabIndex = 14;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(5, 157);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(53, 21);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(5, 123);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(54, 21);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Model";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(5, 91);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 21);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id";
            // 
            // tabPageShop
            // 
            this.tabPageShop.Controls.Add(this.storeProfitValue);
            this.tabPageShop.Controls.Add(this.label3);
            this.tabPageShop.Controls.Add(this.buttonPurchase);
            this.tabPageShop.Controls.Add(this.label2);
            this.tabPageShop.Controls.Add(this.label1);
            this.tabPageShop.Controls.Add(this.listBoxVendors);
            this.tabPageShop.Controls.Add(this.listBoxCart);
            this.tabPageShop.HorizontalScrollbarBarColor = true;
            this.tabPageShop.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageShop.HorizontalScrollbarSize = 10;
            this.tabPageShop.Location = new System.Drawing.Point(4, 38);
            this.tabPageShop.Name = "tabPageShop";
            this.tabPageShop.Size = new System.Drawing.Size(563, 316);
            this.tabPageShop.TabIndex = 1;
            this.tabPageShop.Text = "Shopping Cart";
            this.tabPageShop.VerticalScrollbarBarColor = true;
            this.tabPageShop.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageShop.VerticalScrollbarSize = 10;
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Location = new System.Drawing.Point(457, 244);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(34, 13);
            this.storeProfitValue.TabIndex = 28;
            this.storeProfitValue.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "StoreProfit :";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(38, 236);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(190, 29);
            this.buttonPurchase.TabIndex = 26;
            this.buttonPurchase.Text = "PURCHASE";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.ButtonPurchase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "VENDORS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "SHOPPING CART";
            // 
            // listBoxVendors
            // 
            this.listBoxVendors.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVendors.FormattingEnabled = true;
            this.listBoxVendors.ItemHeight = 21;
            this.listBoxVendors.Location = new System.Drawing.Point(307, 50);
            this.listBoxVendors.Name = "listBoxVendors";
            this.listBoxVendors.Size = new System.Drawing.Size(247, 130);
            this.listBoxVendors.TabIndex = 23;
            // 
            // listBoxCart
            // 
            this.listBoxCart.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 21;
            this.listBoxCart.Location = new System.Drawing.Point(8, 50);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(247, 130);
            this.listBoxCart.TabIndex = 22;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.HorizontalScrollbarBarColor = true;
            this.tabPageAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageAbout.HorizontalScrollbarSize = 10;
            this.tabPageAbout.Location = new System.Drawing.Point(4, 38);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(563, 316);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseCustomForeColor = true;
            this.tabPageAbout.VerticalScrollbarBarColor = true;
            this.tabPageAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageAbout.VerticalScrollbarSize = 10;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(64, 274);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(133, 34);
            this.buttonLoad.TabIndex = 27;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 409);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageShop.ResumeLayout(false);
            this.tabPageShop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonX;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabPageHome;
        private MetroFramework.Controls.MetroTabPage tabPageShop;
        private MetroFramework.Controls.MetroTabPage tabPageAbout;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVendors;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label itemsFound;
        public System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button buttonLoad;
    }
}

