using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todoListRazor.Models
{
    public class Todo
    {
        //This is the database key
        [Key]
        public int Id { get; set; }
        [Required]
        public string TodoItem { get; set; }

    }
}
