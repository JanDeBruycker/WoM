namespace WorldOfMagic.Classes.Data
{
    public class Speech
    {
        public int Id { get; private set; }
        public string Begin { get; private set; }
        public string End { get; private set; }

        public void Set(int id, string begin, string end)
        {
            Id = id;
            Begin = begin;
            End = end;
        }
    }
}
