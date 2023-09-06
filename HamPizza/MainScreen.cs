using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamPizza
{
    public partial class MainScreen : Form
    {
        public enum Size
        {
            Small, Medium, Large, ExtraLarge
        }

        public static List<Order> OrderList;


        bool filled = false;
        string orders = "";
        public MainScreen()
        {
            OrderList = new List<Order>();
            InitializeComponent();

            this.rdoNonVeg.Checked = true;
            this.cboSize.DataSource = Enum.GetNames(typeof(Size));
            this.cboSize.SelectedIndex = 1;
            this.btnPlaceOrder.Enabled = false;

        }

        private void btnDailySpecial_Click(object sender, EventArgs e)
        {
            this.cboSize.SelectedIndex = 2;
            this.lblQuantity.Text = "2";
            this.rdoNonVeg.Checked = true;
            this.tbxCoupon.Text = "OFFERSPECIAL";
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.tbxName.Text = "";
            this.tbxPhone.Text = "";

            this.rdoNonVeg.Checked = true;

            this.cboSize.SelectedIndex = 1;

            this.chkOnion.Checked = false;
            this.chkOlive.Checked = false;
            this.chkPepper.Checked = false;
            this.chkHam.Checked = false;
            this.chkPepperoni.Checked = false;
            this.chkMushroom.Checked = false;

            this.lblQuantity.Text = "1";

            this.tbxCoupon.Text = "";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            if (filled)
            {
                Order order = new Order();
                this.lblOrderNumber.Text = String.Format("#{0:000}", order.OrderNumber);

                this.lblName.Text = this.tbxName.Text;
                order.Name = this.tbxName.Text;

                this.lblPhone.Text = this.tbxPhone.Text;
                order.Phone = this.tbxPhone.Text;

                if (this.rdoVeg.Checked == true)
                {
                    this.lblVeg.Text = this.rdoVeg.Text;
                    order.Veg = this.rdoVeg.Text;
                }
                else
                {
                    this.lblVeg.Text = this.rdoNonVeg.Text;
                    order.Veg = this.rdoNonVeg.Text;
                }

                this.lblSize.Text = this.cboSize.SelectedItem.ToString();
                order.Size = this.lblSize.Text;

                this.lblToppings.Text = "";
                this.lblExtra.Text = "";
                int chkCnt = 0;

                this.pnTotal.Location = new Point(30, 285);
                int x = this.pnTotal.Location.X;
                int y = this.pnTotal.Location.Y;

                if (this.chkOnion.Checked == true)
                {
                    this.lblToppings.Text += this.chkOnion.Text + "\n";
                    this.lblExtra.Text += "$0.33" + "\n";
                    order.Toppings += this.chkOnion.Text + ", ";
                    chkCnt++;
                }


                if (this.chkOlive.Checked == true)
                {
                    this.lblToppings.Text += this.chkOlive.Text + "\n";
                    this.lblExtra.Text += "$0.33" + "\n";
                    order.Toppings += this.chkOlive.Text + ", ";
                    chkCnt++;
                }


                if (this.chkPepper.Checked == true)
                {
                    this.lblToppings.Text += this.chkPepper.Text + "\n";
                    this.lblExtra.Text += "$0.33" + "\n";
                    order.Toppings += this.chkPepper.Text + ", ";
                    chkCnt++;
                }


                if (this.chkHam.Checked == true)
                {
                    this.lblToppings.Text += this.chkHam.Text + "\n";
                    this.lblExtra.Text += "$0.33" + "\n";
                    order.Toppings += this.chkHam.Text + ", ";
                    chkCnt++;
                }


                if (this.chkPepperoni.Checked == true)
                {
                    this.lblToppings.Text += this.chkPepperoni.Text + "\n";
                    this.lblExtra.Text += "$0.33" + "\n";
                    order.Toppings += this.chkPepperoni.Text + ", ";
                    chkCnt++;
                }


                if (this.chkMushroom.Checked == true)
                {
                    this.lblToppings.Text += this.chkMushroom.Text + "\n";
                    this.lblExtra.Text += "$0.33" + "\n";
                    order.Toppings += this.chkMushroom.Text + ", ";
                    chkCnt++;
                }

                if (chkCnt > 2)
                {
                    y += (chkCnt - 2) * 33;
                }

                this.lblCoupon.Text = "Discount";

                if (this.tbxCoupon.Text.ToUpper() == "OFFERSPECIAL")
                {
                    order.CouponCode = this.tbxCoupon.Text;
                    this.lblCoupon.Text += $"\t ( Coupon code : {this.tbxCoupon.Text} )";
                }


                this.pnTotal.Location = new Point(x, y);
                this.lblShowQuantity.Text = this.lblQuantity.Text;
                order.Quantity = Convert.ToInt32(this.lblQuantity.Text);
                order.CalulateCost();
                this.lblSubTotal.Text = String.Format("${0:00.00}", order.Subtotal);
                this.lblDiscount.Text = String.Format("${0:00.00}", order.Discount);
                this.lblTax.Text = String.Format("${0:00.00}", order.Tax);
                this.lblTotal.Text = String.Format("${0:00.00}", order.Total);
                OrderList.Add(order);
                MessageBox.Show("Order Successful");
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(this.lblQuantity.Text);
            if (quantity < 5)
            {
                quantity++;
                this.lblQuantity.Text = quantity.ToString();
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(this.lblQuantity.Text);
            if (quantity > 1)
            {
                quantity--;
                this.lblQuantity.Text = quantity.ToString();
            }
        }

        private void tbxName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tbxName.Text))
            {
                this.tbxName.BackColor = Color.MistyRose;
                this.tbxName.Text = "Please enter your name.";
                this.tbxName.ForeColor = Color.Red;
            }
            else
            {
                this.tbxName.BackColor = Color.White;
                this.tbxName.ForeColor = Color.Black;
            }

            if ((this.tbxName.ForeColor == Color.Black) && (this.tbxPhone.ForeColor == Color.Black))
            {
                filled = true;
                this.btnPlaceOrder.Enabled = true;
            }
            else
            {
                filled = false;
                this.btnPlaceOrder.Enabled = false;
            }
        }

        private void tbxPhone_Leave(object sender, EventArgs e)
        {
            long phone = 0;
            if (String.IsNullOrEmpty(this.tbxPhone.Text))
            {
                this.tbxPhone.BackColor = Color.MistyRose;
                this.tbxPhone.Text = "Please enter your phone number.";
                this.tbxPhone.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    phone = (long)Convert.ToInt64(this.tbxPhone.Text);
                    if (this.tbxPhone.Text.Length != 10)
                    {
                        throw new InvalidDigitsException();

                    }

                }
                catch (InvalidDigitsException idex)
                {
                    this.tbxPhone.Text = idex.Message;
                    this.tbxPhone.ForeColor = Color.Red;
                    this.tbxPhone.BackColor = Color.MistyRose;
                }
                catch (Exception ex)
                {
                    this.tbxPhone.Text = "The phone number should be number.";
                    this.tbxPhone.BackColor = Color.MistyRose;
                    this.tbxPhone.ForeColor = Color.Red;
                }


            }


            if ((this.tbxName.ForeColor == Color.Black) && (this.tbxPhone.ForeColor == Color.Black))
            {
                filled = true;
                this.btnPlaceOrder.Enabled = true;
            }
            else
            {
                filled = false;
                this.btnPlaceOrder.Enabled = false;
            }
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            this.tbxName.Text = "";
        }

        private void tbxPhone_Enter(object sender, EventArgs e)
        {
            this.tbxPhone.Text = "";
            this.tbxPhone.BackColor = Color.White;
            this.tbxPhone.ForeColor = Color.Black;
        }

        private void tbxCoupon_Enter(object sender, EventArgs e)
        {
            this.tbxCoupon.Text = "";
            this.tbxCoupon.ForeColor = Color.Black;
            this.tbxCoupon.BackColor = Color.White;
        }

        private void btnSeeOrders_Click(object sender, EventArgs e)
        {
            SeeOrders seeOrders = new SeeOrders();
            seeOrders.ShowDialog();
        }

        private void tbxCoupon_Leave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(this.tbxCoupon.Text)) && (this.tbxCoupon.Text.ToUpper() != "OFFERSPECIAL"))
            {
                this.tbxCoupon.Text = "Invalid Discount Code";
                this.tbxCoupon.ForeColor = Color.Red;
                this.tbxCoupon.BackColor = Color.MistyRose;
            }
        }
    }
    class InvalidDigitsException : Exception
    {
        public override string Message => "Phone Number should be 10 digits.";

    }
}
