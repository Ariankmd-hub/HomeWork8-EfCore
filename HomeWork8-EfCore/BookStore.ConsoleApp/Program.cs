Console.WriteLine(
    "A bookstore system includes the following components:\n" +
    "\n- Users can register in the system." +
    "\n- Books are available in different categories." +
    "\n- Users can view available books." +
    "\n- Users can add books to their shopping cart." +
    "\n- Each cart can contain multiple cart items." +
    "\n- Each cart item represents a book and its requested quantity." +
    "\n- Users can place orders." +
    "\n- Each order can contain multiple order items." +
    "\n- Each order item represents a book, its quantity, and its purchase price."
);

Console.WriteLine("\nDomain Rules:");
Console.WriteLine("- Each user has personal information such as first name, last name, email, and phone number.");
Console.WriteLine("- Each book has a title, author, ISBN, description, price, and stock quantity.");
Console.WriteLine("- Each book belongs to exactly one category.");
Console.WriteLine("- Each category can contain multiple books.");
Console.WriteLine("- Each user can have a shopping cart.");
Console.WriteLine("- A shopping cart can contain multiple books.");
Console.WriteLine("- An order belongs to a user.");
Console.WriteLine("- An order contains multiple order items.");
Console.WriteLine("- OrderItem stores the book price at the time of purchase.");
Console.WriteLine("- All entities have an Id, CreatedAtUtc, and UpdatedAtUtc.");
