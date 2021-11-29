using System;
using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão Thevennin
            //Sequência de passagem dos parâmetros: R1, R2, R3, R4, k, I, V
            QuestãoThvennin questão1 = new QuestãoThvennin(1, 23, 15, 31, 6, 0.9, 17);

            //Questão Superposição
            //Sequência de passagem dos parâmetros: R1, R2, R3, R4, Va, Vb, I
            QuestaoSuperposicao questo2 = new QuestaoSuperposicao(10908, 3556, 341, 192, 9, 14, 0.02);

            //Questão Máxima Transferência de Potência
            //Sequência de passagem dos parâmetros: R1, R2, R3, R4, Va, Vb, I
            MaxPotTransfer questo3 = new MaxPotTransfer(15, 9, 10, 13, 17, 10, 5);

            //Questão Supernó
            //Sequência de passagem dos parâmetros: R1, R2, R3, R4, K, I, Va
            Superno questo4 = new Superno(40, 5, 50, 100, 10, 4, 50);

            //Questão Ampop
            //Sequência de passagem dos parâmetros: Rf, R2, R, R6, V1, V2
            Ampop questo5 = new Ampop(26, 41, 22, 14, 82, 119);

            Console.WriteLine("Questão Thevennin");
            Console.WriteLine("Vth: " + questão1.Voltage().ToString("F2",CultureInfo.InvariantCulture) + " V");
            Console.WriteLine("Rth: " + questão1.Resistence().ToString("F2", CultureInfo.InvariantCulture) +  " Ohms");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Questão Superposição");
            Console.WriteLine("I1: " + questo2.CurrentCalculation1().ToString("F2", CultureInfo.InvariantCulture) + " mA");
            Console.WriteLine("I2: " + questo2.CurrentCalculation2().ToString("F2", CultureInfo.InvariantCulture)+ " mA");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Questão Máxima Transferência de Potência");
            Console.WriteLine("MaxPot: " + questo3.MaxPot().ToString("F3", CultureInfo.InvariantCulture) + " W");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Questão Supernó");
            Console.WriteLine("Ib: " + questo4.Ficurrent().ToString("F3", CultureInfo.InvariantCulture) + " A");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Questão Ampop");
            Console.WriteLine("V0: " + questo5.V0Calculate().ToString("F3", CultureInfo.InvariantCulture) + " V");
            Console.WriteLine("-------------------------------------------------");



        }
    }
}
