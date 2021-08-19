using System;

namespace HelloWorld {
    class MyClass
{
 readonly int X = 10; // Khởi tạo lúc khai báo
 readonly int X1;

 public MyClass(int x1)
 {
 X1 = x1; // khởi tạo lúc chạy, không có lỗi
 Console.WriteLine(X);
 Console.WriteLine(X1);
 }
}

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello C#");

            int x1=1, y1=1;
            const int x2=1, y2=1;
            // const int COUNT1= x1+y1;// bão lỗi 
            const int COUNT2= x2+y2;// không báo lỗi

            MyClass myClass = new MyClass(1);
            
            
        }
    }
}