namespace backend.Model
{
    public class Cart
    {
        private int _price;
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get { return _price + 5; } set { _price = value; } }

    }
}