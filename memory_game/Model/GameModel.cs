using memory_game.Persistence;
using System;
using System.Collections.Generic;

namespace memory_game.Model
{
    public class GameModel
    {
        private ModelTable _table;
        private Int32 _gameStepCount;
        private Int32 _secCount;
        private Int32 _random;
        public Int32 GameStepCount { get { return _gameStepCount; } }
        public Int32 this[Int32 x] { get { return GetValue(x); } }
        public ModelTable GameTable { get => _table; set => _table = value; }
        public Boolean IsGameOver { get => _secCount >= 30000; }
        public Int32 SecCount { get => _secCount; set => _secCount = value; }
        public Int32 Random { get => _random; set => _random = value; }
        private int _good;

        public int Good
        {
            get { return _good; }
            set { _good = value; }
        }
        private int _bad;

        public int Bad
        {
            get { return _bad; }
            set { _bad = value; }
        }

        public event EventHandler GameOver;
        public GameModel()
        {
            _table = new ModelTable();
        }
        public int GetValue(Int32 x)
        {
            return _table[x];
        }
        public void NewGameFour()
        {
            _table = new ModelTable(4);
            _table.Size = 4;
            SecCount = 0;
            Bad = 0;
            Good = 0;
            GenerateFields(_table.Size);
            GenerateMatch();
        }
        public void NewGameEight()
        {
            _table = new ModelTable(8);
            _table.Size = 8;
            SecCount = 0;
            Bad = 0;
            Good = 0;
            GenerateFields(_table.Size);
            GenerateMatch();
        }
        public void NewGameSixTeen()
        {
            _table = new ModelTable(16);
            _table.Size = 16;
            SecCount = 0;
            Bad = 0;
            Good = 0;
            GenerateFields(_table.Size);
            GenerateMatch();
        }
        public void GenerateFields(int size)
        {
            Random r = new Random();
            int random;
            HashSet<int> randoms = new HashSet<int>();
            while (randoms.Count < size)
            {
                random = r.Next(0, size);
                randoms.Add(random);
            }
            int index = 0;
            foreach (int item in randoms)
            {
                _table.SetValue(index, item);
                index++;
            }
        }
        public void GenerateMatch()
        {
            Random r = new Random();
            _random = r.Next(0, _table.Size);
        }
        public void OnGameOver()
        {
            if (IsGameOver)
            {
                GameOver?.Invoke(this, EventArgs.Empty);
            }
        }
        public void Timer_Tick()
        {
            GenerateMatch();
            if (IsGameOver)
            {
                OnGameOver();
            }
        }
    }
}
