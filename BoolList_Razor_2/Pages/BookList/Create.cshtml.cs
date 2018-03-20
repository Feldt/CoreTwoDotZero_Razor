using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoolList_Razor_2.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoolList_Razor_2.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private AplicationDBContext _db;
        public CreateModel(AplicationDBContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book book { get; set; }
        [TempData]
        public String Message { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            Message = "Book Created Successfuly";
            return RedirectToPage("Index");

        }

    }
}