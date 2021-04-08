namespace PackageTest
{
    public class TwoDayPackage : Packages
    {
        public string PackageType { get; set; }

        public int Qty { get; set; }

        private decimal cost;

        public TwoDayPackage(string sender, string addr, string tel, string recipient, string rAddr, string rTel, string packageType, int qty, decimal cost, decimal shippingCost) : base (sender, addr, tel, recipient, rAddr, rTel, shippingCost)
        {
            PackageType = packageType;
            Qty = qty;
            Cost = cost;
        }

        public decimal Cost
        {
            get{ return cost;}
            set{
                if (value > 0)
                {
                    cost = value;
                }
            }
        }

        public override decimal CalculateCost()
        {
            decimal total = Qty * Cost;
            return total;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nTotal Package Costs:\n{CalculateCost():C}";
        }
    }
}