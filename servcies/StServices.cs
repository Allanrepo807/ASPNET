using SkeltalStudentApi.models;

namespace SkeltalStudentApi.servcies;

public class StServices
{
    public static List<Student> Students {get;}
    
    static StServices()
    {
        Students = new List<Student>()
        {
            new Student {Id = 1, Name = "Allan Benedict"},
            new Student {Id = 2 , Name = "Jhon Doe"}
        };
    }

    public static List<Student> GetAll() => Students;

    public static Student? Get(int id) => Students.FirstOrDefault(s=>s.Id == id);

    public static string Add()
    {
        return "Student is Added";
    }

    public static string Update()
    {
        return "Student is Updates";
    }

    public static string Delete()
    {
        return"Sudent is Deleted";
    }

}

    
