using System;
using System.Collections.Generic;
using Trivia;

namespace UglyTrivia
{
    public class Game
    {
        const int POINTS_TO_DECLARE_WINNER = 6;
        readonly IQuestionManager _QuestionManager;

        bool _IsGettingOutOfPenaltyBox;
        int _IndexOfCurrentPlayer = 0;
        Player _CurrentPlayer
        {
            get
            {
                return _Players[_IndexOfCurrentPlayer];
            }
        }
        List<Player> _Players = new List<Player>();

        public Game(IQuestionManager questionManager)
        {
            _QuestionManager = questionManager;
        }

        public void AddPlayer(string playerName)
        {
            _Players.Add(new Player(playerName));
            Console.WriteLine("{0} was added", playerName);
            Console.WriteLine("They are player number {0}", _Players.Count);
        }
        public void DisplayQuestion(Question question)
        {
            Console.WriteLine("The category is {0}", question.Category);
            Console.WriteLine(question.Interrogation);
        }
        public void Roll(int roll)
        {
            Console.WriteLine("{0} is the current player", _CurrentPlayer.Name);
            Console.WriteLine("They have rolled a {0}", roll);

            if (_CurrentPlayer.IsInPenalityBox)
            {
                if (roll % 2 != 0)
                {
                    _IsGettingOutOfPenaltyBox = true;
                    Console.WriteLine("{0} is getting out of the penalty box", _CurrentPlayer.Name);
                }
                else
                {
                    Console.WriteLine("{0} is not getting out of the penalty box", _CurrentPlayer.Name);
                    _IsGettingOutOfPenaltyBox = false;
                    return;
                }

            }

            this.PlayerMoves(roll);
            Question question = _QuestionManager.AskQuestion(_CurrentPlayer.Position);
            this.DisplayQuestion(question);
        }
        private void PlayerMoves(int roll)
        {
            _CurrentPlayer.SetPosition(roll);
            Console.WriteLine("{0}'s new location is {1}", _CurrentPlayer.Name, _CurrentPlayer.Position);

        }

        public void NextPlayer()
        {
            _IndexOfCurrentPlayer++;
            if (_IndexOfCurrentPlayer == _Players.Count)
                _IndexOfCurrentPlayer = 0;
        }
        public bool GotCorrectAnswer()
        {
            if (_CurrentPlayer.IsInPenalityBox && !_IsGettingOutOfPenaltyBox)
            {
                this.NextPlayer();
                return true;
            }
            else
            {
                Console.WriteLine("Answer was corrent!!!!");
                _CurrentPlayer.AddPurse();
                Console.WriteLine("{0} now has {1} Gold Coins.", _CurrentPlayer.Name, _CurrentPlayer.Points);

                bool isWinning = _CurrentPlayer.Points != POINTS_TO_DECLARE_WINNER;
                this.NextPlayer();

                return isWinning;
            }
        }
        public bool GotWrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine("{0} was sent to the penalty box", _CurrentPlayer.Name);
            _CurrentPlayer.SendToPenalityBox();

            this.NextPlayer();

            return true;
        }

    }

}
