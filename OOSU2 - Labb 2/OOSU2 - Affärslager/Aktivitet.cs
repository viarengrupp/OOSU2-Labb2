using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2___Affärslager
{
    class Aktivitet
    {
        // Unikt id.
        private int aktivitetID;

        // Information om aktiviteten.
        private string title;
        private string bio;

        // När aktiviteten startar och slutar.
        private DateTime startTid;
        private DateTime slutTid;

        // Lista med anmälda Alumner som ska delta eller är intresserade av aktiviteten.
        private List<Alumner> AnmäldaAlumner = new List<Alumner>();
    }
}
