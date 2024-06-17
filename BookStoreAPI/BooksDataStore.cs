using BookStoreAPI.DTOs;

namespace BookStoreAPI
{
    public class BooksDataStore
    {
        public List<BookDTO> Books { get; set; }

        public BooksDataStore() 
        {
            Books =
            [
                new() {
                    Id = Guid.NewGuid(),
                    ISBN = "978-0140449266",
                    Title = "The Odyssey",
                    Author = "Homer",
                    PublishDate = new DateTime(1996, 11, 29),
                    Pages = 560,
                    Publisher = "Penguin Classics"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0143127741",
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    PublishDate = new DateTime(2015, 7, 14),
                    Pages = 336,
                    Publisher = "Harper Perennial Modern Classics"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0743273565",
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    PublishDate = new DateTime(2004, 9, 30),
                    Pages = 180,
                    Publisher = "Scribner"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0140449105",
                    Title = "The Iliad",
                    Author = "Homer",
                    PublishDate = new DateTime(2003, 4, 29),
                    Pages = 704,
                    Publisher = "Penguin Classics"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0061120084",
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    PublishDate = new DateTime(2006, 10, 17),
                    Pages = 288,
                    Publisher = "Harper Perennial Modern Classics"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0451524935",
                    Title = "1984",
                    Author = "George Orwell",
                    PublishDate = new DateTime(1950, 7, 1),
                    Pages = 328,
                    Publisher = "Signet Classic"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0140186390",
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    PublishDate = new DateTime(1992, 11, 1),
                    Pages = 720,
                    Publisher = "Penguin Classics"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-1503290563",
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    PublishDate = new DateTime(2014, 11, 26),
                    Pages = 226,
                    Publisher = "CreateSpace Independent Publishing Platform"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0140449334",
                    Title = "The Aeneid",
                    Author = "Virgil",
                    PublishDate = new DateTime(2006, 11, 30),
                    Pages = 464,
                    Publisher = "Penguin Classics"
                },
                new(){
                    Id = Guid.NewGuid(),
                    ISBN = "978-0486415871",
                    Title = "Crime and Punishment",
                    Author = "Fyodor Dostoevsky",
                    PublishDate = new DateTime(2001, 1, 15),
                    Pages = 430,
                    Publisher = "Dover Publications"
                }
            ];
        }
    }
}
