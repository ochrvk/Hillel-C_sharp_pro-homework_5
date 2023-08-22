using System.Xml.Linq;

namespace Task_3
{
    public class Piece : IDisposable
    {
        public Piece()
        {
            Title = "";
            Author = "";
            Genre = "";
            Year = 0;
        }

        private bool disposed = false;

        private int year;

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0 || value > 2023)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                else
                {
                    year = value;
                }
            }
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
                Console.WriteLine($"Disposing resources for Piece '{Title}'.");
            }
            disposed = true;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}\nYear: {Year}\n";
        }

        ~Piece()
        {
            Dispose(false);
        }
    }
}
