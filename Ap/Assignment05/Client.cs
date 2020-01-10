namespace Assignment05
{
    public abstract class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ReceiptDate { get; set; }

        public int Quantity { get; set; }

        public int Bill { get; set; }

        public Client(int id, string name, string receiptDate, int quantity)
        {
            Id = id;
            Name = name;
            ReceiptDate = receiptDate;
            Quantity = quantity;
        }

        public abstract void GetInfo();

        public abstract void CalculateBill();
    }
}