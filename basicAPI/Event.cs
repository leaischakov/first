namespace basicAPI
{
    public class Event
    {
        int id;
        string title;
        DateTime start;
        DateTime end;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }

        public Event(int id, string title, DateTime start, DateTime end)
        {
            this.id = id;
            this.title = title;
            this.start = start;
            this.end = end;
        }
        public Event(DateTime start)
        {
            id=0;
            title = "i do homeWork";
            this.start = start;
            end = DateTime.Now;
        }
    }
}
