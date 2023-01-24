using UniversityConsoleApp.Models;
using UniversityConsoleApp.Services;

namespace UniversityConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StudentManager
            var studentManager = new StudentManager();
            var groupManager = new GroupManager();
            var teacherManager = new TeacherManager();
            var departmentMangaer = new DepartmentManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add group"))
                {
                    var group1 = new Group
                    {
                        Id = 1,
                        Name = "P329",
                        Students = new Student[]{
                                    (Student)studentManager.Get(1),
                                    (Student)studentManager.Get(2),
                                    (Student)studentManager.Get(3),
                                },
                    };

                    var group2 = new Group
                    {
                        Id = 2,
                        Name = "P330",
                        Students = new Student[]{
                                    (Student)studentManager.Get(1),
                                    (Student)studentManager.Get(2),
                                },
                    };

                    var group3 = new Group
                    {
                        Id = 3,
                        Name = "P331",
                        Students = new Student[]{
                                    (Student)studentManager.Get(4),
                                },
                    };

                    groupManager.Add(group1);
                    groupManager.Add(group2);
                    groupManager.Add(group3);
                }

                else if (command.ToLower().Equals("print groups"))
                {
                    groupManager.Print();
                }

                else if (command.ToLower().Equals("delete group"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    groupManager.Delete(id);
                }

                else if (command.ToLower().Equals("get group"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    groupManager.Get(id);
                }

                else if (command.ToLower().Equals("update group"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    var existGroup = groupManager.Get(id);

                    if (existGroup == null)
                        continue;

                    Console.WriteLine(existGroup);

                    var group1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Rafet",
                        LastName = "Rzayev",
                        Age = 30,
                    };

                    groupManager.Update(id, group1);
                }

                else if (command.ToLower().Equals("add student"))
                {
                    var student1 = new Student
                    {
                        Id = 1,
                        FirstName = "Samandar",
                        LastName = "Gaibov",
                        Age = 27,
                        Course = 2,
                        EntryDate = DateTime.Now,
                        Group = (Group)groupManager.Get(1),
                    };

                    var student2 = new Student
                    {
                        Id = 2,
                        FirstName = "Elvin",
                        LastName = "Jabrayilov",
                        Age = 24,
                        Course = 2,
                        EntryDate = DateTime.Now,
                        Group = (Group)groupManager.Get(2),
                    };

                    var student3 = new Student
                    {
                        Id = 3,
                        FirstName = "Samir",
                        LastName = "Kerimli",
                        Age = 22,
                        Course = 1,
                        EntryDate = DateTime.Now,
                        Group = (Group)groupManager.Get(1),
                        
                    };

                    var student4 = new Student
                    {
                        Id = 4,
                        FirstName = "Celil",
                        LastName = "Memmedquluzade",
                        Age = 21,
                        Course = 1,
                        EntryDate = DateTime.Now,
                        Group = (Group)groupManager.Get(3),

                    };

                    studentManager.Add(student1);
                    studentManager.Add(student2);
                    studentManager.Add(student3);
                    studentManager.Add(student4);
                }

                else if (command.ToLower().Equals("print students"))
                {
                    studentManager.Print();
                }

                else if (command.ToLower().Equals("delete student"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    studentManager.Delete(id);
                }

                else if (command.ToLower().Equals("get student"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    studentManager.Get(id);
                }

                else if (command.ToLower().Equals("update student"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    var existStudent = studentManager.Get(id);

                    if (existStudent == null)
                        continue;

                    Console.WriteLine(existStudent);

                    var student2 = new Student
                    {
                        Id = 2,
                        FirstName = "Elvin",
                        LastName = "Jabrayilov",
                        Age = 26,
                        Course = 2,
                        EntryDate = DateTime.Now,
                        Group = new Group
                        {
                            Id = 1,
                            Name = "P329",

                        },
                        Subjects = new string[0],
                    };

                    studentManager.Update(id, student2);
                }

                else if (command.ToLower().Equals("add teacher"))
                {
                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Rafet",
                        LastName = "Rzayev",
                        Age = 35,
                        Groups = new Group[]
                        {
                                (Group)groupManager.Get(3),
                        },

                    };

                    var teacher2 = new Teacher
                    {
                        Id = 2,
                        FirstName = "Emin",
                        LastName = "Mammadov",
                        Age = 40,
                        Groups = new Group[]
                        {
                                (Group)groupManager.Get(1),
                                (Group)groupManager.Get(2),
                        },

                    };

                    teacherManager.Add(teacher1);
                    teacherManager.Add(teacher2);
                }

                else if (command.ToLower().Equals("print teachers"))
                {
                    teacherManager.Print();
                }

                else if (command.ToLower().Equals("delete teacher"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }

                else if (command.ToLower().Equals("get teacher"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Get(id);
                }

                else if (command.ToLower().Equals("update teacher"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    if (existTeacher == null)
                        continue;

                    Console.WriteLine(existTeacher);

                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Rafet",
                        LastName = "Rzayev",
                        Age = 30,
                    };

                    teacherManager.Update(id, teacher1);
                }

                else if (command.ToLower().Equals("add department"))
                {
                    var department1 = new Department
                    {
                        Id = 1,
                        Teachers= new Teacher[]
                        {
                            (Teacher)teacherManager.Get(1),
                        },
                        Leader = new Person
                        { 
                            Id = 1,
                            FirstName = "Elariz",
                            LastName = "Mammadoglu",
                            Age = 40,
                        },
                    };

                    var department2 = new Department
                    {
                        Id = 2,
                        Teachers = new Teacher[]
                        {
                            (Teacher)teacherManager.Get(2),
                        },
                        Leader = new Person
                        {
                            Id = 2,
                            FirstName = "Huseyn",
                            LastName = "Nasibli",
                            Age = 45,
                        },
                    };

                    departmentMangaer.Add(department1);
                    departmentMangaer.Add(department2);
                }

                else if (command.ToLower().Equals("print departments"))
                {
                    departmentMangaer.Print();
                }

                else if (command.ToLower().Equals("delete department"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    departmentMangaer.Delete(id);
                }

                else if (command.ToLower().Equals("get department"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    departmentMangaer.Get(id);
                }

                else if (command.ToLower().Equals("update department"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    var existDepartment = departmentMangaer.Get(id);

                    if (existDepartment == null)
                        continue;

                    Console.WriteLine(existDepartment);

                    var department1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Rafet",
                        LastName = "Rzayev",
                        Age = 30,
                    };

                    departmentMangaer.Update(id, department1);
                }

            } while (command.ToLower() != "quit");
            #endregion

        }
    }
}