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
    internal class FilmManager : ICrudService, IPrintService
    {
        private Film[] _films = new Film[3];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 3 film elave etmek olar!");

                return;
            }

            _films[_currentIndex++] = (Film)entity;
            Console.WriteLine("Film ugurla elave olundu!");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            foreach (var item in _films)
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
            return _films;
        }

        public void Print()
        {
            foreach (var item in _films)
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
