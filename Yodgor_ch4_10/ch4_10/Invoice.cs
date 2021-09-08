namespace ch4_10
{
    public class Invoice
    {
        public string partDescription { get; set; }
        public string PNumber { get; set; }
        private int quantityPurchased;
        private decimal pricePItem;
        

        public Invoice(string PARTNumber, string PARTDescription, int QuantityPurchased, decimal PRICEperItem)
        {
            PNumber = PARTNumber;
            partDescription = PARTDescription;
            QPurchased = QuantityPurchased;
            PriceperItem = PRICEperItem;
        }
        
        public int QPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                if (value > 0 && value != 0 && value > -1)
                {
                    quantityPurchased = value;

                }
                //setting default value for quantity
                else
                {
                    quantityPurchased = 1;
                }
            }
        }
        public decimal PriceperItem
        {
            get
            {
                return pricePItem;
            }
            set
            {
                if (value > 0 )
                {
                    pricePItem = value;
                }
                //setting default value for price
                else
                {
                    pricePItem = 1;
                }
            }
        }

        public decimal GetInvoiceAmount()
        {
            return QPurchased * PriceperItem;
             
        }
    }
    
}