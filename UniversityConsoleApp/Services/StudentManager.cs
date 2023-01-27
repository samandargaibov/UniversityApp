using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.Services.Contracts;
using Core.Services;

namespace UniversityConsoleApp.Services
{
    internal class StudentManager : ICrudService, IPrintService
    {
        private Student[] _students = new Student[100];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 99)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 100 telebe elave etmek olar!");

                return;
            }

            _students[_currentIndex++] = (Student)entity;
            Console.WriteLine("Telebe ugurla elave olundu!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                    continue;

                if (id == _students[i].Id)
                {
                    found = true;

                    for (int j = i; j < _students.Length - 1; j++)
                    {
                        _students[j] = _students[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} id-li telebe silindi!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} id-li telebe tapilmadi!");
            }
        }

        public Entity Get(int id)
        {
            foreach (var item in _students)
            {
                if (item == null)
                    continue;

                if (item.Id == id)
                {
                    Console.Write(item);

                    return item;
                }
            }

            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _students;
        }

        public void Print()
        {
            foreach (var item in _students)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                    continue;

                if (_students[i].Id == id)
                {
                    _students[i] = (Student)entity;
                    Console.WriteLine("Ugurla deyishdirildi!");

                    return;
                }
            }
            
            Console.WriteLine("Not found");
        }
    }
}
