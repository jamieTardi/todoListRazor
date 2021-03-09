using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todoListRazor.Models;

namespace todoListRazor.Pages.TodoList
{
    public class CreateTodoModel : PageModel
    {
        //get private access tot he database
        private readonly ApplicationDbContext _db;

        //creater the constructor for the project
        public CreateTodoModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Todo Todo { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Todo todoObj)
        {
            try
            {
                await _db.Todo.AddAsync(Todo);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            catch
            {
                return Page();
            }
        }
    }
}
