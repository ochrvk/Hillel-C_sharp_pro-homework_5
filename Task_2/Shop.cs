namespace Task_2
{
    public class Shop : IDisposable
    {
        private bool disposed = false;

        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        public Shop()
        {
            Name = "";
            Address = "";
            Type = ShopType.Default;
        }

        public void Open()
        {
            Console.WriteLine($"Shop '{Name}' is now open at {Address}");
        }

        public void Close()
        {
            Console.WriteLine($"Shop '{Name}' is now closed.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"Disposing resources for shop '{Name}'.");
            }
            disposed = true;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAdress: {Address}\nType: {Type}";
        }
    }
}
