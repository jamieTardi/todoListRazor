using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todoListRazor.Models;

namespace todoListRazor.Pages.TodoList
{
    public class EditTodoModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditTodoModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Todo Todo { get; set; }
        public async Task OnGet(int id)
        {
            Todo = await _db.Todo.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {

            var TodoFromDb = await _db.Todo.FindAsync(Todo.Id);
            TodoFromDb.TodoItem = Todo.TodoItem;

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
      
    }
}
