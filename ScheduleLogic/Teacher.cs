namespace ScheduleLogic
{
    public class Teacher
    {
        public string name;
        public HashSet<Lesson> lessonsToTeach;

        public Teacher()
        {
            name = "";
            lessonsToTeach = new HashSet<Lesson>();
        }
        public Teacher(string name, HashSet<Lesson> lessonsToTeach)
        {
            this.name = name;
            this.lessonsToTeach = lessonsToTeach;
        }
    }
}
