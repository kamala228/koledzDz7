using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koledzDz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zapiznenia, straf, meny, BazaniiDoxid, NapisanoKoda, zarabotal, res;
            double nyznoNapisatKoda, BazaniiDoxidVasi;
            Console.WriteLine("Меню ");
            Console.WriteLine("1-користувач вводить бажаний дохід Васі та кількість запізнень. Порахувати скільки рядків коду йому треба написати; ");
            Console.WriteLine("2-користувач вводить кількість рядків коду, написаних Васею, і бажаний обсяг зарплати. Порахувати скільки разів Вася може запізнитися; ");
            Console.WriteLine("3-користувач вводить кількість рядків коду і кількість запізнень. Визначити скільки грошей заплатять Васі та чи заплатять взагалі. ");
            meny = Convert.ToInt32(Console.ReadLine());
            if (meny == 1)
            {
                Console.Write("Ведіть бажаний донід Васі: ");
                BazaniiDoxidVasi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ведіть запізнення Васі: ");
                zapiznenia = Convert.ToInt32(Console.ReadLine());
                straf = (zapiznenia / 3) * 20;
                nyznoNapisatKoda = (BazaniiDoxidVasi + straf)/50*100;
                Console.WriteLine("Васі потрібно написати рядків коду: " + nyznoNapisatKoda);
            }
            else if (meny == 2)
            {
                Console.Write("Ведіть кількість рядків коду, написаних Васею: ");
                NapisanoKoda = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ведіть бажаний обсяг зарплати: ");
                BazaniiDoxid = Convert.ToInt32(Console.ReadLine());
                zarabotal = NapisanoKoda / 100 * 50;
                if (zarabotal > BazaniiDoxid)
                {
                    res = (zarabotal - BazaniiDoxid) / 20;
                    Console.WriteLine("Вася може запізнитися " + res + " разів");
                }
                else
                {
                    Console.WriteLine("Вася не може запізнитися ");
                }
            }                
            else if (meny == 3)
            {
                Console.Write("Ведіть кількість рядків коду, написаних Васею: ");
                NapisanoKoda = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ведіть кількість запізнень Васі: ");
                zapiznenia = Convert.ToInt32(Console.ReadLine());
                straf = (zapiznenia / 3) * 20;
                zarabotal = NapisanoKoda / 100 * 50;
                if (zarabotal>straf)
                {
                    res = zarabotal - straf;
                    Console.WriteLine("Васі заплатять: " + res);
                }
                else
                {
                    Console.WriteLine("Васі не заплатять");
                }
            }
            else
            {
                Console.WriteLine("Невірний вибір меню");
            }
        }
    }
}
