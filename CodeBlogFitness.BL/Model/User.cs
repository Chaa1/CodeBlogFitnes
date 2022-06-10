using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User
    {
        #region Свойства класса
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; }
        /// <summary>
        /// Название гендера.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="gender"> Пол. </param>
        /// <param name="dateTime"> Дата рождения. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        /// <exception cref="ArgumentNullException"> Проверка входных параметров. </exception>
        public User( string name, Gender gender, DateTime dateTime, double weight, double height)
        {
            #region Блок проверок входных параметров
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("User name cannot be empty", nameof(name));
            if(gender == null)
                throw new ArgumentNullException("Gender cannot be empty", nameof(gender));
            if (dateTime < DateTime.Parse("01.01.1900") || dateTime > DateTime.Now)
                throw new ArgumentNullException("Enter date give error formate", nameof(dateTime));
            if (weight <= 0)
                throw new ArgumentNullException("Weight cannot bi zero", nameof(weight));
            if (height <= 0)
                throw new ArgumentNullException("Height cannot bi zero", nameof(height));
            #endregion
            UserName = name;
            Gender = gender;
            BirthDate = dateTime;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return $"> User name: {UserName}\n  gender: {Gender}\n  birth day: {BirthDate}\n  weight; {Weight}\n  height: {Height}\n"; 
        }
    }
}
