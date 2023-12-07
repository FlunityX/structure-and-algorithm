using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace list
{
    struct point
    {
        public int x;
        public int y;
        public int z;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<point> points = new List<point>();
            nhapthongtin(points);
            xuatthongtin(points);
            Console.ReadLine();
            
        }
        public static void nhapthongtin(List<point> points)
        {
            point pt1 = new point();
            Console.WriteLine(" nhap so lg point can luu tru ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine(" nhap diem x ");
                pt1.x = int.Parse(Console.ReadLine());
                Console.WriteLine(" nhap diem y ");
                pt1.y = int.Parse(Console.ReadLine());
                Console.WriteLine(" nhap diem z ");
                pt1.z = int.Parse(Console.ReadLine());
                points.Add(pt1);
            } }
      public static void xuatthongtin(List<point> points)
            {
                Console.WriteLine("danh sach cac diem point :");
                for(int i = 0;i< points.Count; i++) {
                    point point = points[i];
                    Console.WriteLine(" diem x :" + point.x);
                    Console.WriteLine("diem y " + point.y); Console.WriteLine("diem z " + point.z);
                    Console.WriteLine();
                }

            }
            }

    }
