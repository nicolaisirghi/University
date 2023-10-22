using System;
using System.Text.RegularExpressions;
using static Student.Utils;

namespace Student
{
    class Program
    {
        class Student
        {
            private string nume;

            private string prenume;

            private int anulNasterii;

            private decimal idnp;

            private string specialitate;

            private Facultate facultate;

            private string grupa;

            private YearOfStudy anDeStudiu;

            private float medie;

            private bool buget;

            private string adresa;

            private string numarTelefon;

            private string email;

            public Student(string nume, string prenume, int anulNasterii, decimal idnp, string specialitate,
                Facultate facultate, string grupa, YearOfStudy anDeStudiu, float medie, bool buget, string adresa,
                string numarTelefon,
                string email)
            {
                Nume = nume;
                Prenume = prenume;
                AnulNasterii = anulNasterii;
                IDNP = idnp;
                Specialitate = specialitate;
                Facultate = facultate;
                Grupa = grupa;
                YearOfStudy = anDeStudiu;
                Medie = medie;
                Buget = buget;
                Adresa = adresa;
                NumarTelefon = numarTelefon;
                Email = email;
            }

            public string Nume
            {
                get { return nume; }

                set
                {
                    if (IsValidName(value))
                    {
                        nume = value;
                    }
                    else
                    {
                        throw new Exception("Numele nu este valid");
                    }
                }
            }


            public string Prenume
            {
                get { return prenume; }
                set
                {
                    if (IsValidName(value))
                    {
                        prenume = value;
                    }
                    else
                    {
                        throw new Exception("Prenumele nu este valid");
                    }
                }
            }

            public int AnulNasterii
            {
                get { return anulNasterii; }
                set
                {
                    if (value < 1950 || value > 2010)
                    {
                        throw new Exception("Anul nasterii nu este valid");
                    }

                    anulNasterii = value;
                }
            }

            public decimal IDNP
            {
                get { return idnp; }
                set
                {
                    string _value = value.ToString();

                    if (_value.Length != 13)
                    {
                        throw new Exception("IDNP-ul nu are lungimea corecta");
                    }

                    foreach (char digit in _value)
                    {
                        if (!char.IsDigit(digit))
                        {
                            throw new Exception("IDNP-ul conține caractere nevalide. Trebuie să conțină doar cifre.");
                        }
                    }

                    idnp = value;
                }
            }

            public string Specialitate
            {
                get { return specialitate; }
                set
                {
                    if (String.IsNullOrEmpty(value) || Regex.IsMatch(value, "\\d"))
                        throw new Exception("Specialitatea nu este valida");

                    specialitate = value;
                }
            }

            public Facultate Facultate
            {
                get { return facultate; }
                set { facultate = value; }
            }

            public string Grupa
            {
                get { return grupa; }
                set
                {
                    if (isValidGrupe(value))
                    {
                        grupa = value;
                    }
                    else
                    {
                        throw new Exception("Grupa nu este valida");
                    }
                }
            }

            public YearOfStudy YearOfStudy
            {
                get { return anDeStudiu; }
                set { anDeStudiu = value; }
            }

            public float Medie
            {
                get { return medie; }
                set
                {
                    if (value < 1 || value > 10)
                    {
                        throw new Exception("Media nu este valida");
                    }

                    medie = value;
                }
            }

            public bool Buget
            {
                get { return buget; }
                set { buget = value; }
            }

            public string Adresa
            {
                get { return adresa; }
                set
                {
                    if (isValidAdress(value))
                    {
                        adresa = value;
                    }
                    else
                    {
                        throw new Exception("Adresa este invalida !");
                    }
                }
            }

            public string NumarTelefon
            {
                get { return numarTelefon; }
                set
                {
                    if (IsValidPhone(value))
                    {
                        numarTelefon = value;
                    }
                    else
                    {
                        throw new Exception("Numarul de telefon nu este valid !");
                    }
                }
            }

            public string Email
            {
                get { return email; }
                set
                {
                    if (IsValidEmail(value))
                    {
                        email = value;
                    }
                    else
                    {
                        throw new Exception("Email-ul nu este valid !");
                    }
                }
            }

            public override string ToString()
            {
                return
                    $"Nume: {Nume}\n" +
                    $"Prenume: {Prenume}\n" +
                    $"Anul Nasterii: {AnulNasterii}\n" +
                    $"IDNP: {IDNP}\n" +
                    $"Specialitate: {Specialitate}\n" +
                    $"Facultate: {Facultate}\n" +
                    $"Grupa: {Grupa}\n" +
                    $"Anul de studii: {YearOfStudy}\n" +
                    $"Medie: {Medie}\n" +
                    $"Buget: {Buget}\n" +
                    $"Adresa: {Adresa}\n" +
                    $"Numar Telefon: {NumarTelefon}\n" +
                    $"Email: {Email}";
            }
        }


        public static void Main(string[] args)
        {
            Student student = new Student("Sirghi", "Nicolae", 2001, 2016036001537, "Informatica Aplicata",
                Facultate.FMI, "MI2301", YearOfStudy.FourthYear,
                8.78F, false, "Soseaua Hancesti 55/4", "069290603", "nicolai.sirghi@gmail.com");
            Console.WriteLine(student);
        }
    }
}