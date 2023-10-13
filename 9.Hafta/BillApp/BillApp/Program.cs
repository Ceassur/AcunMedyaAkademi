namespace BillApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Transactions transactions = new Transactions();

            while (true)
            {
                Console.Write("Ad Soyad: ");
                string fullName = Console.ReadLine();

                Console.Write("TC Kimlik Numarası: ");
                string tc = Console.ReadLine();

                Console.Write("Fatura Türü: ");
                string billType = Console.ReadLine();

                Console.Write("Borç Tutarı: ");
                double debtAmount = Convert.ToDouble(Console.ReadLine());

                transactions.AddBill(fullName, tc, billType, debtAmount);

                Console.Write("Başka kullanıcı var mı? (EVET/HAYIR): ");
                string devam = Console.ReadLine();
                if (devam.ToUpper() != "EVET")
                {
                    break;
                }
            }

            Console.WriteLine($"Toplam Fatura Borcu: {transactions.TotalDebt()} TL");
            transactions.PeoplesDebts();

            while (true)
            {
                Console.Write("Ödeme yapmak istediğiniz kişinin TC Kimlik Numarasını girin (Çıkmak için 'q' girin): ");
                string tc = Console.ReadLine();
                if (tc == "q")
                {
                    break;
                }
                transactions.Pay(tc);
            }

            transactions.PeoplesNoDebt();
        }
    }
}