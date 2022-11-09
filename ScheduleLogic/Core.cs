namespace ScheduleLogic
{
    public class Core
    {
        public HashSet<Teacher> teachers;
        public HashSet<Group> groups;
        public HashSet<Audience> audiences;
        public HashSet<Lesson> lessons;
        public HashSet<Teacher> freeTeachers;
        public HashSet<Audience> freeAudiences;

        public int countOfWorkingDay = 5;
        public int countOfMaxClassesInDay = 6;

        public Dictionary<Group, HashSet<Lesson>> listLessonForGroup;

        public Dictionary<Group, List<Classes>> shedule;

        #region ctor
        public Core()
        {
            teachers = new HashSet<Teacher>();
            groups = new HashSet<Group>();
            audiences = new HashSet<Audience>();
            lessons = new HashSet<Lesson>();
            listLessonForGroup = new Dictionary<Group, HashSet<Lesson>>();
            shedule = new List<Dictionary<Group, Classes>>();
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
            shedule = new List<Dictionary<Group, Classes>>();
        }

        public Core(HashSet<Teacher> teachers,
                    HashSet<Group> groups,
                    HashSet<Audience> audiences,
                    HashSet<Lesson> lessons,
                    Dictionary<Group, HashSet<Lesson>> listLessonForGroup)
            : this(teachers, groups, audiences, lessons)
            => this.listLessonForGroup = listLessonForGroup;
        #endregion

        private Teacher? GetFreeTeacher(Lesson requiredLesson)
        {
            foreach (var teacher1 in freeTeachers)
            {
                foreach (var lesson1 in teacher1.lessonsToTeach)
                {
                    if (lesson1 == requiredLesson)
                    {
                        return teacher1;
                    }
                }
            }
            return null;
        }

        private Classes? GenerateClasses()
        {
            var currentLesson = item.Value.FirstOrDefault();
            if (currentLesson == null)
            {
                return null;
            }
            var currentTeacher = GetFreeTeacher(currentLesson);
            if (currentTeacher == null)
            {
                throw new ArgumentException("Не хватає вільних вчителів");
            }

            return new Classes(currentTeacher, currentLesson, freeAudiences.FirstOrDefault()); 
        }

        public Dictionary<Group, List<Classes>> GenerateShedule()
        {
            shedule = new Dictionary<Group, List<Classes>>();
                        
            foreach (var item in listLessonForGroup)
            {
                // to do: add logic \ cycle
                var currentClasses = GenerateClasses();
                if (currentClasses == null)
                {
                    continue;
                }
                shedule.Add(item.Key, currentClasses);
            }

            return shedule;
        }
    }
}