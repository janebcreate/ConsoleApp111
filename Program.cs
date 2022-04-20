using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using ConsoleApp1;

namespace HelloApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // добавление данных
            ApplicationContext db = new ApplicationContext();

            // создаем два объекта User
            User user1 = new User { Id = 1, Name = "Tom", Age = 33 };
            User user2 = new User { Id = 2, Name = "Alice", Age = 26 };
            // добавляем их в БД
            db.Users.AddRange(user1, user2);
            db.SaveChanges(); // не работает сохранение

            // получаем объекты из БД и выводим на консоль
            var users = db.Users.ToList();
            Console.WriteLine("Users list:");
            foreach (User u in users)
            {
                Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            }
        }
    }
}