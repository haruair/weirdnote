using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeirdNote.WebApp.Models
{
    public class NoteContext : DbContext
    {
      public DbSet<Note> Notes { get; set; }
    }

    public class Note
    {
      public int PostId { get; set; }
      public string Note { get; set; }
    }
}
