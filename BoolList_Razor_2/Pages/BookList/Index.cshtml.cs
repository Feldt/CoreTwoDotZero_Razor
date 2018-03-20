using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoolList_Razor_2.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BoolList_Razor_2.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private AplicationDBContext _db;

        [TempData]
        public String Message { get; set; }

        public IndexModel(AplicationDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> books { get; set; }

        public async Task OnGet()
        {
            books = await _db.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = _db.Books.Find(id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            Message = "Book Deleted Succesfuly";
            return RedirectToPage();
        }
    }
}