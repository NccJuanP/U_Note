using Microsoft.EntityFrameworkCore;
//using U_Note.Models;

namespace U_Note.Data{

    public class U_NoteContext : DbContext{
        public U_NoteContext(DbContextOptions<U_NoteContext> options) : base(options)
        {

        }
    }
}