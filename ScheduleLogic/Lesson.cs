namespace ScheduleLogic
{
    public class Lesson
    {
        public string name;
        public int numberClassesPerWeek_lecture;
        public int numberClassesPerWeek_practics;
        public int amountOfWork { get { return numberClassesPerWeek_lecture + numberClassesPerWeek_practics; } }
        public bool isLecture = true;
        public Specification requiredClass;

        public Lesson()
        {
            name = "";
        }
        public Lesson(string name, int numClassesPerWeek_lec, int numClassesPerWeek_pract)
        {
            this.name = name;
            numberClassesPerWeek_lecture = numClassesPerWeek_lec;
            numberClassesPerWeek_practics = numClassesPerWeek_pract;
            requiredClass = Specification.Ordinary;
        }
        public Lesson(string name,
                      int numClassesPerWeek_lec,
                      int numClassesPerWeek_pract,
                      bool isLecture,
                      Specification requiredClass)
            : this(name, numClassesPerWeek_lec, numClassesPerWeek_pract)
        {
            this.isLecture = isLecture;
            this.requiredClass = requiredClass;
        }
    }
}