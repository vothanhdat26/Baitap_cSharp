using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_
{
    public class Program
    {
        static void Baitapchuoi()
        {
            string fname, lname;
            fname = "Thanh";
            lname = "Dat";
            string fullname = fname + " " + lname;
            Console.WriteLine(fullname);
            // by using string contructor
            // dua vao mang cac ki tu
            char[] letters =
                { 'V', 'o',' ', 'T', 'h', 'a', 'n', 'h',' ', 'D', 'a', 't' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            // methods returing string
            string[] sarray = { "Vo", "Thanh", "Dat" };
            string message = String.Join("\t", sarray);
            Console.WriteLine("Message: {0}", message);
            // format method to convert a valuse
            DateTime waiting = new DateTime(2024, 03, 13, 13, 18, 25);
            // nam , thang , ngay, gio , phut, giay
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            // so sanh chuoi
            string str1 = "vtd";
            string str2 = "vtd";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + "and" + str2 + " are equal");
            }
            else
            {
                Console.WriteLine(str1 + "and " + str2 + "are not equal");
            }

            // tim kiem Constains
            string str_constains = "vo thanh dat";

            if (str_constains.Contains("dat"))
            {
                Console.WriteLine("Tim thay:{0}", str_constains.Contains("dat"));
            }
            // lay chuoi phu trong C#

            string str_phu = "vothanh dat hcmus 192000270";
            Console.WriteLine(str_phu);
            string subStr = str_phu.Substring(2, 5); // gia tri bat dau la [0.1.2]= 2, chieu dai la 5
            Console.WriteLine(subStr);
            // hop chuoi: Join
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string[] lyricsA_P = new string[]
            {
                "Xin lỗi mà",
                "Ayy, wey, ayy, wey, ayy, wey",
                "Xin lỗi",
                "Xin lỗi", "Xin lỗi","Xin lỗi" ,"Xin lỗi"," Xin lỗi, anh chịu không nổi (sheesh)",
                "Xin lỗi vì đã chơi nổi (sheesh)","Xin lỗi anh là vô đối (sheesh)","Xn lỗi vì hơi đẹp trai (hahaha)",
                "Nếu không thành công thì thôi đi chơi ngải, Bơi sải cùng Lý Hải (yessir)","Đi chơi cùng A$AP Thái",
                "Thằng nào không xin lỗi anh đập vô đầu (hahaha)"
            };
            string Lyrics_join= String.Join("\n", lyricsA_P);
            Console.WriteLine(Lyrics_join);
        }

      
        static void Duyetmang()
        {
            int[,] array = new int[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j=0; j < 5; j++)
                {
                    if (i == 0 || j == 0 || i == 4 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }
        #region 1.viet chuong trinh tim so lon nhat va nho nha trong 3 so thuc

        // tim so lon hon trong 2 so
        static float Max(float a,float b)
        {
            return a>b? a: b;
        }
        static void cau1()
        {
            float a, b, c;
            Console.WriteLine("Nhap vao 3 so a,b,c : ");
            Console.Write("Nhap vao a: "); a=float.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: "); b =float.Parse(Console.ReadLine());
            Console.Write("Nhap vao c:"); c= float.Parse(Console.ReadLine());
            float max = Max(a, Max(b, c));
            Console.WriteLine("So lon nhat trong 3 so {0} ,{1}, {2} la:{3} ", a, b, c, max);

            float max1 = Max(a, b);
            float max2 = Max(max1, c);
            Console.WriteLine("So lon nhat trong 3 so {0} ,{1}, {2} la:{3} ", a, b, c, max2);
        }
        #endregion
        #region bai2. Viet chuong trinh tim x^y
        static void cau2()
        {
            // tinh tay

            long result = 1;
            int x, y;
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                result *= x;
             
            }
            Console.WriteLine("Gia tri la: " + result);

        }
        static long Luythua(int x, int y)
        {
            return (long)Math.Pow(x, y);
        }
        #endregion
        #region cau3. So sanh diem va xuat ra hoc luc

        static void Cau3()
        {
            float diem;
            string hocluc = "chua xep hoc luc";
            Console.WriteLine("Nhap diem: ");
            diem = float.Parse(Console.ReadLine());
            // if else rut gon
            hocluc
                = diem >= 0 && diem < 3 ? "Kem" 
                : (diem >= 3 && diem < 5 ? "Yeu"
                : (diem >= 5 && diem < 7 ? "TB"
                : (diem >= 7 && diem < 8 ? "Kha"
                : "Gioi")));
            Console.WriteLine($"Hoc luc {hocluc} diem {diem}");
            if(diem >=0 && diem <3)
            {
                hocluc = "kem";
            }
            else if(diem>=3 && diem < 5)
            {
                hocluc = "Yeu";
            }
            else if(diem >=5 &&diem < 7) 
            {
                hocluc = "TB";
            }
            else if(diem >=7 && diem < 8)
            {
                hocluc = "kha";
            }
            else
            {
                hocluc = "gioi";
            }
            Console.WriteLine("Hoc luc cua diem {0} la {1}", diem, hocluc); 
        }
        #endregion
        #region cau4. co 5 laoi giay bac 1000d, 2000d, 5000d, 10,000d, 20,000d,
        // xuat ra cac cach de co dc so tien la N tu 5 to tien
       static void Cau4()
        {
            // vet can: dua ra tat ca cac trg hop xay ra
            long tongtien = 20000;
            long k1 = 1000;
            long k2 = 2000;
            long k5 = 5000;
            long k10 = 10000;
            long k20 = 20000;
            int count = 0;
          //  Console.Write("Nhap so tien: ");
          //tongtien = long.Parse(Console.ReadLine());
            for(int i = 0; i <= tongtien / k1; i++)
            {
                for(int j=0;j<=tongtien/k2; j++)
                {
                    for(int k = 0; k <= tongtien / k5; k++)
                    {
                        for(int l= 0; l<=tongtien / k10; l++)
                        {
                            for(int m = 0; m <= tongtien / k20; m++)
                            {
                                if(i*k1+ j*k2+ k*k5+ l * k10 +m*k20 == tongtien)
                                {
                                    count++;
                                    //Console.WriteLine("Dung {0} to {1} | {2} to {3} |{4} to {5}| {6} to {7} | {8 } {9} {10}", i, k1, j, k2,k,k5,l,k10,m,k20, tongtien);
                                    Console.WriteLine($"Dung {i} to {k1} , {j} to {k2}, {k} to {k5}, {l} to {k10} ,{m} to {k20}, {tongtien}");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(count);
            }
        }

        #endregion
        #region cau 5.Lam menu()
        static void Menu()
        {
            Console.Clear();
            string menu = "\t\t MENU \n"
                + "\t1.Viet chuong trinh tim so lon nhat trong 3 so thuc \n"
                + "\t2.Viet chuong trinh x^y\n"
                + "\t3.Tim hoc luc \n"
                + "\t4.Tinh tien\n"
                +"\t5.Menu\n"
                + "\t6.Tim so nguyen to va in ra day so nguyen to va so luong\n"
                + "\t7.khoi tao mang cac so ngau nhien 0-70\n"
                +"\t8.Khoi tao mang va xuat mang, tim so lon nhat trong dong\n"
                +"\t9.Xoa ki tu 'a' ra khoi chuoi \n"
                +"\t10.Su dung Ref va out \n"
                +"\t11.Nhap chuoi khi thay khi tu khoang trang thi xuong dong\n"
                +"\t12.Doi xung cua chuoi \n"
                + "\t0.Exit\n";
            Console.WriteLine(menu);
            // doi lenh

            // thuc hien lenh cua user

            while (true)
            {
                Console.Write("\tNhap lenh: ");
                string userCommand = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(menu);
                switch (userCommand)
                {
                    case "1":
                        cau1();
                        break;
                    case "2":
                        cau2();
                        break;
                    case "3":             
                        Cau3();
                        break;
                    case "4":
                        Cau4();
                        break;
                    case "5":
                        //menu                       
                       break;
                    case "6":
                        Cau6();
                        break;
                    case "7":
                        cau7();
                        break;
                    case "8":
                        Cau8();
                        break;
                    case "9":
                     cau9();
                        break;
                    case "10":
                        cau10();
                        break;
                    case "11":
                        Cau11();
                        break;
                    case "12":
                        Cau12();
                        break;
                    default:
                        throw new Exception ("Nhap lenh sai, vui long nhap lai!");
                }
            }
        }
        #endregion
        #region Cau 6.Viet chuong trinh co dung ham de tim so nguyen to nho hon N
        
        static bool isSonguyento(int a)
        {
            if (a < 2) {
                return false;
            }
            if(a==2){ return true; }
            for(int i = 2; i <=Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Cau6() {
            Console.Write("Nhap so N: ");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= a; i++)
            {
                if(isSonguyento (i))
                {
                    Console.WriteLine($"{i} la so nguyen to");
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        #endregion
        #region Cau7. khoi tao mang cac so ngau nhein 0-70
        static void initMang(int[,]a)
        {
            Random rand= new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                // getLeght(0) tra ve day so i theo huong hang 
            {
                for (int j = 0; j < a.GetLength(1); j++)
                // getLeght(0) tra ve day so i theo huong cot
                {
                    //Next trave day so nguyen khong am
                    a[i,j]= rand.Next(0,20);
                }
            }
        }
       static void xuatMang(int[,]a)
        {
            for(int i = 0; i< a.GetLength(0); i++)
            {
                // xuong dong
                Console.WriteLine();
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,5}",  a[i, j]);
                }
            }
        }
        static void cau7()
        {
            int[,]a = new int[5,5];

            initMang(a);
            xuatMang(a);
            Console.WriteLine();

        }


        #endregion
        #region cau8. Viet chuong trinh tao mang thuc khong uqa 20x20. xuat ra mang vua tao
        //va tim gia tri lon nhat trong cac dong cua mang

        static void TimGia_triMax_Dong(int[,]a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.GetLength(1);j++)
                {
                    //max = a[i, j] >  max? a[i,j] : max;
                    if(max < a[i, j])
                    {
                        max = a[i, j];
                    }
                } 
                Console.WriteLine($"Max cua cot {i} la: {max}");
            }
        }

        static void TaomangNgauNhien(int[,]a)
        {
            Random rand= new Random();
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(0, 100);
                }
            }
        }
        static void Cau8()
        {
            int[,] a= new int[5,5];
            TaomangNgauNhien(a);
            xuatMang(a);
            Console.WriteLine();
            TimGia_triMax_Dong(a);
        }
        #endregion
        #region Cau9. Viet chuong trinh bo ky tu a trong mot chuoi
        
        static void Dlete_a(ref string a){
         for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a')
                {
                    a=a.Remove(i, 1);
                }
            }
        }
        static void cau9()
        {
            //Nhap chuoi
            // xoa a
            // Xuat chuois
            string a = "";Console.WriteLine("Nhap chuoi a:");
            a=Console.ReadLine();
            Dlete_a(ref a);
            Console.WriteLine(a);

        }

        #endregion
        #region Cau 10: cach su dung tu khoa ref va out
        static void test_ref(ref int values)
        {
            // ref la tham chieu lay gia tri truc tiep trong ham cua no
            // ref khong can phai khoi tao no trong ham su dung ref,
            // nhung trc khi su dung phai khoi tao no.
            values= values+1;
        }
        static void bien_out(out int x)
        {
            // out phai khoi tao no trong ham chua no,
            // no khong can quan taam bien trong ham su dung ham_out
            x = 26012001;
        }
        static void cau10()
        {
            {
                int x =20012611;
                Console.WriteLine("Gia tri x khi khong co ref, van giu nguyen gia tri cua Cau10(): " + x);
                Console.WriteLine("Cach su dung Ref: ");
                Console.WriteLine("Ref khong can khoi tao trong ham chua Parameter(ref): ");
                Console.WriteLine("Ref phai khoi tao gia tri bien truoc khi muon su dung ham_ref:");
                test_ref(ref x);
                Console.WriteLine("Gia tri x co bien ref: " + x);
            }
            {
                int y;
             
                Console.WriteLine("Gia tri cua y trong Cau10, " +
                    "khong can phai khai bao truoc, khi su dung out ");
                Console.WriteLine("Gia tri y, phai can khai bao o ham chua Out:  (x =x+1;)= False");
                bien_out(out y);
                Console.WriteLine("Gia tri y khi su dung ham out : " + y);

            }
        }
        #endregion
        #region Cau 11. Viet chuong trinh in cac tu cau chuoi tren dong

        static void EnterString(ref string a)
        {
            // thay khoang trang thay bang \n
            string[] newA = a.Split(' ');
            // split cat chuoi khi co ' '
            a = "";
            foreach(string item in newA)
            {
                //a = a + item + '\n';
                //a += item + '\n';
                a += item + Environment.NewLine;
            }
        }
        static void Cau11()
        {
            // nhap chuoi
            // xuat chuoi
            Console.Write("Nhap chuoi : ");
            string a = Console.ReadLine();
            // format chuoi
            EnterString(ref a);
            Console.WriteLine("Xuat chuoi: ");
            Console.WriteLine(a);
        }
        #endregion
        #region cau 12. viet chuong trinh kiem tra  chuoi co doi xung hay khong
        // doi xung theo a.length<2
        // => a[i] != a[a.length-i] => bat doi xung(1)
        // mac dinh la doi xung
        // neu (1) xay ra=> bat doi xung ngay

        static bool isBalance(string a)
        {
            // duyet dden nua chuoi , neu khong doi xung la false
            for(int i=0;i<a.Length/2; i++)
            {
                if (a[i] != a[a.Length-1- i])
                {
                    return false;
                }
            }
            // mac dinh la true
            return true;
        }
        static void Cau12()
        {
            // nhap chuoi
            // xuat chuoi
            Console.Write("Nhap chuoi : ");
            string a = Console.ReadLine();
            // format chuoi

            Console.WriteLine("Xuat chuoi: ");
            if (isBalance(a))
            {
                Console.WriteLine("Chuoi a doi xung" +a);
            }
            else
            {
                Console.WriteLine( "Khong doi xung " +a);
            }        
        }
          #endregion

        static void Main(string[] args)
        {

            Menu();            
            Console.ReadLine();
        }

    
    }
}