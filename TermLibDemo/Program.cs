using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Term;

namespace TermLibDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            //Inicializace zarizeni
            TermLib.Init(TermModel.Term57);
            //Nastaveni hlavniho formulare
            TermLib.WorkForm = new Form1();
            //Spusteni aplikace
            Application.Run(TermLib.WorkForm);
        }
    }
}