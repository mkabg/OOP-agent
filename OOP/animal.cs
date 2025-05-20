using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Animal
    {
        //public string Name;
        //public int Age;
        //private int Id;

        //public Animal(string name, int age, int id)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    Id = id;
        //}

        //public void SetId(int id)
        //{
        //    Id = id;
        //}
        //public int GetId()
        //{
        //    return Id;
        //}
        //public void print()
        //{
        //    Console.WriteLine("hi im " + Name + " and i " + Age + " years old");
        //}

        public abstract void MakeSound();
        public abstract void Eat();
        public abstract void print();

    }
}
