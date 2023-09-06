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
    public partial class SeeOrders : Form
    {
        public SeeOrders()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IEnumerable<Order> allOrders = MainScreen.OrderList.Select(order => order);

            this.gridOrders.DataSource = typeof(List<Order>);
            this.gridOrders.DataSource = allOrders.ToList();
        }

        private void btnLess20_Click(object sender, EventArgs e)
        {
            IEnumerable<Order> orders = MainScreen.OrderList.Where(order => order.Total < 20);

            this.gridOrders.DataSource = orders.ToList();
        }

        private void btnForJohn_Click(object sender, EventArgs e)
        {
            //method syntax
            IEnumerable<Order> orders = MainScreen.OrderList.Where(order => order.Name == "John");
            if (orders.Count() == 0)
            {
                MessageBox.Show("There are no orders for John.");
            }
            else
            {
                this.gridOrders.DataSource = orders.ToList();
            }
        }

        private void btnWithHam_Click(object sender, EventArgs e)
        {
            //query syntax
            IEnumerable<Order> orders = from order in MainScreen.OrderList where order.Toppings.Contains("Ham") select order;
            this.gridOrders.DataSource = orders.ToList();
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            var orders = from order in MainScreen.OrderList select order;
            this.gridOrders.DataSource = orders.ToList();
        }
    }
}
