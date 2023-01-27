using Core.Services;

namespace UniversityConsoleApp.Models

{
    internal class Group : Entity
    {

        public string Name { get; set; }

        public Student[] Students { get; set; } = new Student[50];

        public override string ToString()
        {
            string students = "";

            foreach (var item in Students)
            {
                if (item == null)
                    continue;

                students += item.ToString() + "";
            }

            return $"Group ID: {Id}, Group Name: {Name}\nTelebeler:\n{students}";
        }
    }
}
