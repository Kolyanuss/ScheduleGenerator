namespace ScheduleLogic
{
    public enum Specification
    {
        Ordinary, LectureHall, ComputerClass, ChemicalLaboratory
    }
    public class Audience
    {
        public string name;
        public int maxCountOfSeats;
        public Specification specification;

        public Audience()
        {
            name = "";
        }
        public Audience(string name, int maxCountOfSeats, Specification specification)
        {
            this.name = name;
            this.maxCountOfSeats = maxCountOfSeats;
            this.specification = specification;
        }
    }
}