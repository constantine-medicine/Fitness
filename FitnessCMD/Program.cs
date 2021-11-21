﻿using FitnessBl.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness");
            Console.WriteLine("Введите имя пользователя");

            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthday = DateTime.Parse(Console.ReadLine()); // TODO: Переписать

            Console.WriteLine("Введите вес");
            var weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = Double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthday, weight, height);
            userController.Save();

            Console.ReadLine();
        }
    }
}
