using Core.Services;

namespace UniversityConsoleApp.Models
{
    internal class Department : Entity
    {
        internal string Name { get; set; }

        internal Teacher[] Teachers { get; set; } = new Teacher[10];

        internal Person Leader { get; set; }

        public override string ToString()
        {
            string printInfo = "";

            foreach (var item in Teachers)
            {
                if (item == null)
                    continue;

                printInfo+= item.ToString() + " ";
            }

            return $"Department Name: {Name},Department Leader: {Leader} \nTeachers: \n{printInfo}";
        }
    }
}
