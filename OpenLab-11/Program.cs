{
    static void Main(string[] args)
        {
            Book Lotr = new Book();
            Book Lotr2 = new Book();
            Book Lotr3 = new Book("Janko Kral", 352);
            Book HOBIT = new Book("Janko Kral", 352, "Mária Ďuríčková", 2004);
            Lotr.Title = "Janko Kral";
            Lotr.Pages = 352;
            Lotr.Category = "Romantic";
            Lotr.Autor = "Marina";
            Lotr.ReleaseDate = 2004;
            Lotr.WriteParameters();
        }
    }
