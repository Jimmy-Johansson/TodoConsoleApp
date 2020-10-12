using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();

            Console.WriteLine("TO DO MANAGER");
            Console.WriteLine("Easy breasy to plan your full day!");
            Console.Write("(Press any key to continue.)");
            Console.ReadKey();
            Console.Clear();

            //Test-code, add user interface here later
            todoManager.AddTodoItem("Rasta hunden");
            todoManager.AddTodoItem("Rasta den andra hunden");
            todoManager.AddTodoItem("Rasta papegojan");

            todoManager.SetTodoItem(0, true);
            todoManager.RemoveTodoItem(1);
        }
    }
}