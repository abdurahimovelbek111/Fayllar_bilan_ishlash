using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayllar_bilan_ishlash
{
    class Program
    {
        static void Main(string[] args)
      {

            //string s = " Assalomu alaykum";
            //File.AppendAllText("c:/fayl.txt", s);    //Yaratilgan faylga malumodni kiritish va satr davomidan yozish 
           // string l = File.ReadAllText("c:/fayl.txt");       //Bu fayldagi malumotlarni HAMMASINI O'QISHni imkonini beradi
           // Console.WriteLine(File.GetLastWriteTime("c:/fayl.txt"));   //Faylga siz qachon(qaysi vaqtda) malimot yozgan vaqtizni ko'rsatadi (sana.oy.yil soat.minut.sekund)
           // Console.Write(File.GetLastWriteTimeUtc("c:/fayl.txt")); // qachon yozilganini (soat=0 min,sek)chiqaradi         
           // Console.Write(File.ReadAllLines("c:/fayl.txt"));// bu faylda yozilgan malimotizni kurishga imkon yaratadi 
           // File.WriteAllText("c:/fayl.txt", "qanday");      // ya'ni bu fayl ichidagi ma'limot ustidan yangi malimotizni yozib quyadi 
            //File.AppendText("c:/fayl.txt");  //Yangi fayl yaratish 
            //File.AppendAllText("c:/fayl.txt", "salom");
            //File.Copy("c:/fayl.txt", "e:/fayl.txt");       //  birinchi fayldan kiopiya ikkinchisiga nusqa olish
           // File.Move("c:/fayl1.txt", "e:/fayl1.txt");    // faylni bir joydan boshqa joyga ko'chirish
           // File.Create("c:/fayl.txt");        //fayldagi malumot o'chadi
            //Console.Write(File.Equals("salom", "qanday")); //fayllarni ichidagi malimotni yangi malimot bn tenglikka tekshiradi
            //Console.Write(File.Equals("salom dunyo", "salom duny"));          //fayllarni tenglikka tekshiradi
       //File.WriteAllText()
            //1-misol
           // string s="salom alaykum uzbekiston";
            //File.WriteAllText("e:/fayl.txt", s);


            //    int n = 0;
            //int m = 0;
            //    string l="";
            //string k="";
            //string d = File.ReadAllText("e:/fayl.txt");
            //for (int i = 0; i < d.Length ; i++)
            //{
            //    if (d[i] == '$')
            //    {
            //        k+=(d[i - 1]).ToString ();
            //    }
            //    else
            //        k+= d[i];

            //}
            //Console.WriteLine(k);
            //for (int i = 0; i < d.Length ; i++)
            //{
            //    if(d[i]=='$')
            //    {
            //        n++;
            //        l+= d[i - 8].ToString ();
            //        Console.Write(d[i-8]);
            //    }
            //}
            //string w = "";
            //Console.WriteLine("javoblarni kiriting bo'sh joy tashlamasdan ");
            //string f = Console.ReadLine();
            //for (int i = 0; i <n; i++)
            //{
            //    if(l[i]==f[i])
            //    {
            //        m++;
            //        w += (i+1).ToString();
            //    }
            //}
            //Console.WriteLine("javoblaringizdan {0} ta to'g'ri bular {1} ",m,w);


            //-----------------------------------------------------------------------------------------

            ////string []a={"Assalomu aleykum !","Dilshod Abdijabborov ","Qaleysan ","Qayerdasan"};
            //string a = "Assalomu aleykum !";
            //File.AppendAllText("c:/fayl.txt", a);
          //  File.AppendText("c:/fayl.txt");
            //-------------------4-----------------//
          //  Program prog = new Program();
          //  string s = Console.ReadLine();
          ////  Console.WriteLine(prog.Oxiridan_oldingi(s));
          //  File.WriteAllText("c:/fayl1.txt", prog.Oxiridan_oldingi(s)); 
            //-----------------1----------------//
            Program prog = new Program();
            //string s = Console.ReadLine();
            //File.WriteAllText("c:/fayl.txt", prog.manfiy(s));         
            //-----------------2---------------//
            //Program prog =new Program();
            //string a = Console.ReadLine();
            //File.WriteAllText("c:/fayl.txt", prog.Tartiblash(a));
            //---------------3-------------//
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //File.AppendAllText("c:/fayll.txt", x);
            //File.AppendAllText("c:/fayll1.txt", y);
            //File.WriteAllText("c:/fayl.txt", prog.Tekshirish(x,y));
            //------------5-------------//
            //string s=Console.ReadLine();
            //File.WriteAllText("c:/fayl.txt",prog.Raqam(s));
            //-----------6----------//
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //File.WriteAllText("c:/fayl.txt", prog.Fib(n));
            //Console.WriteLine(prog.Fib(n));
            //-----------7---------//
            //string a = Console.ReadLine();
            //File.WriteAllText("c:/fayl.txt", prog.Kichik(a));
            //-----------8--------//
            //string a = Console.ReadLine();
            //string[] b = a.Split(',', '.');
            //string g = "";
            //for (int i = 0; i < b.Length;i++)
            //{
            //    if(b[i]==b[b.Length-1])
            //    {
            //        continue;
            //    }
            //    else if(b[i]!=b[b.Length-1])
            //    {
            //        g += b[i];
            //    }
            //}
            //    File.AppendAllText("c:/fayl.txt", g);
            //------------9----------//
            //----------a),b)----------//
            //string a = Console.ReadLine();
            //string s = Console.ReadLine();
            //File.AppendAllText("c:/fayl.txt", prog.AddLast(a, s));
            //---------d)--s)------//
           // string a = Console.ReadLine();
           // string b = Console.ReadLine();            
           //// File.WriteAllText("c:/fayl.txt", prog.Double(a));            
           //    string c = a[a.Length - 1]+"";
           // Console.WriteLine(a.Replace(c, b));
           // File.WriteAllText("c:/fayl.txt", a.Replace(c, b));
            //-------f)-------//
            //string a = Console.ReadLine();
            //File.WriteAllText("c:/fayl.txt", prog.Next(a));
           //--------j)--------//
            //string a = Console.ReadLine();
            //string x="";
            //if(a.Length>1)
            //{
            //  x= a.Remove(a.Length - 2)+a[a.Length-1];
            //File.WriteAllText("c:/fayl.txt",x);
            //}
            //else
            //{
            //    x="Xatolik yuz berdi !!!!";
            //    File.WriteAllText("c:/fayl.txt", x);
            //}
            //--------i)-------//
            //string a = Console.ReadLine();
            //string []x=a.Split(' ');
            //string y = "";
            //for (int i = 0; i < x.Length;i++)
            //{
            //    if(x[i].Length>0)
            //    {
            //        y += x[i].Remove(1);
            //    }
            //}
            //    Console.WriteLine(y);  
            //File.WriteAllText("c:/fayl.txt",y);
            //----------10---------//
            //string a = Console.ReadLine();
            //string[] Satr = a.Split(' ');            
            //int t = Satr.Length;
            //int j=0;
            //while(t!=0)
            //{               
            //    string x =Satr[j]+"";
            //    int[] B = new int[x.Length];
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        B[i] = x[i]-48;
            //    }
            //    Array.Sort(B);
            //    for (int i = 0; i < x.Length;i++ )
            //    {
            //        Console.Write(B[i]+" ");
            //    }
            //        Console.WriteLine();
            //    j++;
            //    t--;
            //}
          //----------------------------------------//
           // string a = Console.ReadLine();
           // string b = Console.ReadLine();
           // int[] A = new int[a.Length];
           // int[] B = new int[b.Length];
           // for (int i = 0; i < a.Length;i++ )
           // {
           //     A[i] = a[i]-48;
           // }
           // for (int i = 0; i < b.Length; i++)
           // {
           //     B[i] = b[i] - 48;
           // }
           // Array.Sort(A);
           // Array.Sort(B);
           // string x = "",y="";
           // for (int i = 0; i < a.Length; i++)
           // {
           //     x += A[i];
           // }
           // for (int i = 0; i < b.Length; i++)
           // {
           //     y += B[i];
           // }
           //if(x.Length>y.Length)
           //{
           //    File.WriteAllText("c:/fayl.txt", x);
           //}
           // else if(y.Length>=x.Length)
           //{
           //    File.WriteAllText("c:/fayl.txt", y);
           //}
                // File.WriteAllText("c:/fayl.txt", prog.incf(a));
            //------------11------------//
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string x = a+b;
            
            //int[] A = new int[x.Length];
           
            //for (int i = 0; i < x.Length; i++)
            //{
            //    A[i] = x[i] - 48;
            //}           
            //Array.Sort(A);           
            //for (int i = 0; i < x.Length; i++)
            //{
            //    for (int j = 0; j < x.Length; j++)
            //    {
            //        if(A[i]>A[j])
            //        {
            //            int t = A[i];
            //            A[i] = A[j];
            //            A[j] = t;
            //        }
            //    }
            //}
            //string z="";
            //for(int i=0;i<x.Length;i++)
            //{
            //    z += A[i];
            //}      
            //File.WriteAllText("c:/fayl.txt", z);
           //----------13-----------//
            //string a ="";           
            //for (int i = 1; i < 10;i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        a += i;                   
            //    }                
            //}
            //Console.WriteLine(a);
            //File.WriteAllText("c:/fayl.txt", a);
            //--------14-------//
            //string a = Console.ReadLine();
            //char b='.';
            //string x = "";
            //string f = "";
            //for (int i = 0; i < a.Length;i++ )
            //{
            //    if (a[i] != b)
            //    {
            //        x += a[i];
            //    }
            //    else
            //        break;
              
            //}
            //while (f.Length < 40)
            //{
            //    for (int i = 0; i < x.Length; i++)
            //    {

            //        {
            //            f += x[i];
            //        }
            //    }
            //}
            //Console.WriteLine(f);
            //--------------15-------------//
            //string a = Console.ReadLine();           
            //int l = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if(a[i]==' ')
            //    {
            //        l++;
            //    }
            //}
            //File.WriteAllText("c:/fayl.txt", l.ToString());
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //int t=b[0].Length;
            //for (int i = 1; i < b.Length;i++ )
            //{
            //   if(b[i].Length<b[i-1].Length)
            //   {
            //       t = b[i -1].Length;
            //   }
            //}
            //File.WriteAllText("c:/fayl.txt", t.ToString());
            //------------16--------------//
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //int []A=new int[b.Length];
            //for (int i = 0; i < b.Length; i++)
            //{
               
            //    Console.Write(A[i]+" ");
            //}
            //------------17----------//
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //string x = "";
            //int l = 0;
            ////char c = char.Parse(Console.ReadLine());                      
            //for (int i = 1; i < b.Length; i++)
            //{
            //    // a) shart
            //    if (x[0] == 'd' && b[i].Length != 0)
            //    {
            //        l++;
            //    }  
            //    //---b) shart
            //    //if (x[x.Length-1] == c && b[i].Length != 0)
            //    //{
            //    //    l++;
            //    //}
            //    // d) shart
            //    //if (x[0] == c && x[x.Length-1]==c && b[i].Length != 0)
            //    //{
            //    //    l++;
            //    //}
            //    // e) shart               
            //}

            //x = l + "";
            //  Console.WriteLine(x);
          //File.WriteAllText("c:/fayl.txt", x);
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //int l = 0;
            //     for(int i=0;i<b.Length;i++)
            //       {
            //           for(int f=i+1;f<b.Length;f++)
            //           {
            //               if(b[i]==b[f])
            //               {
            //                   l++;
            //               }
            //           }
            //       }
            //     Console.WriteLine(l);
               
          
       //     Console.WriteLine(s);
            //------------------------------18------------//
            //string a = Console.ReadLine();
            //File.WriteAllText("c:/fayl.txt", a);
            //File.Copy("c:/fayl.txt", "e:/fayl.txt");
            //-------------------19---------------//
            //string a = Console.ReadLine();
            //if(a.Length!=0)
            //{
            //File.WriteAllText("c:/fayl.txt", a);
            //File.Copy("c:/fayl.txt", "e:/fayl.txt");
            //}
            //else
            //{
            //    Console.WriteLine("Afsus !!!");
            //}
            //--------------------------20--------------------------//
            //string a = Console.ReadLine();
            //string []b=a.Split(' ');
            //string x = "";
          
            //for (int l = 0; l < b.Length; l++)
            //{
            //    for (int i =b[l].Length; i < 80;i++ )
            //    {
            //       if(b[l].Length>=i)
            //       {
            //           x += b[l];
            //       }
            //       else
            //       {
            //           x += "*";
            //       }
            //    }
            //}
            //File.WriteAllText("c:/fayl.txt", x);
           // File.Copy("c:/fayl.txt", "e:/fayl.txt");
            //----------------------21---------------//
            //---------------------22--------------//
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //int[] B = new int[b.Length];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    B[i] = int.Parse(b[i]);   
            //}
            //int max=B[0];
            //for (int i = 0; i < b.Length;i++ )
            //{
            //    if(max<B[i])
            //    {
            //        max = B[i];
            //    }
            //} File.WriteAllText("c:/fayl.txt", max.ToString());
            //------------------------23-------------------//
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //string x = "";
            //int[] B = new int[b.Length];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    B[i] = int.Parse(b[i]);
            //}        
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (B[i] >= 0)
            //    {
            //        x += B[i] + " ";
            //    }
            //}
            //File.WriteAllText("c:/fayl.txt", a);
            //File.WriteAllText("e:/fayl.txt", x);
            //--------------------------24--------------------//
            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //string x = "";
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if(a.Length!=0)
            //    {
            //        x += 1000 * (i+1)+b[i];
            //    }
            //}
            //File.WriteAllText("c:/fayl.txt", x);
            //-------------------------25--------------------//
            //string a = File.ReadAllText("c:/fayl.txt");
            //string f = "";
            //for (int i = 0; i < 60;i++ )
            //{
            //    if(a[i]=='.')
            //    {
            //        break;
            //    }
            //    f += a[i];
            //}
            //File.WriteAllText("c:/fayll.txt", f);
            //------------------------26---------------------//
            //string a = File.ReadAllText("c:/fayl.txt");
            //string[] b = a.Split(' ');
            //int t = b[0].Length;
            //string x = "";
            //for (int i = 1; i < b.Length; i++)
            //{
            //    if (t > b[i].Length)
            //    {
            //        t = b[i].Length;
            //        x = b[i];
            //    }
            //}
            //File.WriteAllText("c:/fayl.txt", x);
            //-----------------------27-------------------//
            //-----a)
            //string a = File.ReadAllText("c:/A.txt");
            //string[] b = a.Split(' ');
            //int[] B = new int[b.Length];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    B[i] = int.Parse(b[i]);
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int j = 0; j < b.Length; j++)
            //    {
            //        if(B[i]>B[j]) 
            //        {
            //            int t = B[i];
            //            B[i] = B[j];
            //            B[j] = t;
            //        }
            //    }
            //}
            //string x = "";
            //for (int i = 0; i < b.Length;i++)
            //{
            //    x += B[i];
            //}
            //File.WriteAllText("c:/B.txt", x);
            //---------b)
            //string a = File.ReadAllText("c:/C.txt");
            //string a1 = File.ReadAllText("c:/D.txt");
            //string a2 = File.ReadAllText("c:/A.txt");
            //string c = a + " " + a2;
            //string c1 = a1 + " " + a2;
            //string c3 = c + " " + c1;
            //string[] x = c3.Split(' ');
            //int[] X = new int[x.Length];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    X[i] = int.Parse(x[i]);
            //}
            //for (int i = 0; i < x.Length; i++)
            //{
            //    for (int j = 0; j < x.Length; j++)
            //    {
            //        if (X[i] > X[j])
            //        {
            //            int t = X[i];
            //            X[i] = X[j];
            //            X[j] = t;
            //        }
            //    }
            //}
            //string Tartiblangan_qisim = "";
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Tartiblangan_qisim += X[i]+" ";
            //}
            //File.WriteAllText("c:/F.txt", Tartiblangan_qisim);
           
          //  ----------------V)
            //string a = File.ReadAllText("c:/A.txt");
            //string a1 = File.ReadAllText("c:/B.txt");
            //string a2 = File.ReadAllText("c:/F.txt");
            //string c = a + " " + a2 + " ";
            //string c1 = a1 + " " + a2;
            //string c3 = c + c1;
            //string[] z = c3.Split(' ');
            //int[] Z = new int[z.Length];
            //for (int i = 0; i < z.Length; i++)
            //{
            //    Z[i] = int.Parse(z[i]);
            //}
            //for (int i = 0; i < z.Length; i++)
            //{
            //    for (int j = 0; j < z.Length; j++)
            //    {
            //        if (Z[i] > Z[j])
            //        {
            //            int t = Z[i];
            //            Z[i] = Z[j];
            //            Z[j] = t;
            //        }
            //    }
            //}
            //string Tartiblangan_qisim = "";
            //for (int i = 0; i < z.Length; i++)
            //{
            //    Tartiblangan_qisim += Z[i]+" ";
            //}
            //File.WriteAllText("c:/K.txt", Tartiblangan_qisim);
            //---------------G)
            //string a = File.ReadAllText("c:/C.txt");
            //string a1 = File.ReadAllText("c:/D.txt");
            //string a2 = File.ReadAllText("c:/K.txt");
            //string c = a + " " + a2 + " ";
            //string c1 = a1 + " " + a2;
            //string c3 = c + c1;
            //string[] z = c3.Split(' ');
            //int[] Z = new int[z.Length];
            //for (int i = 0; i < z.Length; i++)
            //{
            //    Z[i] = int.Parse(z[i]);
            //}
            //for (int i = 0; i < z.Length; i++)
            //{
            //    for (int j = 0; j < z.Length; j++)
            //    {
            //        if (Z[i] > Z[j])
            //        {
            //            int t = Z[i];
            //            Z[i] = Z[j];
            //            Z[j] = t;
            //        }
            //    }
            //}
            //string Tartiblangan_qisim = "";
            //for (int i = 0; i < z.Length; i++)
            //{
            //    Tartiblangan_qisim += Z[i]+" ";
            //}
            //File.WriteAllText("c:/L.txt", Tartiblangan_qisim);
            //--------------28------------//
            //string a = File.ReadAllText("c:/A.txt");
            //string s = Console.ReadLine();
            //string x = s + " " + a + " " + s;
            //File.WriteAllText("c:/B", x);
            //--------------29----------//
            //string a = File.ReadAllText("c:/A.txt");
            //string[] b = a.Split(' ');
            ////string s = Console.ReadLine();
            ////string x = s.Substring(1);
            ////Console.WriteLine(x.Remove(x.Length - 1));
            ////string x = a.Substring(b[0].Length + 1);
            ////int t = b[b.Length - 1].Length;
            ////Console.WriteLine(x.Remove(t));
            //string x = "";
            //for (int i = 1; i < b.Length-1; i++)
            //{
            //    if(b[b.Length-2]==b[i])
            //    {
            //        x += b[i];
            //    }
            //    else if(b[b.Length-2]!=b[i])
            //    {
            //       x += b[i] + " ";
            //    }
            //}
            //File.WriteAllText("c:/B.txt", x);
            //---------------30----------------//
            //string a = File.ReadAllText("c:/A.txt");
            //string b = File.ReadAllText("c:/B.txt");
            //Console.Write("k=");
            //int k = int.Parse(Console.ReadLine());
            //string c = "";
            //if(k>0 && k<2)
            //{
            // c = a + " " + b;
            //}
            //else if(k==2)
            //{
            //    c = b + " " + a;
            //}
            //File.WriteAllText("c:/C.txt", c);
            //---------------31-----------//
        
            //string a =File.ReadAllText("c:/C.txt");
            //string[]b = a.Split(' ');
            //int k=int.Parse(Console.ReadLine());
            //string x = "";
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if(i==k)
            //    {
            //        continue;
            //    }
            //    else if(i!=k)
            //    {
            //        x += b[i] + " ";
            //    }
            //}
            //Console.WriteLine(x);
            //File.WriteAllText("c:/H.txt", x);
            //----------------32----------------//
            //string a = File.ReadAllText("c:/C.txt");
            //string[] b = a.Split(' ');
            //int k = int.Parse(Console.ReadLine());
            //string x = "";
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (i == k)
            //    {
            //        x += "|"+b[i]+" ";
            //    }
            //    else if (i != k)
            //    {
            //        x += b[i] + " ";
            //    }
            //}
            //Console.WriteLine(x);
            //File.WriteAllText("c:/H.txt", x);
            //--------------------33-------------------//
            //string a = File.ReadAllText("c:/C.txt");           
            //string s = Console.ReadLine();
            //string x = "";
            //for (int i = 0; i < a.Length; i++)
            //{
            //     if(a[i]==' ')
            //     {
            //         x += s;
            //     }
            //     else if(a[i]!=' ')
            //     {
            //         x += a[i];
            //     }
            //}
            //Console.WriteLine(x);
            //File.WriteAllText("c:/H.txt", x);
            //----------------------34--------------------//
            //string a = File.ReadAllText("c:/C.txt");
            //string x = "";
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == ' ' && a[i + 1] == ' ')
            //    {
            //        x += " ";
            //    }
            //    else if (!(a[i] == ' ' && a[i - 1] == ' '))
            //    {
            //        x += a[i];
            //    }
            //}
            //Console.WriteLine(x);
            //File.WriteAllText("c:/H.txt", x);
            //----------------------35--------------//
            //string a = File.ReadAllText("c:/C.txt");
            //string x = "";

            //string[] b = a.Split(' ');
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        x += ' ';
            //    }       
            //    if(b[i].Length<60)
            //    {
            //         x += b[i] + " ";
            //    }
            //}
            //File.WriteAllText("c:/H.txt", x);
            //---------------------------36----------------//
            //string a = File.ReadAllText("c:/C.txt");
            //string x = "";
            //int l = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == ' ')
            //    {
            //        l++;
            //        if (l == 5)
            //        {
            //            x +="";
            //            l = 0;
            //        }
            //    }
            //    else if(a[i]!=' ')
            //    {
            //        x += a[i];
            //    }
            //}
            //Console.WriteLine(x);
            //File.WriteAllText("c:/H.txt", x);
            //----------------------37--------------------//
            //string a = File.ReadAllText("c:/C.txt");       
            //string []b=a.Split(' ');
            //string x="",y="",z="";
            //int t=b.Length;
            //int j = 0;
            //while(t!=0)
            //{
            //    x = b[j];
            //    for (int i = x.Length-1; i >=0; i--)
            //    {
            //        y += x[i];
            //    }
            //    z += y+' ';
            //    y = "";
            //    j++;
            //    t--;
            //}
            //Console.WriteLine(z);
            //File.WriteAllText("c:/H.txt", z);
            //-------------------39-----------------//
            string a = File.ReadAllText("c:/C.txt");
            string[] b = a.Split(' ');
            string x = "";
            int k = int.Parse(Console.ReadLine());
           
            //-----------------40-------------//
            //string a = File.ReadAllText("c:/C.txt");
            //string[] b = a.Split(' ');
            //int[] B = new int[b.Length];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    B[i] = int.Parse(b[i]);
            //   Console.Write(b[i]+"  ");
            //}
            //Console.WriteLine();
            //int max = B[0], min = B[0];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (max < B[i])
            //    {
            //        max = B[i];
            //    }
            //    if (min > B[i])
            //    {
            //        min = B[i];
            //    }
            //}
            //string x = "minimumi=" + min + " " + "maksimumi=" + max;
            //Console.WriteLine(x);
            //File.WriteAllText("c:/H.txt", x);

                Console.ReadKey();
            
        }
      /*  //------------10---------//
        public string incf(string a)
        {
            string[] Satr = a.Split(' ');   
            int[] A = new int[Satr.Length];
            for (int i = 0; i < Satr.Length; i++)
            {
                A[i] = int.Parse(Satr[i]);
            }
            Array.Sort(A);
            string x="";
            for (int i = 0; i < a.Length; i++)
            {
                x +=(int)A[i] - 48;
            }
            return x;
          
        }*/
      /*  public string Next(string a)
        {
            string x = "";
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>47 && a[i]<56 )
                {
                    x += (((int)a[i] - 48)+1);
                }
                    if(a[i]==57)
                    {
                        x += 0;
                    }
                 else if (!(a[i] > 47 && a[i] < 56))
                {
                    x += a[i];
                }                   
            }
            return x;
        }*/
    /*    public string Double(string a)
        {
            string x = "";
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]>47 && a[i]<58)
                {
                    x += 2 * ((int)a[i]-48);
                }
                else
                {
                    x += a[i];
                }
            }
            return x;
        }
        public string Add(string a,string s)
        {
            string x = s + a;
            return x;
        }
        public string AddLast(string a, string s)
        {
            string x = a+s;
            return x;
        }*/

        //----------7-----------//
       /* public string Kichik(string a)
        {
            int s = 0;
            string x = "";
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            } 
            int orta_arifmetik = s / a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<orta_arifmetik)
                {
                    x += a[i];
                }
            }
            return x;
        }*/
        //----------6-----------//
      /*  public string Fib(int n)
        {
            int[] a = new int[n];
            a[0]=a[1]=1;
            a[2]=a[0]+a[1];
           
            string s = a[0]+"-"+a[1]+"-";
            for(int i=2;i<n;i++)
            {
                    a[i] = a[1] + a[0];
                if (a[i] <n)
                {
                    a[0] = a[i - 1];
                    a[1] = a[i];
                    s += a[i] + "-";
                }               
            }
            return s;
        }*/
        //------------5-----------//
       /* public string Raqam(string s)
        {
            string t="";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>47 && s[i]<58)
                {
                    t+=s[i];
                }
            }
            return t;
        }*/
     //   ------------3-----------//
      /*  public string Tekshirish(string x,string y)
        {
            string a= "True";          
            if (File.Equals(x,y))
            {
                return a;
            }
            else 
            {
                a ="False";
            }
            return a;*/
        }
      /*  //------------2-----------//  +998943347879 // Gulshoda Jiyan
        public string Tartiblash(string s)   
        {
            string x = "true";
            int d = s[0];

            for(int i=1;i<s.Length;i++)
            {
                if(d<s[i])
                {
                    d = s[i];
                }
                else
                {
                    x = "False";
                }
            }
            return x;         
        }*/
        ////------------1-----------//
      /*  public string manfiy(string s)
        {
            int m = 0, t = s.IndexOf('-');
            string l = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-' && s[i + 1] > 47 && s[i + 1] <= 57)
                {
                    m += (int)s[i + 1] - 48;
                }
            }
            l = "-" + m;
            return l;
        }*/
        ////------------4------------//
      /*  public string Oxiridan_oldingi(string s)
        {
            string[] l = s.Split(' ');
            return l[l.Length - 2];
        }*/
    }

