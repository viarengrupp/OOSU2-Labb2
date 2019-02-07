using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2___Affärslager
{
    class Alumner
    {
        // Personligt id för att kunna identifiera en alumn.
        private int alumnerID;

        // Inloggningsuppgifer.
        private string användarnamn;
        private string lösenord;

        // Vanlig information om Alumnern.
        private string förnamn;
        private string efternamn;
        private string eMail;
        private int ålder;
        private int teleNr;

        // Vilket program som Alumnern läste på.
        private string program;

        // När Alumnern påbörjade sina studier och när den avslutade dem.
        private DateTime startDatum;
        private DateTime slutDatum;

        // Listor på vilka aktiviteter och erbjudanden Alumnern har anmällt sig till.
        private List<Aktivitet> AnmäldaAktiviteter = new List<Aktivitet>();
        private List<Erbjudande> AnmäldaErbjudande = new List<Erbjudande>();
    }
}
