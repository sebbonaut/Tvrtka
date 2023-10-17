using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvrtka1
{
    internal abstract class Osoba
    {
        public string ime, prezime;
        public abstract string Uloga {  get; }
        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        public Osoba() : this("John","Doe") { }
        public virtual void Info()
            => Console.WriteLine(ime + " " + prezime);
    }

    internal /* sealed */ class Zaposlenik : Osoba
    {
        public override string Uloga => "Zaposlenik";
        public string titula = "prof.";
        public /* sealed */ override void Info()
        {
            Console.Write(titula + " ");
            base.Info();
        }
        public Zaposlenik(string ime, string prezime,
            string titula) : base(ime, prezime)
                => this.titula = titula;
    }

    internal sealed class Honorarni : Zaposlenik
    {
        public decimal honorar = 1000;
        public override void Info()
        {
            Console.Write(honorar + "EUR ");
            base.Info();
        }
        public Honorarni(string ime, string prezime,
            string titula, decimal honorar)
            : base(ime, prezime, titula)
            => this.honorar = honorar;
    }

    internal class Student : Osoba
    {
        public override string Uloga => "Student";
        public string jmbag = "1234567890";
        public new void Info()
            => Console.WriteLine($"{jmbag} {ime} {prezime}");
    }
}
