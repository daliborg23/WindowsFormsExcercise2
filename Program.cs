using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsExcercise2 {
    public class Program {
        public double cislo;
        [STAThread]
        static void Main(string[] args) {
            string vstup;
            Console.WriteLine("Zadej pocet vterin:\n[1-1000]");
            vstup = Console.ReadLine();
            if (Int32.TryParse(vstup, out int vysledek) && vysledek > 0) {
                MessageBox.Show("OK.\nZadano: " + vstup); // + odpocet k 0, - pocitani k 0
                Formular formular = new Formular();
                formular.odpocet = vysledek;
                formular.odpocetOriginal = vysledek;
                formular.cas = vysledek * 10;
                formular.ShowDialog();
            } else {
                MessageBox.Show("Chyba, neciselny udaj\nnebo zaporne cislo!\nZadano: " + vstup);
            }
        }
    }
}
