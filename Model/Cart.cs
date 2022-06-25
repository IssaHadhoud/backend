namespace backend.Model
{
    public class Cart
    {
        private int _price;
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get { return _price; } set { _price = value; } }

    }
}