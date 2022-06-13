using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tВас приветствует приложение CodeBlogFitness!\n");

            Console.Write("  Введите имя пользователя: ");
            var name = Console.ReadLine();

            Console.Write("  Введите пол: ");
            var gender = Console.ReadLine();

            Console.Write("  Введите дату своего рождения в формате 00.00.0000: ");
            var birthdate = DateTime.Parse(Console.ReadLine());// TODO: Переписать на ТрайПарс

            Console.Write("  Введите свой вес: ");
            var weight = Double.Parse(Console.ReadLine());

            Console.Write("  Введите свой рост: ");
            var height = Double.Parse(Console.ReadLine());


            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();

            Console.WriteLine(userController);
        }
    }
}
