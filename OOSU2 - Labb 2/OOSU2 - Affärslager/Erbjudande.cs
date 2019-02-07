using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2___Affärslager
{
    class Erbjudande
    {
        // Information om erbjudandet.
        private string title;
        private string bio;

        // När erbjudandet startar och slutar.
        private DateTime startTid;
        private DateTime slutTid;

        // Lista med anmälda Alumner som ska delta eller är intresserade av erbjudandet.
        private List<Alumner> AnmäldaAlumner = new List<Alumner>();
    }
}
