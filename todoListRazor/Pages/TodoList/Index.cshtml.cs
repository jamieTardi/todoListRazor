using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using todoListRazor.Models;

namespace todoListRazor.Pages.TodoList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //Looping over the todos
        public IEnumerable<Todo> Todos { get; set; }
        public async Task OnGet()
        {
            Todos = await _db.Todo.ToListAsync();
        }
    }
}
