namespace ASP.NET_GraphQL.Schema;

public class Mutation
{
    private List<CourseType> _courses;

    public Mutation()
    {
        _courses = new List<CourseType>();
    }
    
    public bool CreateCourse(string name, Subject subject, Guid instructorId)
    {
        CourseType courseType = new CourseType
        {
            Id = Guid.NewGuid(),
            Name = name,
            Subject = subject,
            Instructor = new InstructorType
            {
                Id = instructorId
            }
        };
        
        _courses.Add(courseType);

        return true;
    }
}