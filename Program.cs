//Task1
// void Univ(int a)
// {
//     int evencount = 0;
//     int oddcount = 0;
//     int zerocount = 0;
//     int digitcount = 0;
//     int sumdigit = 0;
//     int cnt = 0;
//     int mn = 999999;
//     int mx = -99999;
//     while (a != 0)
//     {
//         cnt = a % 10;
//         if (cnt % 2 == 0)
//         {
//             evencount++;
//         }
//         if (cnt % 2 != 0)
//         {
//             oddcount++;
//         }
//         if (cnt == 0)
//         {
//             zerocount++;
//         }
//         digitcount++;
//         if (cnt < mn)
//         {
//             mn = cnt;
//         }
//         if (cnt > mx)
//         {
//             mx = cnt;
//         }
//         sumdigit += cnt;
//         a = a / 10;
//     }
//     System.Console.WriteLine($"Even: {evencount}");
//     System.Console.WriteLine($"Odd: {oddcount}");
//     System.Console.WriteLine($"Zeros: {zerocount}");
//     System.Console.WriteLine($"Digits: {digitcount}");
//     System.Console.WriteLine($"Min: {mn}");
//     System.Console.WriteLine($"Max: {mx}");
//     System.Console.WriteLine($"Sum of Digits: {sumdigit}");
// }

// int a = Convert.ToInt32(Console.ReadLine());
// Univ(a);

//Task2
// void Grade(int a)
// {
//     if (a >= 90 && a <= 100)
//     {
//         System.Console.WriteLine("A");
//     }
//     if (a >= 80 && a <= 89)
//     {
//         System.Console.WriteLine("B");
//     }
//     if (a >= 70 && a <= 79)
//     {
//         System.Console.WriteLine("C");
//     }
//     if (a >= 60 && a <= 69)
//     {
//         System.Console.WriteLine("D");
//     }
//     if (a >= 0 && a <= 59)
//     {
//         System.Console.WriteLine("F");
//     }
//     else
//     {
//         System.Console.WriteLine("Sorry? But Grade Ball Not Added In International School, Please Past The Grades in Second Categories: ");
//         System.Console.WriteLine("Grade A: 90-100");
//         System.Console.WriteLine("Grade B: 80-89");
//         System.Console.WriteLine("Grade C: 70-79");
//         System.Console.WriteLine("Grade D: 60-69");
//         System.Console.WriteLine("Grade F: 0-59");
//     }
// }
// int a = Convert.ToInt32(Console.ReadLine());
// Grade(a);

// Task3
// int[] arr = new int[6];
// int Negative = 0;
// int Positive = 0;
// int Zeros = 0;
// int Even = 0;
// int Odd = 0;
// int Max = -99999;
// int Min = 99999;
// int Sum = 0; 
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 0)
//     {
//         Negative++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] >= 0)
//     {
//         Positive++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == 0)
//     {
//         Zeros++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0 && arr[i] != 0)
//     {
//         Even++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 != 0)
//     {
//         Odd++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > Max)
//     {
//         Max = arr[i];
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < Min)
//     {
//         Min = arr[i];
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     Sum += arr[i];
// }
// System.Console.WriteLine("Negative = " + Negative);
// System.Console.WriteLine("Positive = " + Positive);
// System.Console.WriteLine("Zeros = " + Zeros);
// System.Console.WriteLine("Even = " + Even);
// System.Console.WriteLine("Odd = " + Odd);
// System.Console.WriteLine("Max = " + Max);
// System.Console.WriteLine("Min = " + Min);
// System.Console.WriteLine("Sum = " + Sum);



// Task4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (i % 2 == 0)
//     {
//     System.Console.Write(arr[i] + " ");
//    }
// }

// Task5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] > arr[i - 1])
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);




// Task6
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i != j && arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//             break; 
//         }
//     }
// }




// Task7
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// for (int i = a; i <= b; i++)
// {
//     Console.WriteLine("-------------------------------");
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}x{j}= {i * j}");
//     }
// }

//Task8
// System.Console.Write($"The first number is: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"The operation is: ");
// string b = Console.ReadLine();
// System.Console.Write($"The second number is: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (b == "+")
// {
//     System.Console.WriteLine($"{a} + {c} = {a + c}");
// }
// if (b == "-")
// {
//     System.Console.WriteLine($"{a} - {c} = {a - c}");
// }
// if (b == "*")
// {
//     System.Console.WriteLine($"{a} * {c} = {a * c}");
// }
// if (b == "/")
// {
//     System.Console.WriteLine($"{a} / {c} = {a / c}");
// }