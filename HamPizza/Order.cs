using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamPizza
{
    public class Order
    {
        Random random = new Random();
        public int OrderNumber { get { return ordernumber; } }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Veg { get; set; }

        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Toppings { get; set; }

        public string CouponCode { get; set; }

        public double Subtotal { get { return subTotal; } }
        public double Discount { get { return discount; } }
        public double Tax { get { return tax; } }
        public double Total { get { return total; } }

        private double subTotal = 0;
        private double discount = 0;
        private double tax = 0;
        private double total = 0;
        private int ordernumber = 0;

        const double NONVEGSMALLEXTRA = 1;
        const double NONVEGLARGEEXTRA = 2;
        const double NONVEGXLARGEEXTRA = 1.01;
        const double EXTRATOPPING = 0.33;
        const double TAXRATE = 0.13;
        const double DISCOUNTRATE = 0.1;

        public Order()
        {
            ordernumber = random.Next(1, 1000);
            Name = "unknown";
            Phone = "unknown";
            Veg = "Non-Veg";
            Size = "Medium";
            Quantity = 1;
            Toppings = "";
            CouponCode = "";
        }

        public Order(string name, string phone, string veg, string size, int quantity, string toppings, string couponCode = "")
        {

            this.Name = name;
            this.Phone = phone;
            this.Veg = veg;
            this.Size = size;
            this.Quantity = quantity;
            this.Toppings = toppings;
            this.CouponCode = couponCode;
        }

        public void CalulateCost()
        {

            switch (Size)
            {
                case "Small":
                    subTotal = 5.99;
                    break;
                case "Medium":
                    subTotal = 7.99;
                    break;
                case "Large":
                    subTotal = 10.99;
                    break;
                case "ExtraLarge":
                    subTotal = 13.99;
                    break;
            }

            if (Veg == "Non-Veg")
            {
                if (Size == "Small" || Size == "Medium")
                    subTotal += NONVEGSMALLEXTRA;
                else if (Size == "Large")
                    subTotal += NONVEGLARGEEXTRA;
                else
                    subTotal += NONVEGXLARGEEXTRA;
            }


            subTotal += EXTRATOPPING * (Toppings.Split(',').Length - 1);
            if (Toppings.Length >= 1)
            {
                Toppings = Toppings.Remove(Toppings.Length - 2, 1);
            }

            subTotal = Math.Round(subTotal * Quantity, 2);
            if (CouponCode == "OFFERSPECIAL")
            {
                discount = Math.Round(subTotal * DISCOUNTRATE, 2);
            }

            tax = Math.Round((subTotal - discount) * TAXRATE, 2);
            total = Math.Round(subTotal - discount + tax, 2);
        }

        public override string ToString()
        {
            return $"Order Number : {this.OrderNumber} \nName : {this.Name}\nPhone : {this.Phone} \nVeg : {this.Veg}\nSize : {this.Size} " +
                $"\nQuantity : {this.Quantity}\nToppings : {this.Toppings} \nCoupon code : {this.CouponCode}" +
                $"\nSubtotal : {this.Subtotal:c} \nDiscount : {this.Discount:c} \nTax : {this.Tax:c} \nTotal : {this.Total:c}";
        }
    }
}
