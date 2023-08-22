namespace Task_1
{
    public class Piece
    {
        public Piece()
        {
            Title = "";
            Author = "";
            Genre = "";
            Year = 0;
        }

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



        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}\nYear: {Year}\n";
        }

        ~Piece()
        {
            Console.WriteLine($"Piece object has been deleted.");
        }
    }
}
