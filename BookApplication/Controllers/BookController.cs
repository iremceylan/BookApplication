using BookApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System; // Add this line for DateTime
using System.Collections.Generic; // Add this line for List<T>

namespace BookApplication.Controllers
{
    public class BookController : Controller
    {
        // GET: Book/DisplayBooks
        public IActionResult DisplayBooks()
        {
            
            var books = new List<Book>
            {
                new Book
                {
                    Name = "İnce Memed",
                    Author = "Yaşar Kemal",
                    PageNumber = 200,
                    DueDate = DateTime.Now.AddDays(30),
                    IsHomeworkUploaded = true
                },
                new Book
                {
                    Name = "Ateşten Gömlek",
                    Author = "Halide Edip Adıvar",
                    PageNumber = 250,
                    DueDate = DateTime.Now.AddDays(10),
                    IsHomeworkUploaded = false
                },

                new Book
                {
                    Name = "Example Book",
                    Author = "John Doe",
                    PageNumber = 150,
                    DueDate = DateTime.Now.AddDays(5), // Due in 5 days
                    IsHomeworkUploaded = false
                 },
                new Book
                {
                    Name = "Yüzyıllık Yalnızlık",
                    Author = "Gabriel Garcia Marquez",
                    PageNumber = 300,
                    DueDate = DateTime.Now.AddDays(3),
                    IsHomeworkUploaded = true
                }
            };

            return View("DisplayBooks", books);
        }
    }
}
