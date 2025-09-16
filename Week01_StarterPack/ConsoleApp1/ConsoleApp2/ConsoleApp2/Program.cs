using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            double op = (double)num * 3 / 2;

            if ((double)num * 3 / 2 > 5)
            {
                Console.WriteLine("Il tuo numero è maggiore di 5");
            }
            else
            {
                Console.WriteLine("Il numero è minore di 5");
            }

            switch (num * 3 / 2)
            {
                case 4:
                    Console.WriteLine("il numero è 4");
                    break;
                case 7:
                    Console.WriteLine("num maggiore di 5");
                    break;
                default:
                    Console.WriteLine("pappappero");
                    break;
            }

            if (op > 10)
            {
                op = op * 5;
            }
            else
            {
                op = op / 5;
            }

            switch (num * 3 / 2 > 10)
            {
                case true:
                    double res = num * 3 / 2 * 5;
                    break;
                default:
                    double res2 = num * 3 / 2 / 5;
                    break;
            }

            if (num < 5)
            {
                Console.WriteLine($"il numero è {num}");
            }
            else if (num > 10)
            {
                Console.WriteLine($"Il numero ora è: \n\t{num * 5}");
            }
            else
            {
                Console.WriteLine($"Il numero ora è: \n\t{num / 5}");
            }

            double num2 = 18;

            //if ( num2 == 12)
            //{
            //    num2 *= 2;
            //    Console.WriteLine($"Il numero ora è: \n\t{num2}");
            //} 
            //else if ((num2 >= 5) && (num2 <= 15))
            //{
            //    Console.WriteLine($"Il numero ora è: \n\t{num2}");
            //}
            //else if ((num2 >= 5))
            //{
            //    num2 = num2 * 10;
            //    Console.WriteLine($"Il numero ora è: \n\t{num2}");
            //}  
            //else if( num2 < 5)
            //{
            //    num2 *= 20;
            //    Console.WriteLine($"Il numero ora è: \n\t{num2}");
            //}

            //string answer = Console.ReadLine();
            //int c = int.Parse(answer);
            //int b = Convert.ToInt32(answer);
            //int a;
            //if (int.TryParse(answer, out a))
            //{
            //    if(a > 5)
            //    {
            //        Console.WriteLine($"Il numero è maggiore di 5");
            //        if (a > 15)
            //        {
            //            a *= 10; 
            //        } 
            //        else
            //        {
            //           if(a == 12)
            //           {
            //                Console.WriteLine($"Il numero è 12");
            //                a *= 2;
            //           }
            //           Console.WriteLine("Il numero è compreso tra 5 e 15");
            //        }
            //    } else
            //    {
            //        Console.WriteLine("Il numero è minore di 3");
            //        a *= 20;    
            //    }
            //    Console.WriteLine($"Il numero ora è: \n\t{a}");
            //}

            //chiedi 2 numeri all'utente e trova il maggiore

            //Console.WriteLine("Inserisci un numero");
            //int n1;
            //int n2;
            //int n3;
            //string answer1;

            //do
            //{
            //    answer1 = Console.ReadLine();
            //    if (int.TryParse(answer1, out n1))
            //    {
            //        Console.WriteLine("Inserisci un altro numero");
            //        string answer2;
            //        do
            //        {
            //            answer2 = Console.ReadLine();
            //            if (int.TryParse(answer2, out n2))
            //            {
            //                Console.WriteLine("Inserisci un altro numero");
            //                string answer3;
            //                do
            //                {
            //                    answer3 = Console.ReadLine();
            //                    if (int.TryParse(answer3, out n3))
            //                    {
            //                        if (n1 != n2 && n2 != n3 && n1 != n3)
            //                        {
            //                            //if ((n1 > n2 && n1 < n3) || (n1 < n2 && n1 > n3)) 
            //                            //{
            //                            //    Console.WriteLine($"{n1} è il valore di mezzo");                                              
            //                            //} 
            //                            //else if ((n2 > n1 && n2 < n3) || (n2 < n1 && n2 > n3))
            //                            //{
            //                            //    Console.WriteLine($"{n2} è il valore di mezzo");
            //                            //}
            //                            //else
            //                            //{
            //                            //    Console.WriteLine($"{n3} è il valore di mezzo");
            //                            //}

            //                            if(n1 > n2)
            //                            {
            //                                if (n2 > n3)
            //                                {
            //                                    Console.WriteLine($"{n2} è in mezzo");
            //                                }
            //                                else
            //                                {
            //                                    if(n1 > n3)
            //                                    {
            //                                        Console.WriteLine($"{n3} è in mezzo");
            //                                    }
            //                                    else
            //                                    {
            //                                        Console.WriteLine($"{n1} è in mezzo");
            //                                    }                                                 
            //                                }
            //                            }
            //                            else
            //                            {
            //                                if (n1 > n3)
            //                                {
            //                                    Console.WriteLine($"{n1} è in mezzo");
            //                                }
            //                                else
            //                                {
            //                                    if (n2 > n3)
            //                                    {
            //                                        Console.WriteLine($"{n3} è in mezzo");
            //                                    }
            //                                    else
            //                                    {
            //                                        Console.WriteLine($"{n2} è in mezzo");
            //                                    }
            //                                }
            //                            }
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("due o più numeri sono uguali");
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Non hai inserito un numero.Riprova");
            //                    }
            //                } while (!int.TryParse(answer3, out n3));


            //            }
            //            else
            //            {
            //                Console.WriteLine("Non hai inserito un numero.Riprova");
            //            }

            //        } while (!int.TryParse(answer2, out n2));

            //    }
            //    else
            //    {
            //        Console.WriteLine("Non hai inserito un numero. Riprova");
            //    }
            //} while (!int.TryParse(answer1, out n1));

            //Console.WriteLine("Inserisci un numero");
            //int n1;
            //int n2;
            //int n3;
            //string answer1 = Console.ReadLine();
            //if(int.TryParse(answer1, out n1))
            //{
            //    string answer2 = Console.ReadLine();
            //    if (int.TryParse(answer2, out n2))
            //    {
            //        string answer3 = Console.ReadLine();
            //        if (int.TryParse(answer3, out n3))
            //        {
            //            if(n1 < n2)
            //            {
            //                if(n1 < n3)
            //                {
            //                    Console.Write($"{n1}, ");
            //                    if(n2 < n3)
            //                    {
            //                        Console.WriteLine($"{n2}, {n3}");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine($"{n3}, {n2}");
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{n3}, {n1}, {n2}");
            //                }
            //            }
            //            else
            //            {
            //                if (n2 < n3)
            //                {
            //                    Console.Write($"{n2}, ");
            //                    if (n1 < n3)
            //                    {
            //                        Console.WriteLine($"{n1}, {n3}");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine($"{n3}, {n1}");
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{n3}, {n2}, {n1}");
            //                }
            //            }

            //        }
            //    }
            //}

            // dato un numero fa il fattoriale
            //Console.WriteLine("Inserisci un numero");
            //string ans = Console.ReadLine();
            //int n = 1;
            //int input;
            //if(int.TryParse(ans, out input))
            //{
            //    for (int i = 1; i <= input; i++)
            //    {
            //        n *= i;
            //        Console.WriteLine(n.ToString());
            //    }
            //}

            // dato una parola stampare tutte le lettere una dopo l'altra
            Console.WriteLine("Inserisci una parola");
            string word = Console.ReadLine();
            for(int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }

            // trova se la parola è palindroma
            bool isPal = true;
            for(int i = 0, j = word.Length-1; i < word.Length/2; i++, j--)
            {
                if (word[i] != word[j])
                {
                    isPal = false;
                    break;
                }
                //isPal &= word[i] != word[j];

            }
            Console.WriteLine(isPal);

            // data una parola e una lettera trovare quante volte compare nella parola
            Console.WriteLine("inserisci lettera");
            char letter = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    count++;
                }
            }
            Console.WriteLine(count.ToString());

            //foreach(char c in word)
            //{
            //    if(c == letter)
            //    {
            //        count++;
            //    }
            //}

            //dato un numero restituirlo al contrario
            Console.WriteLine("inserisci un numero");
            string ans = Console.ReadLine();
            int input;
            if (int.TryParse(ans, out input))
            {
                //for (int i = 0, j = ans.Length-1; i <= ans.Length/2; i++, j--)
                //{
                //    char temp = ans[i];
                //    ans[i] = ans[j];
                //    ans[j] = temp;

                //}
                for(int i = ans.Length-1; i > 0; i--)
                {
                    Console.WriteLine(ans[i]);
                }
                Console.WriteLine(ans);
            }

        }
    }
}
