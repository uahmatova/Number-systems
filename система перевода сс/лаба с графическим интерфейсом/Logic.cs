using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace приложение
{
    public class Logic
    {
        public static int Summa(int first, int osn_first, int second,
            int osn_second, int ss_result)
        {
            int result = Logic.Perevod_v_10(first, osn_first)
                + Logic.Perevod_v_10(second, osn_second);
            return Logic.Perevod_from_10(result, ss_result);
        }

        public static int Raznost(int first, int osn_first, int second, int osn_second, int ss_result)
        {
            int result = Logic.Perevod_v_10(first, osn_first) - Logic.Perevod_v_10(second, osn_second);
            return Logic.Perevod_from_10(result, ss_result);
        }

        public static int Mult(int first, int osn_first, int second, int osn_second, int ss_result)
        {
            int result = Logic.Perevod_v_10(first, osn_first) * Logic.Perevod_v_10(second, osn_second);
            return Logic.Perevod_from_10(result, ss_result);
        }

        public static int Delenie(int first, int osn_first, int second, int osn_second, int ss_result)
        {
            int result = Logic.Perevod_v_10(first, osn_first) / Logic.Perevod_v_10(second, osn_second);
            return Logic.Perevod_from_10(result, ss_result);
        }

        public static string Sravnenie(int first, int osn_first,
            int second, int osn_second)
        {
            int f = Logic.Perevod_v_10(first, osn_first),
                s = Perevod_v_10(second, osn_second);
            string result;
            if (f > s) result = "Первое число больше.";
            else if (f == s) result = "Числа равны";
            else result = "Второе число больше.";
            return result;
        }
        public static bool Check(int chislo, int osnovanie)     //проверка соответствия СС
        {
            string ch = chislo.ToString();
            for (int i = 0; i < ch.Length; i++)     //проходимся по цифрам числа
            {
                if (Convert.ToInt32(ch[i]) - 48 >= osnovanie) return false;
            }
            return true;
        }

        public static int Perevod_v_10(int chislo, int osnovanie)        //перевод в 10 СС
        {
            int ch = chislo;
            int new_chislo = 0, stepen = 1;
            for (int i = 0; i < chislo.ToString().Length; i++)
            {
                if (i != 0) stepen *= osnovanie;
                if (ch % 10 != 0) new_chislo += stepen * (ch % 10);
                ch /= 10;
            }
            return new_chislo;
        }

        public static int Perevod_from_10(int ch, int osnovanie)         //Перевод из 10 в другую
        {
            int chislo = ch, new_chislo = 0;
            int i = 1;
            while (chislo != 0)
            {
                int temp_ostatok = chislo % osnovanie;
                chislo /= osnovanie;
                new_chislo += temp_ostatok * i;
                i *= 10;
            }
            return new_chislo;
        }
    }
}
