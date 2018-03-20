using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoolList_Razor_2.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoolList_Razor_2.Pages.BookList
{
    public class EditModel : PageModel
    {

        private AplicationDBContext _db;
        public EditModel(AplicationDBContext db)
        {
            _db = db;
        }

        [TempData]
        public String Message { get; set; }

        [BindProperty]
        public Book book { get; set; }

        public void OnGet(int id)
        {
            book = _db.Books.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookInDb = _db.Books.Find(book.Id);
                bookInDb.ISBN = book.ISBN;
                bookInDb.Title = book.Title;
                bookInDb.Author = book.Author;
                bookInDb.Price = book.Price;
                bookInDb.Avaibility = book.Avaibility;

                await _db.SaveChangesAsync();
                Message = "Book Updated Successfuly";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}