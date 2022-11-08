namespace ScheduleLogic
{
    public class Core
    {
        public HashSet<Teacher> teachers;
        public HashSet<Group> groups;
        public HashSet<Audience> audiences;
        public HashSet<Lesson> lessons;

        public Dictionary<Group, HashSet<Lesson>> listLessonForGroup;

        public Core()
        {
            teachers = new HashSet<Teacher>();
            groups = new HashSet<Group>();
            audiences = new HashSet<Audience>();
            lessons = new HashSet<Lesson>();
            listLessonForGroup = new Dictionary<Group, HashSet<Lesson>>();
        }

        public Core(HashSet<Teacher> teachers,
                    HashSet<Group> groups,
                    HashSet<Audience> audiences,
                    HashSet<Lesson> lessons)
        {
            this.teachers = teachers;
            this.groups = groups;
            this.audiences = audiences;
            this.lessons = lessons;
            listLessonForGroup = new Dictionary<Group, HashSet<Lesson>>();
        }

        public Core(HashSet<Teacher> teachers,
                    HashSet<Group> groups,
                    HashSet<Audience> audiences,
                    HashSet<Lesson> lessons,
                    Dictionary<Group, HashSet<Lesson>> listLessonForGroup)
            : this(teachers, groups, audiences, lessons) 
            => this.listLessonForGroup = listLessonForGroup;

        public void GenerateShedule()
        {

        }
    }
}