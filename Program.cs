using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("YOUR TO DO MANAGER");
            Console.WriteLine("Easy breasy to plan your full day!");
            Console.Write("(Press any key to continue.)");
            Console.ReadKey();
            Console.Clear();

            //new list to be able to add new to do-items.
            List<TodoItem> todoItems = new List<TodoItem>();
            bool mainmenu = true;

            //loop for mainmenu.
            while (mainmenu)
            {
                Console.WriteLine("1. Add new to do-item.");
                Console.WriteLine("2. Show complete to do-list.");
                Console.WriteLine("3. Remove to do-item.");
                Console.WriteLine("4. Set to do-item as finished.");
                Console.WriteLine("5. Close down the program.");
                Console.Write("Please type in your choice: ");

                int userChoice = 0;

                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                }

                catch (System.Exception)
                {
                    Console.WriteLine("Incorrect input. Please only type numbers 1 - 4 according to the main menu.");
                }
                Console.WriteLine();

                //constructor with no arguments.
                TodoItem todoitem = new TodoItem();

                if (userChoice == 1)
                {
                    Console.WriteLine("Add a title for your new to do-item.");
                    todoitem.title = Console.ReadLine();

                    Console.WriteLine("Add a description for your new to do-item.");
                    todoitem.description = Console.ReadLine();

                    Console.WriteLine("Add a deadline-date for your to do-item, when it´s supposed to be finished");
                    todoitem.deadlinedate = Convert.ToInt32(Console.ReadLine());
                    todoItems.Add(todoitem);
                }

                else if (userChoice == 2)
                {
                    Console.WriteLine("Your todo-list right now is:");
                    foreach (var item in todoItems)
                    {
                        Console.WriteLine(item.description + " " + item.isDone);
                    }
                    Console.ReadKey();
                }

                else if (userChoice == 3)
                {
                    Console.Write("Please state which item number that should be removed from the list: ");
                    int removeItemInput = 0;

                    try
                    {
                        removeItemInput = Convert.ToInt32(Console.ReadLine());
                    }

                    catch (System.Exception)
                    {
                        Console.WriteLine("Incorrect input. Please only type numbers, according to your list.");
                    }
                    todoItems.RemoveAt(removeItemInput);
                    Console.Write("Your required item has now been removed....");
                }

                else if (userChoice == 4)
                {
                    Console.Write("Please state which item number that should be set as finished.");
                    int setItemAsFinishedInput = 0;

                    try
                    {
                        setItemAsFinishedInput = Convert.ToInt32(Console.ReadLine());
                    }

                    catch (System.Exception)
                    {
                        Console.WriteLine("Incorrect input. Please only type numbers 1 - 4, according to your list.");
                    }
                    todoItems[setItemAsFinishedInput].isDone = true;
                }

            }

        }

        class TodoItem
        {
            public string title;
            public string description;
            public int deadlinedate;

            public bool isDone;
        }
    }
}