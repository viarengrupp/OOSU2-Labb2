using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2___Affärslager
{
    class Personal
    {
        // Individuellt id för att unikt identifiera personal.
        private int personalID;

        // Inloggningsuppgifter.
        private string användarnamn;
        private string lösenord;

        // Personuppgifter och kontaktuppgifter.
        private string förnamn;
        private string efternamn;
        private string eMail;
        private int teleNr;

        // Listor med personalens skapade erbjudanden och aktiviteter.
        private List<Erbjudande> SkapadeErbjudanden = new List<Erbjudande>();
        private List<Aktivitet> SkapadeAktiviteter = new List<Aktivitet>();
    }
}
