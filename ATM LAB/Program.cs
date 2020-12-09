using System;
using System.Collections.Generic;

namespace ATM_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var ListOfAccout = new List<Account>();

            while (true)
            {



                Console.WriteLine("\n");
                Console.WriteLine("Would you like to:");
                Console.WriteLine("[1]: Register");
                Console.WriteLine("[2]: Login");
                Console.WriteLine("[3]: Exit");
                int select = Convert.ToInt32(Console.ReadLine());
                

              
                if (select == 1)
                {
                    Console.WriteLine("Enter your name : ");
                    string  name = Console.ReadLine();
                    Console.WriteLine("Enter your password : ");
                    string  password = Console.ReadLine();
                    Console.WriteLine("Enter your deposit balance : ");
                    int balance = Convert.ToInt32(Console.ReadLine());
                    ListOfAccout.Add(new Account(name, password, balance));
                    Console.WriteLine("Account created successfully! ");
                    continue;
                }
                else if (select == 2)
                {
                    do
                    {
                        Console.WriteLine("Please enter your name");
                       string name = Console.ReadLine();
                        Console.WriteLine("Please enter your password");
                       string password = Console.ReadLine();
                        int count = 1;
                        foreach (Account account in ListOfAccout)
                        {
                            if (account.Name.Equals(name) && account.Password.Equals(password))
                            {
                                Console.WriteLine("Login Successfully! \n");
                                account.Status = index.True;
                              
                                break;
                            }
                            count++;
                        }
                        if (ListOfAccout.Count < count)
                        {
                            Console.WriteLine("Wrong Name or Password! Try Again.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                      
                    } while (true);


                    do
                    {

                        Console.WriteLine("[1]: Logout");
                        Console.WriteLine("[2]: CheckBalance");
                        Console.WriteLine("[3]: Deposit");
                        Console.WriteLine("[4]: Withdraw");
                        int select1 = Convert.ToInt32(Console.ReadLine());

                        if (select1 == 1)
                        {
                            foreach (Account account in ListOfAccout)
                            {
                                if (account.Status.Equals(index.True))
                                {
                                    Console.WriteLine("Successfully logout! ");
                                    account.Status = index.Flase;
                                    break;

                                }
                            }

                            break;
                        }
                        else if (select1 == 2)
                        {
                            foreach (Account account in ListOfAccout)
                            {
                                if (account.Status.Equals(index.True))
                                {
                                    Console.WriteLine($"Your total balance is {account.Balance}");
                                    break;
                                }

                            }
                            continue;
                        }
                        else if (select1 == 3)
                        {
                            foreach (Account account in ListOfAccout)
                            {
                                if (account.Status.Equals(index.True))
                                {
                                    Console.WriteLine("Enter the amount of Deposit");
                                    int depo = Convert.ToInt32(Console.ReadLine());
                                    account.Balance = account.Balance + depo;
                                    Console.WriteLine($"Your total balance is {account.Balance}");
                                    break;
                                }

                            }
                            continue;
                        }
                        else if (select1 == 4)
                        {
                            foreach (Account account in ListOfAccout)
                            {
                                if (account.Status.Equals(index.True))
                                {
                                    Console.WriteLine("Enter the amount of Withdraw");
                                    int depo = Convert.ToInt32(Console.ReadLine());
                                    if (depo < account.Balance)
                                    {
                                        account.Balance = account.Balance - depo;
                                        Console.WriteLine($"Withdraw successfull Your total balance is {account.Balance}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Do not have enough money in your account");
                                    }
                                    break;
                                }

                            }
                            continue;
                        }
                        
                        else
                        {
                            Console.WriteLine("Wrong Input please try again!");
                            continue;
                        }

                    } while (true);
                   

                    continue;

                }                      
                else if (select == 3)
                {
                   
                    Console.WriteLine("Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong choice! Please select one of this");
                    continue;
                }

            }


        }




    }

    public class Account
    {
        public Account(string name, string password, int balance)
        {
            Name = name;
            Password = password;
            Balance = balance;
            Status = index.Flase;
        }
      
        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public index Status { get; set; }
    
    }

    public enum index
    { 
        True = 0,
        Flase = 1
    }
}

   




