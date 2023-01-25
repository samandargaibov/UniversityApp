namespace UniversityConsoleApp.Models
{
    internal class Teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];

        public override string ToString()
        {
            string groups = "";

            foreach (var item in Groups)
            {
                if (item == null)
                    continue;

                groups += item.ToString() + " ";
            }

            return $"Teacher ID: {Id}, Teacher FullName: {FirstName} {LastName} {FatherName}, Age: {Age}\nGroups: {groups}";
        }
    }
}
