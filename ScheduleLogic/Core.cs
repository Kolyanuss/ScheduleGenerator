namespace ScheduleLogic
{
    public class Core
    {
        public HashSet<Teacher> teachers;
        public HashSet<Group> groups;
        public HashSet<Audience> audiences;
        public HashSet<Lesson> lessons;

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
            shedule = new Dictionary<Group, List<Classes>>();
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
            shedule = new Dictionary<Group, List<Classes>>();
        }

        public Core(HashSet<Teacher> teachers,
                    HashSet<Group> groups,
                    HashSet<Audience> audiences,
                    HashSet<Lesson> lessons,
                    Dictionary<Group, HashSet<Lesson>> listLessonForGroup)
            : this(teachers, groups, audiences, lessons)
            => this.listLessonForGroup = listLessonForGroup;
        #endregion

        private Lesson ChooseLesson()
        { // todo: add code for chose lesson
            item.Value.FirstOrDefault();
            return;
        }

        private Teacher GetFreeTeacher(Lesson requiredLesson)
        {
            foreach (var teacher1 in teachers)
            {
                foreach (var lesson1 in teacher1.lessonsToTeach)
                {
                    if (lesson1 == requiredLesson)
                    {
                        return teacher1;
                    }
                }
            }
            throw new ArgumentException("Не хватає вільних вчителів");
        }

        private Audience GetFreeAudience(Specification specification = Specification.Ordinary)
        {
            var result = audiences.FirstOrDefault();
            if (result == null)
            {
                throw new ArgumentException("Не хватає вільних аудиторій");
            }
            return result;
        }

        private Classes? GenerateClasses()
        // 1 choose lesson
        // 2 get free teacher
        // 3 get freee audience
        {
            var currentLesson = ChooseLesson();
            if (currentLesson == null)
            {
                return null;
            }
            var currentTeacher = GetFreeTeacher(currentLesson);
            var currentAudience = GetFreeAudience();

            return new Classes(currentTeacher, currentLesson, currentAudience);
        }

        public Dictionary<Group, List<Classes>> GenerateShedule()
        {
            shedule = new Dictionary<Group, List<Classes>>();

            foreach (var item in listLessonForGroup)
            {
                List<Classes> allClassesForWeek = new List<Classes>();
                for (int i = 0; i < countOfWorkingDay; i++)
                {
                    for (int j = 0; j < countOfMaxClassesInDay; j++)
                    {
                        allClassesForWeek.Add(GenerateClasses());
                    }
                }
                shedule.Add(item.Key, allClassesForWeek);
            }

            return shedule;
        }
    }
}