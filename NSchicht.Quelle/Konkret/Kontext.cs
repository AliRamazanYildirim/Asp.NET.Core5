using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NSchicht.Core.Konkret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Quelle.Konkret
{
    public class Kontext: IdentityDbContext<IdentityBenutzer,BenutzerRolle,int>
    {
        public DbSet<Über> Übers { get; set; }
        public DbSet<Dienst> Dienste { get; set; }
        public DbSet<Eigenschaft> Eigenschaften { get; set; }
        public DbSet<Erfahrung> Erfahrungen { get; set; }
        public DbSet<Faehigkeit> Faehigkeiten { get; set; }
        public DbSet<Kontakt> Kontakte { get; set; }
        public DbSet<Nachricht> Nachrichten { get; set; }
        public DbSet<Aktenmappe> Aktenmappen { get; set; }
        public DbSet<Referenz> Referenze { get; set; }
        public DbSet<SozialerKontakt> SozialeKontakte { get; set; }
        public DbSet<Benutzer> Benutzers { get; set; }
        public DbSet<BenutzerNachricht> BenutzerNachrichten { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<BenutzerRolle> BenutzerRollen { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=THINKPAD;Initial Catalog=SuperMappe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
