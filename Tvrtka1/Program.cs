using Tvrtka1;

Osoba a; // = new Osoba();
Zaposlenik b = new Zaposlenik("a","b","p");
//Console.WriteLine(b.ime);
Student c = new Student();
//Ispis((Student)a);

Student s = new()
{
    ime = "Bob",
    prezime = "Lee"
};
Osoba m = s;
//Zaposlenik z = (Zaposlenik)m;
//Zaposlenik? z = m as Zaposlenik;
//z?.Info();
if (m is Zaposlenik e)
{
    e.Info();
}
//else
//    Console.WriteLine("Nista od konverzije!");

//s.Info();
//m.Info();
m = b;
//m.Info();
Honorarni h = new Honorarni("Anne","Windsor","dr.",1000);
//h.Info();
IspisSvih(s, m, h, b);
static void IspisSvih(params Osoba[] a)
{
    foreach (Osoba o in a)
        o.Info();
}
//Osoba a1; // = new Osoba("Edgar","Poe");
//Zaposlenik a2 = new Zaposlenik("Edgar","Poe","prof.");

static void IspisUloge(Osoba a)
{
    Console.WriteLine(a.Uloga);
}

IspisUloge(h);