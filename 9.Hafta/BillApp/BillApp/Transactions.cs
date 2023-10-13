using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillApp
{
    internal class Transactions : IPay
    {
        private List<Bill> Bills = new List<Bill>();
        private Dictionary<string, List<double>> Persons = new Dictionary<string, List<double>>();

        public void AddBill(string fullName, string tc, string billType, double debtAmount)
        {
            Bills.Add(new Bill { FullName = fullName, TC = tc, BillType = billType, DebtAmount = debtAmount });

            if (Persons.ContainsKey(tc))
            {
                Persons[tc].Add(debtAmount);
            }
            else
            {
                Persons[tc] = new List<double> { debtAmount };
            }
        }

        public double TotalDebt()
        {
            double sum = 0;
            foreach (var Bill in Bills)
            {
                sum += Bill.DebtAmount;
            }
            return sum;
        }

        public void PeoplesDebts()
        {
            foreach (var kvp in Persons)
            {
                string tc = kvp.Key;
                double TotalDebt = kvp.Value.Sum();
                Console.WriteLine($"{tc} TC Kimlik Numarasına Sahip Kişinin Toplam Borcu: {TotalDebt} TL");
            }
        }

        public void Pay(string tc)
        {
            if (Persons.ContainsKey(tc))
            {
                double TotalDebt = Persons[tc].Sum();
                Console.WriteLine($"{tc} TC Kimlik Numarasına Sahip Kişi için {TotalDebt} TL Ödeme Yapıldı.");
                Persons[tc].Clear();
            }
            else
            {
                Console.WriteLine($"{tc} TC Kimlik Numarasına Sahip Kişiye Ait Borç Bulunamadı.");
            }
        }

        public void PeoplesNoDebt()
        {
            var PaySuccessPeoples = Persons.Where(kvp => kvp.Value.Count == 0).Select(kvp => kvp.Key).ToList();

            if (PaySuccessPeoples.Count > 0)
            {
                Console.WriteLine("Borcu Ödenen Kişiler:");
                foreach (var tc in PaySuccessPeoples)
                {
                    Console.WriteLine(tc);
                }
            }
            else
            {
                Console.WriteLine("Borcu Ödenen Kişi Bulunmamaktadır.");
            }
        }

      

        public void Pay(double Amount)
        {
            throw new NotImplementedException();
        }
    }

}

