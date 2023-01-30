using System.Globalization;

namespace FilesManipulation.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }
        public Product()
        {
        }
        public Product(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }
        public double Total()
        {
            return Value* Quantity;
        }
        public override string ToString()
        {
            return Name
                + ", "
                + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
