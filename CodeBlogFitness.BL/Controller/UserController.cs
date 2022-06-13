using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBlogFitness.BL.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }

        public UserController()
        {
            var formater = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formater.Deserialize(fs) is User user)
                {
                    User = user;
                }
                // TODO: Что делать, если пользователя не прочитали?
            }
        }

        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <returns> Пользователь приложения. </returns>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            // TODO: Проверка
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
        }
        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using(var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
            Console.WriteLine("Saved successfully");
        }

        public override string ToString()
        {
            return $"\n> Name: {User.UserName}\n  gender: {User.Gender}\n  birth day: {User.BirthDate}\n" +
                $"  weight: {User.Weight}\n  height: {User.Height}\n";
        }
    }
}
