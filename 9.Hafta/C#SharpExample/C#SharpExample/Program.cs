namespace C_SharoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Casting

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine("Convert Kullanmak");
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            #endregion

            #region Explicit Casting
            // Büyük veri tipini küçük veri tipine önüştürmek için (küçük_veri_tipi) kullanılır.
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble;    // Manual casting: double to int
            Console.WriteLine("Convert Kullanmak");
            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9

            #endregion

            #region Type Conversion Methods
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;
            Console.WriteLine("Convert Kullanmak");
            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            #endregion

            #region Double To int and string
            double myDouble4 = 3.14;
            int myInt4 = (int)myDouble4;
            Console.WriteLine("Convert Kullanmak");
            Console.WriteLine(Convert.ToInt32(myDouble4));
            Console.WriteLine(myInt4);
            Console.WriteLine("Convert Kullanmak");
            Console.WriteLine(Convert.ToString(myDouble4));
            #endregion

            #region String To İnt and Double
            string myString = "4,13";
            //int myInt5 = (int)myString; stringi bu şekilde cast etmek mümkün değil
            //Console.WriteLine("Convert Kullanmak");
            //Console.WriteLine(Convert.ToInt32(myString));
            //Console.WriteLine(Convert.ToDouble(myString));
            #endregion

            #region Atama Operatörleri
            int x = 5;
            x *= 3;
            x = x * 3;
            Console.WriteLine("Atama Operatörü Kullanımı ");
            Console.WriteLine(x);
            #endregion

            #region C# Switch Kullanımı 
            Console.WriteLine("1 - 7 arasında bir sayı giriniz");
            
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                    Console.ReadLine();
            }


            #endregion

            #region C# Break and Continue Using
            // Break komutu kodun istediğimiz durumda döngüden çıkmasını sağlar.
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            #endregion

            #region C# Abstraction / Soyutlamak

            #endregion

        }
    }
}