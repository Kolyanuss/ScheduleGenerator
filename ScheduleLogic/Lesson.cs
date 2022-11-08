namespace ScheduleLogic
{
    public class Lesson
    {
        public string name;
        /// <summary>
        /// The amount of work (lecture) of the student (in hours)
        /// </summary>
        public int amountOfWork_lecture;
        /// <summary>
        /// The amount of work (pratics) of the student (in hours)
        /// </summary>
        public int amountOfWork_practics;
        /// <summary>
        /// The amount of all work of the student (in hours)
        /// </summary>
        public int amountOfWork { get { return amountOfWork_lecture + amountOfWork_practics; } }

        public Lesson()
        {
            name = "";
        }
        public Lesson(string name, int amountOfWork_lecture, int amountOfWork_practics)
        {
            this.name = name;
            this.amountOfWork_lecture = amountOfWork_lecture;
            this.amountOfWork_practics = amountOfWork_practics;
        }
    }
}