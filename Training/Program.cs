using System;
using System.Collections.Generic;

namespace Training
{
    class Program
    {
        class CodeToRunA
        {
            public CodeToRunA()
            {
                CodeToRun001(); CodeToRun002(); CodeToRun003(); CodeToRun004(); CodeToRun005(); CodeToRun006();
            }

            public void CodeToRun001()
            {
                ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.Red;
                ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;

                Console.Write("Strings:\t");
                string songLyrics = "You say goodbye, and I say hello";
                string hLit = "Hello", sp4 = "    ", wLit = "World!", faLit = "This is freaking AWESOME!", greet = "    Hello World!    ";
                Console.Write($"{  songLyrics.Contains("goodbye")}, ");
                Console.Write($"{songLyrics.Contains("greetings")}, ");
                Console.Write($"{songLyrics.StartsWith("goodbye")}, ");
                Console.Write($"{songLyrics.EndsWith("greetings")}, ");
                string greeting = sp4 + hLit + " " + wLit + sp4;
                Console.Write($"{(greet == greeting ? "==" : "!=")}, ");
                Console.Write($"{greet.Trim()} {faLit}, ");
                Console.Write($"[{greet.TrimStart()}]={greet.TrimStart().Length.ToString()}, ");
                Console.Write($"{greet.Replace("Hello", "Greetings").ToUpper().Trim()}\n");

                Console.ForegroundColor = ForeGroundDefault; Console.BackgroundColor = BackGroundDefault;

            }
            public void CodeToRun002()
            {
                /* The following code works but i commented it out becasue i didnt want a 1K copies of it in edge opening while i was testing
                string GoodSite = @"https://docs.microsoft.com/en-us/dotnet/csharp/how-to/#working-with-strings"; //@ is extra (no spaces)!
                string MSEdge = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";    // @ MUST HAVE!
                ProcessStartInfo startInfo = new ProcessStartInfo(MSEdge, GoodSite);
                Process.Start(startInfo);*/
                ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.Blue;
                ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;

                string Title = "Integers:"; int a = 18, b = 6, c = a + b, d = a - b, e = a * b, f = a / b;
                Console.Write($"{Title}, 18+6={c}, 18-6={d}, 18*6={e}, 18/6={f}, ");
                int aa = 5, bb = 4, cc = 2, dd = (aa + bb) * cc;
                int ee = (aa + bb) - 6 * cc + (12 * 4) / 3 + 12;
                Console.Write($"(5+4)*2={dd}, (5+4)-6*2+(12*4)/3+12={ee}\n");
                int a1 = 7, b2 = 4, c3 = 3, d4 = (a1 + b2) / c3;
                Console.Write($"(7+4)/3={d4}!, so, ");
                int p = (a1 + b2) / c3, q = (a1 + b2) % c3;
                Console.Write($"quotient={p}, & remainder={q}; ");
                int max = int.MaxValue, min = int.MinValue, what = max + 3;
                Console.Write($"Integers from {min} to {max}, ");
                Console.Write($".MaxValue+3=Overflow: {what}\n");
                double az = 5, bz = 4, cz = 2, dz = (az + bz) / cz;
                Console.Write($"Doubles: (5+4)/2={dz}, ");
                double ax = 19, bx = 23, cx = 8, dx = (ax + bx) / cx, maxx = double.MaxValue, minx = double.MinValue, third = 1.0d / 3.0d;
                Console.Write($"(19+23)/8={dx}, 1/3={third}, and Range: {minx} to {maxx}\n");
                decimal cu = 1.0M, du = 3.0M, mina = decimal.MinValue, maxa = decimal.MaxValue;
                Console.Write($"Decimal: 1.0M/3.0M={cu / du}, The range of the decimal type is {mina} to {maxa}, ");
                #region double Challenge area of a circle 
                /*The M suffix on the numbers is how you indicate that a constant should use the decimal type. 
                 * Otherwise, the compiler assumes the double type. Note: The letter M was chosen as the most visually distinct letter between the double and decimal keywords.
                 * Challenge: Now that you've seen the different numeric types, write code that calculates the area of a circle 
                 * whose radius is 2.50 centimeters. Remember that the area of a circle is the radius squared multiplied by PI. 
                 * One hint: .NET contains a constant for PI, Math.PI that you can use for that value. Math.PI, 
                 * like all constants declared in the System.Math namespace, is a double value. For that reason, you should use 
                 * double instead of decimal values for this challenge. You should get an answer between 19 and 20. Try the code in your browser*/
                #endregion
                double radius = 2.50d, area = Math.PI * radius * radius;
                Console.Write($"double Challenge area of a circle(pi*r*r={radius})={area}\n");

                Console.ForegroundColor = ForeGroundDefault; Console.BackgroundColor = BackGroundDefault;
            }
            public void CodeToRun003()
            {
                ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.Green;
                ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;

                int ar = 5, br = 10;
                List<int> listi = new List<int> { 6, 3 }; Console.Write("foreachList");
                foreach (int pop in listi)
                {                    Console.Write($"The answer({ar+pop}) is {(ar + pop > br ? "greater" : "less")} than {br}.\t");                                 }
                int a = 5, b = 6;
                if (a + b > br)                    Console.Write($"The answer({a+b}) is greater than {br}.\t"); b = 3;
                if (a + b > br)                    Console.Write($"The answer({a+b}) is greater than {br}.\t");
                int c = 5, d = 3, e = 4;
                Console.Write($"The answer({c + d}) is {(c + d > br ? "greater" : "less")} than {br}.\t");
                Console.Write($"The answer({c + d}) is {(c + d > br ? "greater" : "not greater")} than {br}.\t");
                if ((c + d + e > br) && (c == d))
                {     Console.Write($"The answer({c+d+e}) is greater than {br}, And the first number({c}) is equal to the second({d}).\t");                }
                else{ Console.Write($"The answer({c+d+e}) is not greater than {br}, Or the first number({c}) is not equal to the second({d}).\t");                }
                if ((c + d + e > br) || (c == d))
                {     Console.Write($"The answer({c+d+e}) is greater than {br}, Or the first number({c}) is equal to the second({d}).\t");                }
                else{ Console.Write($"The answer({c+d+e}) is not greater than {br}, Or the first number({c}) is not equal to the second({d}).\t");                }
                Console.Write($"\nwhile<{br}:      \t");
                int counter = 0;
                while (counter < br)
                {
                    Console.Write($"{counter++}!, ");
                }
                Console.Write($"\ndo while<{br}:   \t"); counter = 0;
                do
                {
                    Console.Write($"{counter++}!, ");
                } while (counter < br);
                Console.Write($"\nfor<{br*2}:        \t");
                for (int count = br; count < (br*2); count++)
                {
                    Console.Write($"{count}!, ");
                }
                Console.Write($"\nfor<11Row:     \t");
                for (int row = 1; row < 11; row++)
                {
                    Console.Write($"Row{row}, ");
                }
                Console.Write("\nfor<kCol:      \t");
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.Write($"Col{column}, ");
                }
                Console.Write("\t\tfor<11:: for<k:\n");
                for (int row = 1; row < br; row++)
                {
                    for (char column = 'a'; column < 'j'; column++)
                    {
                        Console.Write($"({row},{column}), ");
                    }
                    Console.WriteLine();
                }
                int sum = 0; Console.Write("SUM: divisible by 3<21: ");
                for (int i = 1; i < 21; i++)
                {
                    if (i % 3 == 0) sum = sum + i;
                }
                Console.Write(sum + "\n");

                Console.ForegroundColor = ForeGroundDefault; Console.BackgroundColor = BackGroundDefault;
            }
            public void CodeToRun004()
            {
                ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.DarkYellow;
                ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;

                Console.Write($"Collections:<List>");
                var names = new List<string> { "Brice", "Ana", "Felipe" };                WriteStrList(names);
                names.Add("Maria");
                names.Add("Bill"); Console.Write("I've removed Ana from the List, and ");
                names.Remove("Ana"); 
                Console.Write($"I've added {names[2]} and {names[3]} to the list. The list has {names.Count} people in it. My name is {names[0]}. \t");
                var index = names.IndexOf("Felipe");
                if (index != -1)
                    Console.Write($"The name {names[index]} is at index {index}, ");
                var notFound = names.IndexOf("Not Found");
                Console.Write($"When an item is not found, IndexOf returns {notFound}\t"); 
                Console.Write("Before Sort: "); WriteStrList(names); names.Sort();    Console.Write("After Sort: ");            WriteStrList(names);
                var fibonacciNumbers = new List<int> { 1, 1 }; int previous, previous2;
                Console.Write("\t\tFirst 20 FibonacciNumbers\t");
                while (fibonacciNumbers.Count < 20)
                {
                    previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                    fibonacciNumbers.Add(previous + previous2);
                }
                foreach (var item in fibonacciNumbers)
                    Console.Write($"{item}, ");

                Console.ForegroundColor = ForeGroundDefault; Console.BackgroundColor = BackGroundDefault;

                static void WriteStrList(List<string> names)
                {
                    foreach (var name in names)
                    { Console.Write($"Hello {name.ToUpper()}!  "); }
                }
            }
            public void CodeToRun005() { }
            public void CodeToRun006() { }
        }
        static class CodeRunnerA
        {
            public static void CodeRunner001()
            {
                CodeToRunA codeToRunA = new CodeToRunA();
            }
            #region objectInitializerText
            //  "To create a property, use the same syntax as for fields, but add a get; to generate a getter 
            //  and a set; to generate a setter. Then use the property the same as you do a field." 
            //      class Student
            //      {
            //          public int Age { get; set; }
            //          public string Name { get; private set; }
            //  
            //          public Student() // Empty constructor
            //          {}

            //          var student = new Student
            //          {
            //              Age = 20, // Work with Age just like a public field
            //              Name = "John" // ERROR: setter for the Name is private
            //          };

            //  Using classic approach
            //          var student = new Student();
            //          student.Age = 20; // Work with Age just like a public field
            //          student.Name = "John" // ERROR: setter for the Name is private

            //  Using a constructor that sets age
            //          var student = new Student(20, "John");
            //      }
            //  }
            //  "Is this clear?" Noname asked.  "What type can the property have?" I asked.
            //  "There are no limitations to a property's type. Think of it as a field 
            //  with 2 additional methods - get and set."  "Got it," I said confidently, 
            //  hoping that the lesson in class would clear it up a bit more. 
            //  "Note that getters and setters are public by default unless you use a private keyword. 
            //  Here are some exercises for you." 
            #endregion
        }

        private static void RunBank()
        {
            Account account = new Account("BBU", 10000); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine($"account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.Withdrawal(100, DateTime.Now, "Hammock");
            account.Withdrawal(10, DateTime.Now, "Knit Hat");
            account.Withdrawal(20, DateTime.Now, "Dinner");
            account.Deposit(100, DateTime.Now, "Job");
            account.Deposit(-1, DateTime.Now, "Test");
            account.Withdrawal(30, DateTime.Now, "Sheets, Towels");
            account.Withdrawal(70, DateTime.Now, "Blender");
            account.Withdrawal(80, DateTime.Now, "Groceries");
            account.Withdrawal(2000000, DateTime.Now, "Groceries");
            account.Withdrawal(10, DateTime.Now, "Christmas Music");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"car".Pascalize().Pluralize());
            account.GetAccountHistory();
            // this abends bank:account.Deposit(-300, DateTime.Now, "Stealling Home");
        }
        static void Main(string[] args)
        {
            /*		Console.BackgroundColor = ConsoleColor.Blue;
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("White on blue.");*/
            ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.White;
            ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;
            CodeRunnerA.CodeRunner001(); RunBank();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

    }
}
