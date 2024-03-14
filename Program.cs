namespace LB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            

            Console.WriteLine("Enter a number 1 to 4:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                switch (number)
                {
                    case 1:
                        Employee obj1 = new Employee { Salary = 3000 };
                        Employee obj2 = new Employee { Salary = 4000 };
                        Employee obj3 = obj1 + 500;

                        Employee obj4 = obj2 - 1000;
                        Console.WriteLine($"Salary1: {obj1.Salary}");
                        Console.WriteLine($"Salary2: {obj2.Salary}");
                        Console.WriteLine($"obj1 + 500: {obj3.Salary}");
                        Console.WriteLine($"obj2 - 1000: {obj4.Salary}");
                        Console.WriteLine($"obj1 != obj2: {obj1 != obj2}");
                        Console.WriteLine($"obj1 == obj3: {obj1 == obj3}");
                        Console.WriteLine($"obj2 > obj1: {obj2 > obj1}");
                        Console.WriteLine($"obj1 < obj4: {obj1 < obj4}");
                        Console.WriteLine($"obj2.Equals(obj3): {obj2.Equals(obj3)}");
                        break;
                    case 2:
                        Console.WriteLine("Default matrix1: ");
                        matrix1.PrintMatrix();

                        Console.WriteLine("Default matrix2: ");
                        matrix2.PrintMatrix();

                        Matrix sum = matrix1 + matrix2;
                        Console.WriteLine("Matrix sum:");
                        sum.PrintMatrix();

                        Matrix difference = matrix1 - matrix2;
                        Console.WriteLine("\nMatrix difference:");
                        difference.PrintMatrix();

                        Matrix product = matrix1 * matrix2;
                        Console.WriteLine("\nMatrix product:");
                        product.PrintMatrix();

                        int scalar = 2;
                        Matrix scaled = matrix1 * scalar;
                        Console.WriteLine($"\nMatrix scaled by {scalar}:");
                        scaled.PrintMatrix();

                        Console.WriteLine("\nMatrix comparison:");
                        Console.WriteLine($"matrix1 == matrix2: {matrix1 == matrix2}");
                        Console.WriteLine($"matrix1 != matrix2: {matrix1 != matrix2}");
                        break;
                    case 3:

                        City city1 = new City { Name = "Kyiv", Country = "Ukraine", Population = 3000000, Area = 839.1 };
                        City city2 = new City { Name = "New York", Country = "USA", Population = 8000000, Area = 783.8 };
                        Console.WriteLine("City 1:");
                        city1.PrintCityInfo();
                        Console.WriteLine("\nCity 2:");
                        city2.PrintCityInfo();

                        City city3 = city1 + 500000;
                        City city4 = city2 - 2000000;

                        Console.WriteLine("\nCity 3 (after population increase):");
                        city3.PrintCityInfo();
                        Console.WriteLine("\nCity 4 (after population decrease):");
                        city4.PrintCityInfo();

                        Console.WriteLine("\nCity 1 and City 2 population equality check:");
                        Console.WriteLine(city1 == city2);
                        Console.WriteLine("\nCity 3 and City 4 population inequality check:");
                        Console.WriteLine(city3 != city4);
                        Console.WriteLine("\nCity 1 population greater than City 2 population check:");
                        Console.WriteLine(city1 > city2);
                        Console.WriteLine("\nCity 1 population less than City 2 population check:");
                        Console.WriteLine(city1 < city2);
                    default:
                        Console.WriteLine("You entered another number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect number format!");
            }
            
        }
    }
}
