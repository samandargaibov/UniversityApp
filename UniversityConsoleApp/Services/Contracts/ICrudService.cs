using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.Services.Contracts
{
    internal interface ICrudService
    {
        void Add(Entity entity);

        void Update(int id, Entity entity);

        void Delete(int id);

        Entity Get(int id);

        Entity[] GetAll();
    }
}
