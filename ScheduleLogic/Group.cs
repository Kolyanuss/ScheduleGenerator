namespace ScheduleLogic
{
    public class Group
    {
        public string name;
        public int countOfStudents;

        public Group()
        {
            name = "";
        }
        public Group(string name, int countOfStudents)
        {
            this.name = name;
            this.countOfStudents = countOfStudents;
        }
    }
}