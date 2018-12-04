namespace Trivia
{
    public class Player
    {
        const int MAX_POSITION = 11;
        private const int GO_BACK = -12;

        public int Position { get; private set; }
        public int Points { get; private set; }
        public string Name { get; private set; }
        public bool IsInPenalityBox { get; private set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public void ReturnToStartingBox()
        {
            Position = 0;
        }

        public void SetPosition(int rollResult)
        {
            Position += rollResult;
            if (Position > MAX_POSITION)
                SetPosition(GO_BACK);
        }

        public void AddPurse()
        {
            Points++;
        }

        internal void SendToPenalityBox()
        {
            this.IsInPenalityBox = true;
        }
    }
}
