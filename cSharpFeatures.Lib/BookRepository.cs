using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpFeatures.Lib
{
    public class BookRepository
    {
        Book[] Programming = new Book[]
    {
        new Book{Id=1,Title="C# .Net Core",Publisher="Prisma"},
        new Book{Id=2,Title="PHP7",Publisher="Microsoft Publishers"}
    };

        List<Book> Romans = new List<Book>()
    {
        new Book{Id=1,Title="De Terminator",Publisher="Schwarzie"},
        new Book{Id=2,Title="Rambo12",Publisher="Stallone"}
    };

}
}
