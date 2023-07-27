using LINQ_Exercise_01.Models;
using System.Threading.Channels;

//#region GroupBy()

//// TODO: Given a list of students, group the students by grade and creatively display to the console.
//var students = new List<Student>()
//{
//    new Student(){ Grade = 'F',Age = 20, Name = "Tim Parson"},
//    new Student(){ Grade = 'B',Age = 32, Name = "Tom Simpson"},
//    new Student(){ Grade = 'A',Age = 23, Name = "Cory Smith"},
//    new Student(){ Grade = 'B',Age = 19, Name = "Dianna Thompson"},
//    new Student(){ Grade = 'C',Age = 18, Name = "Amanda Schwabek"},
//    new Student(){ Grade = 'A',Age = 27, Name = "Taylor Brown "},
//    new Student(){ Grade = 'A',Age = 21, Name = "Jimmy Humphreys"},
//    new Student(){ Grade = 'B',Age = 22, Name = "John McCormick"},
//    new Student(){ Grade = 'D',Age = 30, Name = "Alex Scott"},
//    new Student(){ Grade = 'C',Age = 25, Name = "Allison Maxwell"},
//    new Student(){ Grade = 'C',Age = 28, Name = "Nelson Smith"},

//};

//var orderedStudents = students.OrderBy(s => s.Grade);
//var groupedStudents = orderedStudents.GroupBy(x => x.Grade);

//foreach (var group in groupedStudents)
//{
//    Console.WriteLine($"Grade: {group.Key}");
//    foreach (var student in group)
//    {
//        Console.WriteLine($"Name: {student.Name}");
//    }
//    Console.WriteLine();
//}

//// TODO: Given a list of books, group the books by author and creatively display to the console.
//var books = new List<Book>()
//{
//    new Book() {Title = "Nineteen Eighty-Four", Author = "George Orwell", YearPublished = 1949},
//    new Book() {Title = "The Catcher in the Rye", Author = "J. D. Salinger", YearPublished = 1925},
//    new Book() {Title = "Do Androids Dream of Electric Sheep", Author = "Philip K. Dick", YearPublished = 1968},
//    new Book() {Title = "Fahrenheit 451", Author = "Ray Bradbury", YearPublished = 1953},
//    new Book() {Title = "Brave New World", Author = "Aldous Huxley", YearPublished = 1932},
//    new Book() {Title = "A Clockwork Orange", Author = "Anthony Burgess", YearPublished = 1962},
//    new Book() {Title = "The Children of Men", Author = "P.D. James", YearPublished = 1992},
//    new Book() {Title = "The Hunger Games", Author = "Suzanne Collins", YearPublished = 2008},
//    new Book() {Title = "Ready Player One", Author = "Ernest Cline", YearPublished = 2011},
//    new Book() {Title = "Animal Farm", Author = "George Orwell", YearPublished = 1946},
//    new Book() {Title = "The Gulag Archipelago", Author = "Aleksandr Solzhenitsyn", YearPublished = 1974},

//};

//var orderedBooks = books.OrderBy(book => book.YearPublished);
//var groupedBooks = orderedBooks.GroupBy(x => x.Author);

//foreach (var group in groupedBooks)
//{
//    Console.WriteLine($"{group.Key}");
//    Console.WriteLine("=================");
//    foreach (var book in group)
//    {
//        Console.WriteLine($"{book.Title}, {book.YearPublished}");
//    }
//    Console.WriteLine();
//}


//// TODO: Given a list of bank transactions, group the transactions by month and creatively display to the console.
//var transactions = new List<Transaction>()
//{
//    new Transaction() {Amount = 19.99M, TransactionDate = new DateTime(2000, 12, 31)},
//    new Transaction() {Amount = 29.47M, TransactionDate = new DateTime(2020, 2, 15)},
//    new Transaction() {Amount = 120.01M, TransactionDate = new DateTime(2010, 8, 28)},
//    new Transaction() {Amount = 9.99M, TransactionDate = new DateTime(2011, 1, 13)},
//    new Transaction() {Amount = 250.00M, TransactionDate = new DateTime(2015, 10, 1)},
//    new Transaction() {Amount = 1000.00M, TransactionDate = new DateTime(2017, 12, 31)},
//    new Transaction() {Amount = 450.00M, TransactionDate = new DateTime(2003, 1, 1)},
//    new Transaction() {Amount = 199.99M, TransactionDate = new DateTime(2000, 4, 24)},
//    new Transaction() {Amount = 1.99M, TransactionDate = new DateTime(2009, 8, 10)},
//    new Transaction() {Amount = 1.99M, TransactionDate = new DateTime(2007, 6, 11)},
//    new Transaction() {Amount = 49.99M, TransactionDate = new DateTime(2006, 10, 7)},
//    new Transaction() {Amount = 4.34M, TransactionDate = new DateTime(2020, 6, 30)},
//    new Transaction() {Amount = 149.99M, TransactionDate = new DateTime(2009, 5, 2)},
//    new Transaction() {Amount = 49.99M, TransactionDate = new DateTime(2007, 3, 25)},
//    new Transaction() {Amount = 9.99M, TransactionDate = new DateTime(2000, 11, 17)}
//};

//var orderedTransactions = transactions.OrderBy(x => x.TransactionDate.Year);
//var groupedTransactions = orderedTransactions.GroupBy(x => x.TransactionDate.Year);

//foreach (var group in groupedTransactions)
//{
//    Console.WriteLine($"Year {group.Key}");
//    foreach (var transaction in group)
//    {
//        Console.WriteLine($"Amount: {transaction.Amount}");
//    }
//    Console.WriteLine();
//}


//// TODO: Given a list of orders, group the orders by their status and creatively display to the console.
//var orders = new List<Order>()
//{
//    new Order() {OrderID = 103, CustomerID = 100831, Status = "Pending"},
//    new Order() {OrderID = 199, CustomerID = 100831, Status = "Completed"},
//    new Order() {OrderID = 123, CustomerID = 100378, Status = "Completed"},
//    new Order() {OrderID = 122, CustomerID = 100701, Status = "Completed"},
//    new Order() {OrderID = 145, CustomerID = 100131, Status = "Declined"},
//    new Order() {OrderID = 176, CustomerID = 100121, Status = "Completed"},
//    new Order() {OrderID = 109, CustomerID = 100241, Status = "Declined"},
//    new Order() {OrderID = 102, CustomerID = 100651, Status = "Pending"},
//    new Order() {OrderID = 138, CustomerID = 100931, Status = "Pending"},
//    new Order() {OrderID = 186, CustomerID = 100871, Status = "Completed"},
//};

//var orderedOrders = orders.OrderBy(o => o.OrderID);
//var groupedOrders = orderedOrders.GroupBy(x => x.Status);

//foreach (var group in groupedOrders)
//{
//    Console.WriteLine($"Status: {group.Key}");
//    foreach (var order in group)
//    {
//        Console.WriteLine($"OrderID: {order.OrderID}");
//    }
//    Console.WriteLine();
//}

//#endregion

#region Select()

// TODO: Given a list of integers, use Select() to transform them into squares and creatively display to the console.
var numbers = new List<int>()
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10
};

numbers.Select(x => Math.Pow(x, 2)).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine();

// TODO: Given a list of strings, transform them into strings that are in uppercase and creatively display to the console.
var strings = new List<string>()
{
    "aaa",
    "bbb",
    "ccc",
    "ddd",
    "eee",
    "fff",
    "ggg",
    "hhh"
};
strings.Select(x => x.ToUpper()).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine();

// TODO: Given a list of strings, each with Name, Age, and Grades,
//       transform them into Students and creatively display to the console.
var students2 = new List<string>()
{
    "C, 33, Amos Crist",
    "C, 22, Edwin Waelchi",
    "A, 23, Wm Fay",
    "A, 19, Veronica Lind",
    "C, 54, Brandi Luettgen",
    "A, 68, Bryan O'Hara",
    "B, 46, Chelsea Schowalter",
    "A, 22, Glen Graham",
    "C, 46, Alex Scott",
    "B, 57, Andrea Nitzsche",
    "C, 26, Cristina Parisian"
};

var splitStudents = new List<string[]>();

foreach (var item in students2)
{
    splitStudents.Add(item.Split(','));
}

splitStudents.Select(x => new Student
{
    Grade = char.Parse(x[0]),
    Age = int.Parse(x[1]),
    Name = x[2]
}).OrderBy(x => x.Grade).ToList().ForEach(x => Console.WriteLine($"{x.Name.Trim()}\n---------------\nGrade: {x.Grade}\nAge: {x.Age}\n\n"));

Console.WriteLine();


// TODO: Given a list of tuples, transform them into coordinates and creatively display to the console.
var stringCoordinates = new List<Tuple<double, double, string>>
{
    Tuple.Create(33.8688, 151.2093, "Syndey"),
    Tuple.Create(51.5072, 0.1276, "London"),
    Tuple.Create(40.7128, 74.0060, "New York"),
    Tuple.Create(30.0444, 31.2357, "Cairo"),
    Tuple.Create(48.8566, 2.3522, "Paris"),
    Tuple.Create(39.9042, 116.4074, "Beijing"),
    Tuple.Create(35.6762, 139.6503, "Tokyo")
};

stringCoordinates.Select(x => new Coordinate
{
    Latitude = x.Item1,
    Longitude = x.Item2,
    Name = x.Item3
}).ToList().ForEach(x => Console.WriteLine($"Name: {x.Name}\nLatitude: {x.Latitude}\nLongitude: {x.Longitude}\n"));


#endregion