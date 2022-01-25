
    class Library
{
     public int numberOfStudents;
    public int Book_Number = 0;

    public void NumberOfStudents()
    {
        numberOfStudents = StudentsList.Length;
    }
    public string[] StudentsList { get; set; } = new string[2] { "", "" };

    public string[] BooksList = new string[4] { "", "", "", "" };

    public string[] BorrowList = new string[4] { "", "", "", "" };

    public string Borrowedby;

    public string Borrowedbook;

    public void borrow(string borrowedbook, string borrowedby)
    {

        Borrowedby = borrowedby;
        Borrowedbook = borrowedbook;
        BorrowList[Book_Number] = borrowedbook + " borrowed by " + borrowedby;
        BooksList[Book_Number] = borrowedbook;
        Book_Number++;
    }

    public void writeall()
    {
        Console.WriteLine("Amount of students: " + numberOfStudents);

        Console.WriteLine("Amount of books: " + Book_Number);

        Console.WriteLine("Students: ");
        foreach (string s in StudentsList) { Console.WriteLine(s); }

        Console.WriteLine("Books: ");
        foreach (string s in BooksList) { Console.WriteLine(s); }

        Console.WriteLine("Borowed: ");
        foreach (string s in BorrowList) { Console.WriteLine(s); }

    }


}
