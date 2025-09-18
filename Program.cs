using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

            //// dato una parola stampare tutte le lettere una dopo l'altra
            //Console.WriteLine("Inserisci una parola");
            //string word = Console.ReadLine();
            //for(int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}

            //// trova se la parola è palindroma
            //bool isPal = true;
            //for(int i = 0, j = word.Length-1; i < word.Length/2; i++, j--)
            //{
            //    if (word[i] != word[j])
            //    {
            //        isPal = false;
            //        break;
            //    }
            //    //isPal &= word[i] != word[j];

            //}
            //Console.WriteLine(isPal);

            //// data una parola e una lettera trovare quante volte compare nella parola
            //Console.WriteLine("inserisci lettera");
            //char letter = Convert.ToChar(Console.ReadLine());
            //int count = 0;
            //for(int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count.ToString());

            //foreach(char c in word)
            //{
            //    if(c == letter)
            //    {
            //        count++;
            //    }
            //}

            ////dato un numero restituirlo al contrario
            //Console.WriteLine("inserisci un numero");
            //string ans = Console.ReadLine();
            //int input;
            //int[] nums = new int[ans.Length];
            //if (int.TryParse(ans, out input))
            //{
            //    for (int i = 0, j = nums.Length - 1; i <= nums.Length / 2; i++, j--)
            //    {
            //        int temp = nums[i];
            //        nums[i] = nums[j];
            //        nums[j] = temp;
            //        Console.Write(nums[i]);
            //    }
            //    //for(int i = ans.Length-1; i >= 0; i--)
            //    //{
            //    //    Console.Write(ans[i]);
            //    //}
            //}

            ////dato un numero, stamparlo al contrario, restituire la moltiplicazione delle sue cifre e il fattoriale delle sue singole unità
            //Console.WriteLine("inserisci un numero");
            //string ans2 = Console.ReadLine();
            //int input2;
            //int mult = 1;
            //string reverse = "";
            //int[] nums2 = new int[ans2.Length];
            //if (int.TryParse(ans2, out input2))
            //{
            //    for (int i = ans2.Length - 1, k = 0; i >= 0; i--, k++)
            //    {   
            //        nums2[k] = ans2[i] - '0';
            //        reverse += ans2[i];
            //        mult *= nums2[k];
            //        int fact = 1;
            //        for (int j = 1; j < nums2[k] + 1; j++)
            //        {
            //            fact *= j;
            //            Console.WriteLine(fact.ToString());
            //        }
            //        Console.WriteLine($"Il fattoriale di {nums2[k]} è {fact}");
            //        Console.WriteLine("-------");
            //    }
            //    Console.WriteLine(reverse);
            //    Console.WriteLine($"\nle cifre moltiplicate fanno {mult}"); 
            //}

            //// la console si apre e dà una scelta di oggetti in vendita (3/4 ogg)
            //// far scegliere uno tra gli oggetti (sel 1/2/3/4)
            //// fare reverse della scelta dell'utente
            //// l'utente inserisce una lettera sola e va inserita in mezzo alla parola invertita

            //string[] inventario = { "penne", "fogli", "matita", "gomme" };
            //Console.WriteLine($"Scegli un oggetto dall'inventario:");
            //string reverse2 = "";
            //for (int i = 0; i < inventario.Length; i++)
            //{
            //    Console.WriteLine($"\t{i+1}) {inventario[i]}");
            //}
            //string s = Console.ReadLine();
            //bool validNum = int.TryParse(s, out int scelta);
            //Console.WriteLine("scegli una lettera");
            //string s2 = Console.ReadLine();
            //string newWord = "";
            //if (validNum && (scelta > 0 && scelta < inventario.Length) && char.TryParse(s2, out char letter)){
            //    for(int i = inventario[scelta-1].Length-1; i >= 0; i--)
            //    {
            //        if(i == inventario[scelta - 1].Length / 2)
            //        {
            //            newWord += letter;
            //        }
            //        newWord += inventario[scelta - 1][i];
            //    }

            //    Console.WriteLine(newWord);
            //}

            //Console.WriteLine("Scegli un'altra lettera");
            //char c = (char)Console.Read();
            //int remove = 0;
            //char[] charArr = new char[newWord.Length];
            //string check = "";
            //bool isPresent = false;
            //for (int i = 0; i < newWord.Length; i++)
            //{
            //    //if (newWord[i] != c)
            //    //{
            //    //    charArr[remove] = newWord[i];
            //    //    remove++;
            //    //}

            //    if (newWord[i] != c)
            //    {
            //        check += newWord[i];
            //    } else
            //    {
            //        isPresent = true;
            //    }

            //}
            ////string fromChar = new string(charArr);
            ////if(remove != 0)
            ////{
            ////    fromChar = c + fromChar + c;
            ////}
            ////Console.WriteLine(fromChar);
            //if (!isPresent)
            //{
            //    check = c + check + c;
            //}
            //Console.WriteLine(check);

            //lista di prezzi con decimali
            //scegliere una percentuale di tassa
            //fare scegliere due prezzi scelti dall'utente
            //calcolare il costo totale degli oggetti scelti, il costo totale della tassa, la somma dei due oggetti tassati

            //double[] prices = { 10.50, 8.20, 22.70, 16.10 };
            //int taxPercentage = 50;
            //string opt = "";
            //double totalBase = 0;
            //double tax = 0;
            //double totalWithTax = 0;
            //int maxOpt = 0;
            //do
            //{
            //    Console.WriteLine("Scegli un prezzo dalla lista:");
            //    for(int i = 0; i < prices.Length; i++)
            //    {
            //        Console.WriteLine($"\t{i + 1}) {prices[i]}");
            //    }
            //    string a1 = Console.ReadLine();
            //    int price1;
            //    if(int.TryParse(a1, out price1) && (price1 > 0 && price1 <= prices.Length))
            //    {
            //        maxOpt++;
            //        totalBase += prices[price1-1];

            //        if(maxOpt > prices.Length)
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine("totale attuale: " + totalBase);
            //    Console.WriteLine("vuoi aggiungere un altro prezzo? (y/n)");
            //    opt = Console.ReadLine();
            //} while (opt.Equals("y"));
            //tax = totalBase / 100 * taxPercentage;
            //totalWithTax = totalBase + tax;
            //Console.WriteLine($"Totale senza tasse: \t{totalBase}\u20AC\nAggiunta tassa: \t{tax}\u20AC\nTotale con tassa: \t{totalWithTax}\u20AC");

            //Console.WriteLine("inserisci un numero");
            //string b = Console.ReadLine();
            //if(int.TryParse(b, out int z))
            //{
            //    //bool isEven = z % 2 == 0;
            //    if (z % 2 == 0) Console.WriteLine("è pari");
            //    else Console.WriteLine("è dispari");
            //}

            //// chiedi due numeri in input
            //// trovare quanti numeri sono divisibili pr il secondo numero entro il primo numero
            //Console.WriteLine("inserisci due numeri");
            //string e = Console.ReadLine();
            //string f = Console.ReadLine();
            //int counter = 0;
            //if(int.TryParse(e, out int e1) && int.TryParse(f, out int f1))
            //{
            //    int res = e1 / f1;
            //    Console.WriteLine(res);
            //    for(int i = 1; i < e1; i++)
            //    {
            //        if(i % f1 == 0)
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine(counter.ToString());
            //}

            //DateTime data = new DateTime(2000, 12, 20);
            //DateTime dataAttuale = DateTime.Now;
            //Console.WriteLine(dataAttuale.AddDays(-10));

            //// in input anno mese e giorno di nascita
            //// calcola quanti giorni mesi e anni dalla data di nascita a oggi
            //Console.WriteLine("inserisci la tua data di nascita:");
            //string sAnno = Console.ReadLine();
            //string sMese = Console.ReadLine();
            //string sGiorno = Console.ReadLine();
            //int anno = int.TryParse(sAnno, out anno) ? anno : 0;
            //int mese = int.TryParse(sMese, out mese) ? mese : 0;
            //int giorno = int.TryParse(sGiorno, out giorno) ? giorno : 0;


            //DateTime nascita = new DateTime(anno, mese, giorno);
            //int eta = dataAttuale.Year - nascita.Year;
            ////int mesi = eta * 12 - () 
            
            //Console.WriteLine(dataAttuale.CompareTo(nascita));
            //Console.WriteLine($"Hai {eta} anni");
            //Console.WriteLine(dataAttuale.DayOfYear);
            //DateTime nuovaData = new DateTime(dataAttuale.AddYears(dataAttuale.Year -nascita.Year).Year, dataAttuale.AddMonths(dataAttuale.Month-nascita.Month).Month, dataAttuale.AddDays(dataAttuale.Day-nascita.Day).Day);
            //DateTime nuovaData2 = dataAttuale.Add(dataAttuale - nascita);
            //Console.WriteLine(nuovaData);
            //Console.WriteLine(nuovaData2);
            //Console.WriteLine(dataAttuale-nascita);
            ////Console.WriteLine(dataAttuale.AddDays(dataAttuale.Day - nascita.Day).Day);

            ////try
            ////{
            ////    int n1 = int.Parse(Console.ReadLine());
            ////    Console.WriteLine("hai inserito un numero");
            ////}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine("l'input non è un numero");
            ////}

            //TimeSpan timeSpan = dataAttuale - nascita;
            //Console.WriteLine($"timespan: {timeSpan}");
            //Console.WriteLine($"numero di giorni totali: {timeSpan.TotalDays}");
            //Console.WriteLine($"numero di giorni: {timeSpan.Days}");
            //Console.WriteLine($"numero di ore totali: {timeSpan.TotalHours}");
            //Console.WriteLine($"numero di ore: {timeSpan.Hours}");
            //Console.WriteLine($"numero di minuti totali: {timeSpan.TotalMinutes}");
            //Console.WriteLine($"numero di minuti: {timeSpan.Minutes}");
            //Console.WriteLine($"sei in vita da: {timeSpan.Days} giorni, ossia {timeSpan.TotalHours} ore, ossia {timeSpan.TotalMinutes} minuti");

            //Console.WriteLine(dataAttuale.ToString("dd/MM/yyyy HH:mm:ss"));
            //Console.WriteLine(dataAttuale.ToString("yy-MMM-d-ddd hh.m.ss tt U gg K zz"));
            ////DateTime dataIntera = DateTime.Parse(Console.ReadLine());
            ////DateTime.TryParse(Console.ReadLine(), out DateTime data2);
            ////Console.WriteLine(dataIntera);
            ////Console.WriteLine(data2);
            ////DateTime dd = new DateTime(1000, 3, 3, 10, 12, 25,DateTimeKind.Utc);
            ////Console.WriteLine(dd);
            
            //Console.WriteLine("inserisci l'ennesima data in formato MM/dd/yyyy");
            //string d3 = Console.ReadLine();
            //int tempYear = 0;
            //string tempDate = "";
            //try
            //{
            //    if(d3.Length == 10){
                    
            //        if(!int.TryParse(d3.Substring(6), out tempYear))
            //        {
            //            if (int.TryParse((d3[0] + d3[1].ToString() + d3[2] + d3[3]), out tempYear))
            //            {
            //                Console.WriteLine($"anno {tempYear}");
            //                if ((int.Parse(d3.Substring(8)) > 31) || (int.Parse(d3[5] + d3[6].ToString()) > 31)){
            //                    Console.WriteLine("invalid input");
            //                } 
            //                else if (int.Parse(d3[8].ToString()+ d3[9]) > 12)
            //                {

            //                    tempDate =  d3[5] + d3[6].ToString() +  "/" + d3.Substring(8) + "/" + tempYear;
            //                }
            //                else
            //                {
            //                    tempDate = d3.Substring(8) + "/" + d3[5] + d3[6].ToString() + "/" + tempYear;
            //                }
                            
                            
            //            } else
            //            {
            //                if ((int.Parse(d3[0] + d3[1].ToString()) > 31) || (int.Parse(d3.Substring(8)) > 31)) {
            //                    Console.WriteLine("invalid input");
            //                } 
            //                else if (int.Parse(d3[0] + d3[1].ToString()) > 12)
            //                {
            //                    tempDate = d3.Substring(8) + "/" + d3[0] + d3[1].ToString() + "/" + d3[3] + d3[4] + d3[5] + d3[6];
            //                } 
            //                else
            //                {
            //                    tempDate = d3[0] + d3[1].ToString() + "/" + d3.Substring(8) + "/" + d3[3] + d3[4] + d3[5] + d3[6];
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if ((int.Parse(d3[0] + d3[1].ToString()) > 31) || (int.Parse(d3[3] + d3[3].ToString().ToString()) > 31))
            //            {
            //                Console.WriteLine("invalid input");
            //            }
            //            else if (int.Parse(d3[0] + d3[1].ToString()) > 12)
            //            {
            //                tempDate = d3[3] + d3[4].ToString() + "/" + d3[0] + d3[1].ToString() + "/" + tempYear;
            //            }
            //            else
            //            {
            //                tempDate = d3[0] + d3[1].ToString() + "/" + d3[3] + d3[4].ToString() + "/" + tempYear;
            //            }
            //        }
            //    }
            //    DateTime data3 = DateTime.Parse(tempDate);
            //    //DateTime.TryParse(d3, out DateTime data2);
                
            //    Console.WriteLine(data3);

            //} catch
            //{
            //    Console.WriteLine("non hai inserito una data valida");
            //}

            //string frase = " i topi non avevano nipoti ";
            //Console.WriteLine(frase.Replace(" ", ""));
            //Console.WriteLine(frase.Substring(2,18));
            //Console.WriteLine(frase.Trim());
            //string[] arrString = frase.Split(' ');
            //foreach(string s in arrString)
            //{
            //    Console.WriteLine(s);
            //}

            int x = '╘';
            Console.WriteLine(x);
            string output = "";

            string x1 =Console.ReadLine();
            foreach(char c in x1)
            {
                int x2 = c;
                Console.WriteLine(x2);
            }
            for(int i = 0; i < x1.Length; i++)
            {
                output += (char)(x1[i] + i);
            }
            Console.WriteLine(output);
            bool isPal = true;
            for(int i = 0, j = x1.Length-1; i < x1.Length/2; i++, j--)
            {
                if ((int)x1[i] != (int)x1[j]) 
                {
                    isPal = false;
                    break;
                }
            }
            Console.WriteLine(isPal ? "è palindromo" : "non è palindromo");   

            Console.WriteLine("scrivi due parole");
            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < a1.Length; i++)
            {
                sum1 += a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {
                sum2 += a2[i];
            }

            Console.WriteLine(sum1 > sum2 ? $"{a1} ha una codifica maggiore. 1){sum1} 2){sum2}" : $"{a2} ha una codifica maggiore. 1){sum1} 2){sum2}");

            string g1 = "";
            string g2 = "";
            //for(int i = 0; i < a1.Length; i++)
            //{
            //    g1 += (char)(a1[i] + 10);
            //}
            //Console.WriteLine(g1);
            //for(int i = 0; i < a2.Length; i++)
            //{
            //    g2 += (char)(a2[i] - 10);
            //}
            //Console.WriteLine(g2);
            //string g3 = g1 + g2;
            string g3 = g1 + g2;
            for (int i = 0; i < g3.Length; i++)
            {
                char c = i < g1.Length ? (char)(g3[i] + 10) : (char)(g3[i] - 10);
            }

            char[] charArr = new char[g3.Length];

            for(int i = 0; i < g3.Length; i++)
            {
                int counter = 0;
                if (charArr.Contains(g3[i]))
                {
                    continue;
                }
                else
                {
                    charArr[i] = g3[i];
                }

                for(int j = 0; j < g3.Length; j++)
                {
                    if (g3[j] == g3[i])
                    {
                        counter++;
                    }
                }
                if(counter > 1)
                {
                    for(int k = 0; k < counter; k++)
                    {
                        Console.WriteLine(g3[i]);
                    }
                    Console.WriteLine($"{g3} compare {counter} volte");
                }
            }

            string b1 = Console.ReadLine();
            string b2 = Console.ReadLine();
            string b3 = b1 + b2;
            for(int i = 0; i < b3.Length; i++)
            {
                char c = i < b1.Length ? (char)(b3[i] + 10) : (char)(b3[i] - 10);
                Console.WriteLine($"{c}: {(int)c}");
            }

            string max = b1.Length > b2.Length ? b1 : b2;
            string min = b1.Length > b2.Length ? b2 : b1;
            
            for(int i = 0; i > max.Length; i++)
            {
                char c1 = (char)(max[i] + 10);
                Console.WriteLine($"{c1}: {(int)c1}");
                if (i < min.Length)
                {
                    char c = (char)(min[i] - 10);
                    Console.WriteLine($"{c}: {(int)c}");
                }
            }

            //accetta decimali prezzi finché sono prezzi. Somma numerica di tutto quello inserito. Della somma prendi la codifica dei numeri e e stampa e fai la moltiplicazione di qeui numeri
            string prezzo = "";
            double h = 0.0;
            double somma = 0.0;
            int codifica = 0;
            int mult = 1;
            do {
                Console.WriteLine("aggiungi un prezzo decimale");
                prezzo = Console.ReadLine();
                if (double.TryParse(prezzo, out h))
                {
                    somma += h;
                }
            } while (double.TryParse(prezzo, out h));
            Console.WriteLine(somma);
            foreach(char c in somma.ToString())
            {
                Console.WriteLine((int)c);
                mult *= c;
            }
            Console.WriteLine("\n" + mult);
            
        }
    }
}