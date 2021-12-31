using System;
using System.Globalization;
using InterfaceExercise.Entity;
using InterfaceExercise.Service;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(contractNumber, contractDate, contractValue);
            Console.WriteLine();

            Console.Write("Enter number of installments: ");
            int numberOfInstallment = int.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(numberOfInstallment, new PayPalService());
            contractService.ProcessContract(contract);

            Console.WriteLine();

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.listOfInstallmente)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
