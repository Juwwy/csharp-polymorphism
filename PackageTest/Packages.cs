namespace PackageTest
{
    public abstract class Packages
    {
        public string Sender { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public string Recipient { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientTelephone { get; set; }
        private decimal shippingCost;
        public decimal ShippingCost
        {
            get { return shippingCost; }
            set { if(value > 0)
            shippingCost = value;
                 }
        }
        

        public Packages(string sender, string addr, string tel, string recipient, string rAddr, string rTel, decimal shippingCost)
        {
            Sender = sender;
            Address = addr;
            Telephone = tel;
            Recipient = recipient;
            RecipientAddress = rAddr;
            RecipientTelephone = rTel;
            ShippingCost = shippingCost;
        }

        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"Sender's information:\nName: {Sender}\nAddress: {Address}\nTelephone no.: {Telephone}\n\nRecipient's Information:\nName: {Recipient}\nAddress: {RecipientAddress}\nTelephone no.: {RecipientTelephone}\nShipping Cost: {ShippingCost:C}\n";
        }


    }
}