namespace ScheduleLogic
{
    public class Core
    {
        List<Teacher> teachers;
        List<Group> groups;
        List<Audience> audiences;
        List<Lesson> lessons;

        public Core()
        {
            teachers = new List<Teacher>();
            groups = new List<Group>();
            audiences = new List<Audience>();
            lessons = new List<Lesson>();
        }
        public Core(List<Teacher> teachers, List<Group> groups, List<Audience> audiences, List<Lesson> lessons)
        {
            this.teachers = teachers;
            this.groups = groups;
            this.audiences = audiences;
            this.lessons = lessons;
        }


    }
}