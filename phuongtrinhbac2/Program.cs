using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{


    class phuongtrinhbachai
    {
        //-------------khai bao ham checkso-----------------
        public class checkso : Exception
        {
            const string erroMessage = "ban da nhap sai-> phai nhap chu so";
            public checkso() : base(erroMessage) { }

        }

        static void Main(string[] args)
        {
            string UserInput(string s)
            {

                s = Console.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (((int)s[i] < 47 || (int)s[i] > 58) && !((int)s[i] == 46 || (int)s[i] == 45))
                    {
                        Exception e = new checkso();
                        throw e; // loi stop chuong trinh

                    }
                }
                return s;
            }

            string ct = "Y";
            do //// -----------------------vong lap do...while hoi xem co muon lam tiep ko------------------------
            {
                //--------------khai bao bien----------------
                float a = 0, b = 0, c = 0; // chuyen kieu thanh float
                float d;
                double x1, x2;// d la delta
                float x;
                string ss = "1";


                //--------------nhap tham so abc-----------------

                try // ------------------------bat loi nhap sai ky tu khac so----------------
                {
                    Console.WriteLine("nhap a");
                    UserInput(ss);
                    a = float.Parse(ss); // chuyen kieu thanh float 
                    Console.WriteLine("nhap b");
                    UserInput(ss);
                    b = float.Parse(ss);
                    Console.WriteLine("nhap c");
                    UserInput(ss);
                    c = float.Parse(ss);

                }
                catch (checkso exp)
                {
                    Console.WriteLine(exp.Message); // --------------------hien thi thong bao da nhap sai so-------------
                    continue;

                }

                //-----------------bien luan pt theo delta---------------------

                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (float)(-1 * b + Math.Sqrt(d)) / (2 * a);
                    x2 = (float)(-1 * b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("ketqua:\n phuong trinh co 2 nghiem phan biet: x1= {0}, x2 = {1}", x1, x2);
                }
                else if (d == 0)
                {
                    x = (float)-1 * b / (2 * a);

                    Console.WriteLine("ketqua: \n phuong trinh co nghiem kep: x1=x2= {0}", x);

                }
                else Console.WriteLine("ket qua:\n phuong trinh vo nghiem");

                // -----------------------hoi xem co muon lam tiep ko------------------------

                Console.WriteLine("ban co muon lam tiep khong? \n hay go 'Y' neu muon tiep tuc, go 'N' neu muon dung lai");
                ct = Console.ReadLine();
                // if (ct == "N") Environment.Exit(0);

            } while (ct == "Y");

        }
    }
}
