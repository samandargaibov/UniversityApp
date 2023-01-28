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
    internal class ZalManager : ICrudService, IPrintService
    {
        private Zal[] _zals = new Zal[5];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 4)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 5 zal elave etmek olar!");

                return;
            }

            _zals[_currentIndex++] = (Zal)entity;
            Console.WriteLine("Zal ugurla elave olundu!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _zals.Length; i++)
            {
                if (_zals[i] == null)
                    continue;

                if (id == _zals[i].Id)
                {
                    found = true;

                    for (int j = i; j < _zals.Length - 1; j++)
                    {
                        _zals[j] = _zals[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id} id-li zal silindi!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{id} id-li zal tapilmadi!");
            }
        }

        public Entity Get(int id)
        {
            foreach (var item in _zals)
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
            return _zals;
        }

        public void Print()
        {
            foreach (var item in _zals)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _zals.Length; i++)
            {
                if (_zals[i] == null)
                    continue;

                if (_zals[i].Id == id)
                {
                    _zals[i] = (Zal)entity;
                    Console.WriteLine("Ugurla deyishdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
