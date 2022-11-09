namespace ScheduleLogic
{
    public class Classes
    {
        public Teacher Teacher { get; set; }
        public Lesson Lesson { get; set; }
        public Audience Audience { get; set; }
        
        public Classes()
        {
            Teacher = new Teacher();
            Lesson = new Lesson();
            Audience = new Audience();
        }
        public Classes(Teacher teacher, Lesson lesson, Audience audience)
        {
            Teacher = teacher;
            Lesson = lesson;
            Audience = audience;
        }        


    }
}