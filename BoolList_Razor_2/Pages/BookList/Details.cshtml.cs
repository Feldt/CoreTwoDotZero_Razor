using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoolList_Razor_2.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoolList_Razor_2.Pages.BookList
{
    public class DetailsModel : PageModel
    {
        private AplicationDBContext _db;

        public DetailsModel(AplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book book { get; set; }

        public void OnGet(int id)
        {
            book = _db.Books.Find(id);
        }
    }
}