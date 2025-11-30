using System;

class Program {
        public static void Main() {
            Console.Write("Enter Inductance, L = ");
            double L = double.Parse(Console.ReadLine());
            Console.Write("Enter Registance, R = ");
            double R = double.Parse(Console.ReadLine());

            for (double C=0.01; C<=0.1; C+=0.01) {
				double first = 1 / (L * C) ;
				double second = (R * R) / (4 * C * C) ;
				double diff = first - second;
				double ans = Math.Sqrt(diff) ;
                Console.WriteLine("Frequency at Capacitance = {0} is {1}", C, ans);
            }
        }
}