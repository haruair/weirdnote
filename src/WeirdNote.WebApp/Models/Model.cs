using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace WeirdNote.WebApp.Models
{
    public class NoteContext : DbContext
    {
      public DbSet<Note> Notes { get; set; }
    }

    public class Note
    {
      public int NoteId { get; set; }
      public string Content { get; set; }
    }
}
