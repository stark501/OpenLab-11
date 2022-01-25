namespace OpenLab10._04
{
        class Book
        {
            /// <summary>
            /// created list with categories.
            /// </summary>/

            public static List<string> categoryList = new List<string>
            {"detské", "romantické", "náučné", "sci-fi", "dobrodružné"};


            private string title
            { get; set; }
            private int pages;
            public int Pages
            {
                get
                {
                    return pages;
                }
                set
                {
                    if (value < 0)
                    {
                        pages = 1;
                    }
                    else
                    {
                        pages = value;
                    }
                }
            }
            private string Category
            { get; set; }
            private string Autor
            { get; set; }
            private int releaseDate;
            public int ReleaseDate
            {
                get
                {
                    return releaseDate;
                }
                set
                {
                    if (value < 1450 && value > 2021)
                    {
                        releaseDate = -1;
                    }
                    else
                    {
                        releaseDate = value;
                    }
                }
            }
            public Book()
            {
                Title = "-1";
                Pages = -1;
                Category = "-1";
                Autor = "-1";
                ReleaseDate = -1;
            }

            Book(string title, int pages)
            {
                this.Title = title;
                this.Pages = pages;
                Autor = "-1";
                Category = "-1";
                ReleaseDate = -1;
            }

            public Book(string title, int pages, string category, string author, int releaseDate)
            {
                this.Title = title;
                this.Pages = pages;
                this.Category = category;
                this.Autor = Autor;
                this.ReleaseDate = releaseDate;
            }
            public void WriteParameters()
            {
                Console.WriteLine(title);
                Console.WriteLine(pages);
                Console.WriteLine(Category);
                Console.WriteLine(Autor);
                Console.WriteLine(releaseDate);
            }

        }

    }