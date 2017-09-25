using System;

namespace ygyg
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1a || Примитивные типы:");
            sbyte sbyteValue = -77;
            Console.WriteLine("sbyte " + sbyteValue);

            byte byteValue = 56;
            Console.WriteLine("byte " + byteValue);

            char charValue = 'h';
            Console.WriteLine("char " + charValue);

            bool boolValue = true;
            Console.WriteLine("bool " + boolValue);

            short shortValue = 5485;
            Console.WriteLine("short " + shortValue);

            int intValue = 19495;
            Console.WriteLine("int " + intValue);

            uint uintValue = 584;
            Console.WriteLine("uint " + uintValue);

            long longValue = 969305;
            Console.WriteLine("long " + longValue);

            ulong ulongValue = 958392;
            Console.WriteLine("ulong " + ulongValue);

            float floatValue = 54.5463f;
            Console.WriteLine("float " + floatValue);

            double doubleValue = -12.991114578;
            Console.WriteLine("double " + doubleValue);

            decimal decimalValue = -38.54m;
            Console.WriteLine("decimal " + decimalValue);

            //неявные преобразования
            Console.WriteLine("1b || Неявные преобразования:");
            sbyte sb = -98;
            short sb1 = sb;
            Console.WriteLine(sb1);

            ushort ush = 65;
            uint ush1 = ush;
            Console.WriteLine(ush1);

            long lg = -187;
            float lg1 = lg;
            Console.WriteLine(lg1);

            byte bt = 201;
            double bt1 = bt;
            Console.WriteLine(bt1);


            ulong ul = 973;
            float ul1 = ul;
            Console.WriteLine(ul1);

            //явные преобразования

            Console.WriteLine("1b || Явные преобразования:");
            ulong ulo = 897867543;
            byte ulo1;
            ulo1 = (byte)ulo;
            Console.WriteLine(ulo1);

            double db = 89.7543;
            int db1;
            db1 = (int)db;
            Console.WriteLine(db1);

            float ft = 89.43f;
            char ft1;
            ft1 = (char)ft;
            Console.WriteLine(ft1);

            float flt = 7878.90f;
            short flt1;
            flt1 = (short)flt;
            Console.WriteLine(flt1);

            char ch = 'u';
            short ch1;
            ch1 = (short)ch;
            Console.WriteLine(ch1);

            //упаковка/распаковка
            Console.WriteLine("1c || Упаковка/Распаковка:");
            int i = 564;
            object o = (object)i; //упаковка

            o = 987;
            i = (int)o; //распаковка

			//неявно типизированнве переменные 
			Console.WriteLine("1d || Неявно типизированные переменные:");
            var ppp = 7;
            var s = "привет";
            Console.WriteLine(s);
            Console.WriteLine(ppp);
            var b = new[] { 7, 9, 6 };

            //nullable
            Console.WriteLine("1e || Nullable");
            int? c = null;
            bool? j = null;
            Console.WriteLine(c);
            Console.WriteLine(j);

			//строковые литералы 
            Console.WriteLine("2a || Строковые литералы и их сравнение:");
            string g = "hello";
            string k = "hello";
            Console.WriteLine("g=k?"+g == k);

            Console.WriteLine("2b || сцепление,копирование, выделение подстроки и др.");
            string str1 = "строка1";
            string str2 = "строка2";
            string str3 = "строка3";

            string join = string.Join(str1, str2,null);
            Console.WriteLine(join);

			string copy = string.Copy(str3);
			Console.WriteLine(copy);

            int ind = 3;
            int length = 2;
			string sub = str2.Substring(ind,length);
			Console.WriteLine(sub);

            const string spl="hello world!";
            string[] slova = spl.Split(' ');
            foreach (string word in slova)
            {
                Console.WriteLine(word);
            }

            string sr= "я изучаю";
            string posle=sr.Insert(8, " C#");
			Console.WriteLine(posle);

            string ctroka="hello world";
            string rp = ctroka.Replace("o", "");


		}
        }
}
