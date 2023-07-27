using LINQ_Exercise_01.Models;

#region GroupBy()

// TODO: Given a list of students, group the students by grade and creatively display to the console.
var students = new List<Student>()
{
    new Student(){ Grade = 'F',Age = 20, Name = "Tim Parson"},
    new Student(){ Grade = 'B',Age = 32, Name = "Tom Simpson"},
    new Student(){ Grade = 'A',Age = 23, Name = "Cory Smith"},
    new Student(){ Grade = 'B',Age = 19, Name = "Dianna Thompson"},
    new Student(){ Grade = 'C',Age = 18, Name = "Amanda Schwabek"},
    new Student(){ Grade = 'A',Age = 27, Name = "Taylor Brown "},
    new Student(){ Grade = 'A',Age = 21, Name = "Jimmy Humphreys"},
    new Student(){ Grade = 'B',Age = 22, Name = "John McCormick"},
    new Student(){ Grade = 'D',Age = 30, Name = "Alex Scott"},
    new Student(){ Grade = 'C',Age = 25, Name = "Allison Maxwell"},
    new Student(){ Grade = 'C',Age = 28, Name = "Nelson Smith"},

};

// TODO: Given a list of books, group the books by author and creatively display to the console.
var books = new List<Book>()
{
    new Book() {Title = "Nineteen Eighty-Four", Author = "George Orwell", YearPublished = 1949},
    new Book() {Title = "The Catcher in the Rye", Author = "J. D. Salinger", YearPublished = 1925},
    new Book() {Title = "Do Androids Dream of Electric Sheep", Author = "Philip K. Dick", YearPublished = 1968},
    new Book() {Title = "Fahrenheit 451", Author = "Ray Bradbury", YearPublished = 1953},
    new Book() {Title = "Brave New World", Author = "Aldous Huxley", YearPublished = 1932},
    new Book() {Title = "A Clockwork Orange", Author = "Anthony Burgess", YearPublished = 1962},
    new Book() {Title = "The Children of Men", Author = "P.D. James", YearPublished = 1992},
    new Book() {Title = "The Hunger Games", Author = "Suzanne Collins", YearPublished = 2008},
    new Book() {Title = "Ready Player One", Author = "Ernest Cline", YearPublished = 2011},
    new Book() {Title = "Animal Farm", Author = "George Orwell", YearPublished = 1946},
    new Book() {Title = "The Gulag Archipelago", Author = "Aleksandr Solzhenitsyn", YearPublished = 1974},

};

// TODO: Given a list of bank transactions, group the transactions by month and creatively display to the console.
var transactions = new List<Transaction>()
{
    new Transaction() {Amount = 19.99M, TransactionDate = new DateTime(2000, 12, 31)},
    new Transaction() {Amount = 29.47M, TransactionDate = new DateTime(2020, 2, 15)},
    new Transaction() {Amount = 120.01M, TransactionDate = new DateTime(2010, 8, 28)},
    new Transaction() {Amount = 9.99M, TransactionDate = new DateTime(2011, 1, 13)},
    new Transaction() {Amount = 250.00M, TransactionDate = new DateTime(2015, 10, 1)},
    new Transaction() {Amount = 1000.00M, TransactionDate = new DateTime(2017, 12, 31)},
    new Transaction() {Amount = 450.00M, TransactionDate = new DateTime(2003, 1, 1)},
    new Transaction() {Amount = 199.99M, TransactionDate = new DateTime(2000, 4, 24)},
    new Transaction() {Amount = 1.99M, TransactionDate = new DateTime(2009, 8, 10)},
    new Transaction() {Amount = 1.99M, TransactionDate = new DateTime(2007, 6, 11)},
    new Transaction() {Amount = 49.99M, TransactionDate = new DateTime(2006, 10, 7)}
};

// TODO: Given a list of orders, group the orders by their status and creatively display to the console.
var orders = new List<Order>()
{
    new Order() {OrderID = 103, CustomerID = 100831, Status = "Pending"},
    new Order() {OrderID = 199, CustomerID = 100831, Status = "Completed"},
    new Order() {OrderID = 123, CustomerID = 100378, Status = "Completed"},
    new Order() {OrderID = 122, CustomerID = 100701, Status = "Completed"},
    new Order() {OrderID = 145, CustomerID = 100131, Status = "Declined"},
    new Order() {OrderID = 176, CustomerID = 100121, Status = "Completed"},
    new Order() {OrderID = 109, CustomerID = 100241, Status = "Declined"},
    new Order() {OrderID = 102, CustomerID = 100651, Status = "Pending"},
    new Order() {OrderID = 138, CustomerID = 100931, Status = "Pending"},
    new Order() {OrderID = 186, CustomerID = 100871, Status = "Completed"},
};

#endregion

#region Select()

// TODO: Given a list of strings, use Select to create a new list where all strings are in uppercase and creatively display to the console.
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

// TODO: Given a list of students, each with Name, Age, and Grade properties,
//       use Select to create a new list containing only the Name and Grade properties and creatively display to the console.
var students2 = new List<Student>()
{
    new Student(){ Grade = 'C',Age = 33, Name = "Amos Crist"},
    new Student(){ Grade = 'C',Age = 22, Name = "Edwin Waelchi"},
    new Student(){ Grade = 'A',Age = 23, Name = "Wm Fay"},
    new Student(){ Grade = 'C',Age = 19, Name = "Veronica Lind"},
    new Student(){ Grade = 'C',Age = 54, Name = "Brandi Luettgen"},
    new Student(){ Grade = 'A',Age = 68, Name = "Bryan O'Hara"},
    new Student(){ Grade = 'B',Age = 46, Name = "Chelsea Schowalter"},
    new Student(){ Grade = 'A',Age = 22, Name = "Glen Graham"},
    new Student(){ Grade = 'C',Age = 46, Name = "Alex Scott"},
    new Student(){ Grade = 'B',Age = 57, Name = "Andrea Nitzsche"},
    new Student(){ Grade = 'C',Age = 26, Name = "Cristina Parisian"},
};

// TODO: Given a list of strings, use Select to create a new list of coordinates and creatively display to the console.
var stringCoordinates = new List<string>()
{
    "10,2",
    "0,-1",
    "10,10",
    "1,0",
    "0,0",
    "-2, -4",
    "3, -6"
};

#endregion