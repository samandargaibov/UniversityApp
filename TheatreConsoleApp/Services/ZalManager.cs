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
            throw new NotImplementedException();
        }
    }
}
