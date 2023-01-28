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
    internal class TheatreManager : ICrudService, IPrintService
    {
        private Theatre[] _theatres = new Theatre[3];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 3 Teatr elave etmek olar!");

                return;
            }

            _theatres[_currentIndex++] = (Theatre)entity;
            Console.WriteLine("Teatr ugurla elave olundu!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _theatres.Length; i++)
            {
                if (_theatres[i] == null)
                    continue;

                if (id == _theatres[i].Id)
                {
                    found = true;

                    for (int j = i; j < _theatres.Length - 1; j++)
                    {
                        _theatres[j] = _theatres[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} id-li teatr silindi!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} id-li teatr tapilmadi!");
            }
        }

        public Entity Get(int id)
        {
            foreach (var item in _theatres)
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
            return _theatres;
        }

        public void Print()
        {
            foreach (var item in _theatres)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _theatres.Length; i++)
            {
                if (_theatres[i] == null)
                    continue;

                if (_theatres[i].Id == id)
                {
                    _theatres[i] = (Theatre)entity;
                    Console.WriteLine("Ugurla deyishdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
