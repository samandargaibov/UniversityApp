namespace UniversityConsoleApp.Models
{
    internal class Student : Person
    {
        internal Group Group { get; set; }

        internal DateTime EntryDate { get; set; }

        internal int Course { get; set; }

        internal string[] Subjects { get; set; } = new string[10];

        public override string ToString()
        {
            string subjects = "";

            Subjects[0] = "IT";
            Subjects[1] = "Math";
            Subjects[2] = "English";
            Subjects[3] = "Geography";
            Subjects[4] = "Chemistry";

            foreach (var item in Subjects)
            {
                if (item == null)
                    continue;

                subjects+= item.ToString() + ",";
            }

            return $"Student ID: {Id}, Student FullName: {FirstName} {LastName} {FatherName}, Age: {Age}\nGroup: {Group}\nEnter date: {EntryDate}\nCourse: {Course}\nSubjects:{subjects}\n\n";
        }
    }
}
