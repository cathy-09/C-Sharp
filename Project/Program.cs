using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            List<string> licensePlate = new List<string>();
            List<string> clientName = new List<string>();
            List<string> serviceType = new List<string>();
            List<int> deadline = new List<int>();
            List<double> price = new List<double>();
            do
            {
                Console.WriteLine("                                                        ");
                Console.WriteLine("********************************************************");
                Console.WriteLine("                          Меню                          ");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("                                                        ");
                Console.WriteLine("1. Въвеждане на клиенти. ");
                Console.WriteLine("2. Извеждане на базата данни в табличен вид.");
                Console.WriteLine("3. Извеждане на клиентите според зададен вид услуга.");
                Console.WriteLine("4. Сортиране в низходящ ред на срока за изпълнение.");
                Console.WriteLine("5. Сортиране на клиентите по азбучен ред.");
                Console.WriteLine("6. Общата стойност от всички услуги.");
                Console.WriteLine("7. Услуги, чийто срок надвишава въведения от клавиатурата.");
                Console.WriteLine("8. Изход.");
                Console.WriteLine("                                                        ");
                do
                {
                    Console.Write("Вашият избор: ");
                    choice = int.Parse(Console.ReadLine());
                } while (choice < 1 || choice > 8);
                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Въведи брой клиенти: ");
                            int count = int.Parse(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                Console.Write("Регистрационен номер: ");
                                string plateNumber = Console.ReadLine();
                                licensePlate.Add(plateNumber);

                                Console.Write("Име на клиент: ");
                                string client = Console.ReadLine();
                                clientName.Add(client);

                                Console.Write("Вид услуга: ");
                                string service = Console.ReadLine();
                                serviceType.Add(service);

                                Console.Write("Срок за изпълнение на услугата в дни: ");
                                int duration = int.Parse(Console.ReadLine());
                                deadline.Add(duration);

                                Console.Write("Цена на услугата: ");
                                double servicePrice = double.Parse(Console.ReadLine());
                                price.Add(servicePrice);
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", "Регистрационен номер", "Име на клиент", "Вид услуга", "Срок", "Цена");
                            for (int i = 0; i < licensePlate.Count; i++)
                            {
                                Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", licensePlate[i], clientName[i], serviceType[i], deadline[i], price[i]);
                            }
                            break;
                        }   

                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Въведете услуга: ");
                            string searchService = Console.ReadLine();
                            int searchIndex = serviceType.IndexOf(searchService);
                            if (searchIndex == -1)
                            {
                                Console.WriteLine("Не е намерена такава услуга!");
                            }
                            else
                            {
                                Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", "Регистрационен номер", "Име на клиент", "Вид услуга", "Срок", "Цена");
                                for (int i = 0; i < serviceType.Count; i++)
                                {
                                    if (serviceType[i] == searchService)
                                    {
                                        Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", licensePlate[i], clientName[i], serviceType[i], deadline[i], price[i]);
                                    }
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            string stringTemp;
                            int intTemp;
                            double doubleTemp;
                            bool flag = true;
                            while (flag)
                            {
                                flag = false;
                                for (int i = 0; i < deadline.Count - 1; i++)
                                {
                                    if (deadline[i] < deadline[i + 1])
                                    {
                                        //Размяна на регистрационни номера
                                        stringTemp = licensePlate[i];
                                        licensePlate[i] = licensePlate[i + 1];
                                        licensePlate[i + 1] = stringTemp;

                                        //Размяна на имената на клиентите
                                        stringTemp = clientName[i];
                                        clientName[i] = clientName[i + 1];
                                        clientName[i + 1] = stringTemp;

                                        //Размяна на услугите
                                        stringTemp = serviceType[i];
                                        serviceType[i] = serviceType[i + 1];
                                        serviceType[i + 1] = stringTemp;

                                        //Размяна на срока
                                        intTemp = deadline[i];
                                        deadline[i] = deadline[i + 1];
                                        deadline[i + 1] = intTemp;

                                        //Размяна на цената
                                        doubleTemp = price[i];
                                        price[i] = price[i + 1];
                                        price[i + 1] = doubleTemp;

                                        flag = true;
                                    }
                                }
                            }
                            Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", "Регистрационен номер", "Име на клиент", "Вид услуга", "Срок", "Цена");
                            for (int i = 0; i < licensePlate.Count; i++)
                            {
                                Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", licensePlate[i], clientName[i], serviceType[i], deadline[i], price[i]);
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            string stringTemp;
                            int intTemp;
                            double doubleTemp;
                            bool flag = true;
                            while (flag)
                            {
                                flag = false;
                                for (int i = 0; i < deadline.Count - 1; i++)
                                {
                                    if ((string.Compare(clientName[i], clientName[i + 1], true)) > 0)
                                    {
                                        //Размяна на регистрационни номера
                                        stringTemp = licensePlate[i];
                                        licensePlate[i] = licensePlate[i + 1];
                                        licensePlate[i + 1] = stringTemp;

                                        //Размяна на имената на клиентите
                                        stringTemp = clientName[i];
                                        clientName[i] = clientName[i + 1];
                                        clientName[i + 1] = stringTemp;

                                        //Размяна на услугите
                                        stringTemp = serviceType[i];
                                        serviceType[i] = serviceType[i + 1];
                                        serviceType[i + 1] = stringTemp;

                                        //Размяна на срока
                                        intTemp = deadline[i];
                                        deadline[i] = deadline[i + 1];
                                        deadline[i + 1] = intTemp;

                                        //Размяна на цената
                                        doubleTemp = price[i];
                                        price[i] = price[i + 1];
                                        price[i + 1] = doubleTemp;

                                        flag = true;
                                    }
                                }
                            }
                            Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", "Регистрационен номер", "Име на клиент", "Вид услуга", "Срок", "Цена");
                            for (int i = 0; i < licensePlate.Count; i++)
                            {
                                Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", licensePlate[i], clientName[i], serviceType[i], deadline[i], price[i]);
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            double totalPrice = 0;
                            for (int i = 0; i < price.Count; i++)
                            { 
                                totalPrice += price[i];
                            }
                            Console.WriteLine($"Обща стойност на всички услуги: {totalPrice:F2}");
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.Write("Въведи срок: ");
                            int searchDuration = int.Parse(Console.ReadLine());
                            int maxDuration = deadline[0];
                            for (int i = 1; i < deadline.Count; i++)
                            {
                                if (deadline[i] > maxDuration)
                                {
                                    maxDuration = deadline[i];
                                }
                            }
                            if (maxDuration <= searchDuration)
                            {
                                Console.WriteLine("Не са намерени услуги с търсения критерий!");
                            }
                            else
                            {
                                Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", "Регистрационен номер", "Име на клиент", "Вид услуга", "Срок", "Цена");
                                for (int i = 0; i < licensePlate.Count; i++)
                                {
                                    if (deadline[i] > searchDuration)
                                    {
                                        Console.WriteLine("{0,-25}{1,-30}{2,-20}{3,-10}{4,-10}", licensePlate[i], clientName[i], serviceType[i], deadline[i], price[i]);
                                    }
                                }
                            }
                            break;
                        }
                }
            } while (choice != 8);
        }
    }
}