using System.Windows.Forms;

namespace HamPizza
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.btnDailySpecial = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkPepper = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoNonVeg = new System.Windows.Forms.RadioButton();
            this.rdoVeg = new System.Windows.Forms.RadioButton();
            this.tbxCoupon = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblShowQuantity = new System.Windows.Forms.Label();
            this.lblVeg = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSeeOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(530, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAM PIZZA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.chkHam);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.btnStartOver);
            this.panel1.Controls.Add(this.btnDailySpecial);
            this.panel1.Controls.Add(this.btnDecrease);
            this.panel1.Controls.Add(this.btnIncrease);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkMushroom);
            this.panel1.Controls.Add(this.chkPepperoni);
            this.panel1.Controls.Add(this.chkPepper);
            this.panel1.Controls.Add(this.chkOlive);
            this.panel1.Controls.Add(this.chkOnion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rdoNonVeg);
            this.panel1.Controls.Add(this.rdoVeg);
            this.panel1.Controls.Add(this.tbxCoupon);
            this.panel1.Controls.Add(this.tbxPhone);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 567);
            this.panel1.TabIndex = 1;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkHam.ForeColor = System.Drawing.Color.Firebrick;
            this.chkHam.Location = new System.Drawing.Point(133, 290);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(65, 25);
            this.chkHam.TabIndex = 10;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlaceOrder.Location = new System.Drawing.Point(405, 500);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(160, 51);
            this.btnPlaceOrder.TabIndex = 18;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.BackColor = System.Drawing.Color.Firebrick;
            this.btnStartOver.FlatAppearance.BorderSize = 0;
            this.btnStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOver.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnStartOver.ForeColor = System.Drawing.Color.Transparent;
            this.btnStartOver.Location = new System.Drawing.Point(215, 500);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(160, 51);
            this.btnStartOver.TabIndex = 17;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = false;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // btnDailySpecial
            // 
            this.btnDailySpecial.BackColor = System.Drawing.Color.Firebrick;
            this.btnDailySpecial.FlatAppearance.BorderSize = 0;
            this.btnDailySpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySpecial.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDailySpecial.ForeColor = System.Drawing.Color.Transparent;
            this.btnDailySpecial.Location = new System.Drawing.Point(19, 500);
            this.btnDailySpecial.Name = "btnDailySpecial";
            this.btnDailySpecial.Size = new System.Drawing.Size(160, 51);
            this.btnDailySpecial.TabIndex = 16;
            this.btnDailySpecial.Text = "Daily Special";
            this.btnDailySpecial.UseVisualStyleBackColor = false;
            this.btnDailySpecial.Click += new System.EventHandler(this.btnDailySpecial_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.Firebrick;
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDecrease.ForeColor = System.Drawing.Color.Transparent;
            this.btnDecrease.Location = new System.Drawing.Point(526, 375);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(37, 34);
            this.btnDecrease.TabIndex = 14;
            this.btnDecrease.Text = "▼";
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.Firebrick;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnIncrease.ForeColor = System.Drawing.Color.Transparent;
            this.btnIncrease.Location = new System.Drawing.Point(526, 335);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(37, 34);
            this.btnIncrease.TabIndex = 13;
            this.btnIncrease.Text = "▲";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuantity.Location = new System.Drawing.Point(308, 344);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(33, 37);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "1";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.DarkRed;
            this.label31.Location = new System.Drawing.Point(19, 436);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(126, 25);
            this.label31.TabIndex = 16;
            this.label31.Text = "Coupon Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(19, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantity";
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkMushroom.ForeColor = System.Drawing.Color.Firebrick;
            this.chkMushroom.Location = new System.Drawing.Point(405, 290);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(119, 25);
            this.chkMushroom.TabIndex = 12;
            this.chkMushroom.Text = "Mushrooms";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkPepperoni.ForeColor = System.Drawing.Color.Firebrick;
            this.chkPepperoni.Location = new System.Drawing.Point(256, 290);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(108, 25);
            this.chkPepperoni.TabIndex = 11;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkPepper
            // 
            this.chkPepper.AutoSize = true;
            this.chkPepper.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkPepper.ForeColor = System.Drawing.Color.Firebrick;
            this.chkPepper.Location = new System.Drawing.Point(405, 252);
            this.chkPepper.Name = "chkPepper";
            this.chkPepper.Size = new System.Drawing.Size(90, 25);
            this.chkPepper.TabIndex = 9;
            this.chkPepper.Text = "Peppers";
            this.chkPepper.UseVisualStyleBackColor = true;
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkOlive.ForeColor = System.Drawing.Color.Firebrick;
            this.chkOlive.Location = new System.Drawing.Point(256, 252);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(76, 25);
            this.chkOlive.TabIndex = 8;
            this.chkOlive.Text = "Olives";
            this.chkOlive.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkOnion.ForeColor = System.Drawing.Color.Firebrick;
            this.chkOnion.Location = new System.Drawing.Point(133, 252);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(83, 25);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Text = "Onions";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(19, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Toppings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.AllowDrop = true;
            this.cboSize.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "small",
            "medium",
            "large",
            "extra-large"});
            this.cboSize.Location = new System.Drawing.Point(124, 189);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(439, 31);
            this.cboSize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vegeterian";
            // 
            // rdoNonVeg
            // 
            this.rdoNonVeg.AutoSize = true;
            this.rdoNonVeg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rdoNonVeg.ForeColor = System.Drawing.Color.Firebrick;
            this.rdoNonVeg.Location = new System.Drawing.Point(380, 134);
            this.rdoNonVeg.Name = "rdoNonVeg";
            this.rdoNonVeg.Size = new System.Drawing.Size(96, 25);
            this.rdoNonVeg.TabIndex = 5;
            this.rdoNonVeg.TabStop = true;
            this.rdoNonVeg.Text = "Non-Veg";
            this.rdoNonVeg.UseVisualStyleBackColor = true;
            // 
            // rdoVeg
            // 
            this.rdoVeg.AutoSize = true;
            this.rdoVeg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rdoVeg.ForeColor = System.Drawing.Color.Firebrick;
            this.rdoVeg.Location = new System.Drawing.Point(186, 134);
            this.rdoVeg.Name = "rdoVeg";
            this.rdoVeg.Size = new System.Drawing.Size(57, 25);
            this.rdoVeg.TabIndex = 4;
            this.rdoVeg.TabStop = true;
            this.rdoVeg.Text = "Veg";
            this.rdoVeg.UseVisualStyleBackColor = true;
            // 
            // tbxCoupon
            // 
            this.tbxCoupon.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbxCoupon.Location = new System.Drawing.Point(177, 429);
            this.tbxCoupon.Name = "tbxCoupon";
            this.tbxCoupon.Size = new System.Drawing.Size(388, 34);
            this.tbxCoupon.TabIndex = 15;
            this.tbxCoupon.Enter += new System.EventHandler(this.tbxCoupon_Enter);
            this.tbxCoupon.Leave += new System.EventHandler(this.tbxCoupon_Leave);
            // 
            // tbxPhone
            // 
            this.tbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhone.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbxPhone.Location = new System.Drawing.Point(124, 70);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(439, 34);
            this.tbxPhone.TabIndex = 3;
            this.tbxPhone.Enter += new System.EventHandler(this.tbxPhone_Enter);
            this.tbxPhone.Leave += new System.EventHandler(this.tbxPhone_Leave);
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbxName.Location = new System.Drawing.Point(124, 20);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(439, 34);
            this.tbxName.TabIndex = 2;
            this.tbxName.Enter += new System.EventHandler(this.tbxName_Enter);
            this.tbxName.Leave += new System.EventHandler(this.tbxName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.pnTotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblExtra);
            this.panel2.Controls.Add(this.lblToppings);
            this.panel2.Controls.Add(this.lblShowQuantity);
            this.panel2.Controls.Add(this.lblVeg);
            this.panel2.Controls.Add(this.lblSize);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.lblOrderNumber);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(623, 75);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(603, 567);
            this.panel2.TabIndex = 2;
            // 
            // pnTotal
            // 
            this.pnTotal.Controls.Add(this.label20);
            this.pnTotal.Controls.Add(this.label11);
            this.pnTotal.Controls.Add(this.lblTax);
            this.pnTotal.Controls.Add(this.lblDiscount);
            this.pnTotal.Controls.Add(this.lblTotal);
            this.pnTotal.Controls.Add(this.label13);
            this.pnTotal.Controls.Add(this.label12);
            this.pnTotal.Controls.Add(this.label21);
            this.pnTotal.Controls.Add(this.lblSubTotal);
            this.pnTotal.Controls.Add(this.lblCoupon);
            this.pnTotal.Location = new System.Drawing.Point(30, 285);
            this.pnTotal.Margin = new System.Windows.Forms.Padding(0);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(560, 147);
            this.pnTotal.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(19, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 19);
            this.label20.TabIndex = 12;
            this.label20.Text = "Subtotal";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(6, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(532, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTax.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTax.Location = new System.Drawing.Point(433, 76);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 19);
            this.lblTax.TabIndex = 13;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDiscount.Location = new System.Drawing.Point(433, 51);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(0, 19);
            this.lblDiscount.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Location = new System.Drawing.Point(433, 117);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(532, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(20, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.DarkRed;
            this.label21.Location = new System.Drawing.Point(19, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 19);
            this.label21.TabIndex = 12;
            this.label21.Text = "Tax";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSubTotal.Location = new System.Drawing.Point(433, 21);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 19);
            this.lblSubTotal.TabIndex = 13;
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCoupon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCoupon.Location = new System.Drawing.Point(19, 51);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(66, 19);
            this.lblCoupon.TabIndex = 12;
            this.lblCoupon.Text = "Discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(36, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(531, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblExtra.ForeColor = System.Drawing.Color.DarkRed;
            this.lblExtra.Location = new System.Drawing.Point(458, 243);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(0, 20);
            this.lblExtra.TabIndex = 20;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblToppings.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToppings.Location = new System.Drawing.Point(296, 243);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(0, 20);
            this.lblToppings.TabIndex = 19;
            // 
            // lblShowQuantity
            // 
            this.lblShowQuantity.AutoSize = true;
            this.lblShowQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblShowQuantity.ForeColor = System.Drawing.Color.DarkRed;
            this.lblShowQuantity.Location = new System.Drawing.Point(458, 213);
            this.lblShowQuantity.Name = "lblShowQuantity";
            this.lblShowQuantity.Size = new System.Drawing.Size(0, 20);
            this.lblShowQuantity.TabIndex = 18;
            // 
            // lblVeg
            // 
            this.lblVeg.AutoSize = true;
            this.lblVeg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVeg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblVeg.Location = new System.Drawing.Point(458, 183);
            this.lblVeg.Name = "lblVeg";
            this.lblVeg.Size = new System.Drawing.Size(0, 21);
            this.lblVeg.TabIndex = 17;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSize.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSize.Location = new System.Drawing.Point(458, 153);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 20);
            this.lblSize.TabIndex = 16;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPhone.Location = new System.Drawing.Point(458, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 20);
            this.lblPhone.TabIndex = 15;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrderNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOrderNumber.Location = new System.Drawing.Point(458, 40);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(0, 20);
            this.lblOrderNumber.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(458, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(48, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Toppings";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(48, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(48, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Veg / Non-Veg";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(48, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(48, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(48, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Order Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(48, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(274, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Receipt";
            // 
            // btnSeeOrders
            // 
            this.btnSeeOrders.BackColor = System.Drawing.Color.Firebrick;
            this.btnSeeOrders.FlatAppearance.BorderSize = 0;
            this.btnSeeOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeOrders.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnSeeOrders.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeeOrders.Location = new System.Drawing.Point(1055, 14);
            this.btnSeeOrders.Name = "btnSeeOrders";
            this.btnSeeOrders.Size = new System.Drawing.Size(160, 51);
            this.btnSeeOrders.TabIndex = 19;
            this.btnSeeOrders.Text = "See Orders";
            this.btnSeeOrders.UseVisualStyleBackColor = false;
            this.btnSeeOrders.Click += new System.EventHandler(this.btnSeeOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HamPizza.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(466, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1235, 654);
            this.Controls.Add(this.btnSeeOrders);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.Text = "Ham Pizza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private CheckBox chkMushroom;
        private CheckBox chkPepperoni;
        private CheckBox chkPepper;
        private CheckBox chkOlive;
        private CheckBox chkOnion;
        private Label label6;
        private Label label5;
        private ComboBox cboSize;
        private Label label4;
        private RadioButton rdoNonVeg;
        private RadioButton rdoVeg;
        private TextBox tbxPhone;
        private TextBox tbxName;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label7;
        private Button btnPlaceOrder;
        private Button btnStartOver;
        private Button btnDailySpecial;
        private Label lblQuantity;
        private Button btnDecrease;
        private Button btnIncrease;
        private CheckBox chkHam;
        private Label lblSubTotal;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label15;
        private Label lblTotal;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label lblToppings;
        private Label lblShowQuantity;
        private Label lblVeg;
        private Label lblSize;
        private Label lblPhone;
        private Label lblName;
        private Label lblDiscount;
        private Label lblCoupon;
        private Label label31;
        private TextBox tbxCoupon;
        private Label lblOrderNumber;
        private Label label8;
        private PictureBox pictureBox1;
        private Label lblExtra;
        private Label label10;
        private Label label13;
        private Panel pnTotal;
        private Label lblTax;
        private Label label21;
        private Button btnSeeOrders;
    }
}

