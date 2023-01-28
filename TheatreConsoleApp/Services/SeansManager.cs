using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreConsoleApp.Models;
using UniversityConsoleApp.Services.Contracts;

namespace TheatreConsoleApp.Services
{
    internal class SeansManager : ICrudService, IPrintService
    {
        private Seans[] _seans = new Seans[5];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 5 Seans elave etmek olar!");

                return;
            }

            _seans[_currentIndex++] = (Seans)entity;
            Console.WriteLine("Seans ugurla elave olundu!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _seans.Length; i++)
            {
                if (_seans[i] == null)
                    continue;

                if (id == _seans[i].Id)
                {
                    found = true;

                    for (int j = i; j < _seans.Length - 1; j++)
                    {
                        _seans[j] = _seans[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} id-li seans silindi!");

                    return;
                }

                if (!found)
                {
                    Console.WriteLine($"{id} id-li seans tapilmadi!");
                }
            }
        }
        public Entity Get(int id)
        {
            foreach (var item in _seans)
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
            return _seans;
        }

        public void Print()
        {
            foreach (var item in _seans)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _seans.Length; i++)
            {
                if (_seans[i] == null)
                    continue;

                if (_seans[i].Id == id)
                {
                    _seans[i] = (Seans)entity;
                    Console.WriteLine("Ugurla deyishdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
