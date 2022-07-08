using memory_game.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace memory_game
{
    public partial class Form1 : Form
    {
        private GameModel _model;
        private Button[] _buttonGrid;
        private Button _match;
        private Timer _timer;
        private Timer _timerHelp;
        private Int32 _clicked;
        private Image[] imgs;
        private int _showedSec;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            _model = new GameModel();
            imgs = new Image[32];
            _timer = new Timer();
            _timer.Interval = 2000;
            _timer.Tick += Timer_Tick;
            _timerHelp = new Timer();
            _timerHelp.Interval = 1000;
            _timerHelp.Tick += TimerHelp_Tick;
            _model.GameOver += new EventHandler(Game_GameOver);
            GeneratePictures();
            NewGameFour(this,EventArgs.Empty);
        }

        private void TimerHelp_Tick(object sender, EventArgs e)
        {
            _showedSec +=_timerHelp.Interval;
            if (_showedSec / 1000 == _model.GameTable.Size)
            {
                _timerHelp.Stop();
                for (int i = 0; i < _model.GameTable.Size; i++)
                {
                    _buttonGrid[i].BackgroundImage = null;
                }
                _timer.Start();
            }
        }

        private void StartShow()
        {
            for (int i = 0; i < _model.GameTable.Size; i++)
            {
                _buttonGrid[i].BackgroundImage = imgs[_model.GameTable.GetValue(i)];
            }
        }
        private void GeneratePictures()
        {
            for (int i = 0; i < 32; i++)
            {
                imgs[i] = Image.FromFile("images\\"+(i + 1) + ".jpg");
            }
        }
        private void Game_GameOver(object sender, EventArgs e)
        {
            _timer.Stop();
            double arany = 1;
            if (_model.Bad != 0)
            {
                arany = _model.Good * 1.0 / _model.Bad;
            }
            for (Int32 i = 0; i < _model.GameTable.Size; i++)
            {
                _buttonGrid[i].Enabled = false;
            }
            MessageBox.Show("GameOver!\n A sikeres és sikertelen találatok aránya: " + arany +"\nAz eltelt idő: "+_model.SecCount*1.0/1000);

        }
        public void NewGameFour(object sender, EventArgs e)
        {
            _showedSec = 0;
            _model.NewGameFour();
            GenerateTable();
            SetupTable();
            StartShow();
            //_timer.Start();
            _timerHelp.Start();
        }
        public void NewGameSixTeen(object sender, EventArgs e)
        {
            _showedSec = 0;
            _model.NewGameSixTeen();
            GenerateTable();
            SetupTable();
            StartShow();
            //_timer.Start();
            _timerHelp.Start();
        }
        public void NewGameEight(object sender, EventArgs e)
        {
            _showedSec = 0;
            _model.NewGameEight();
            GenerateTable();
            SetupTable();
            StartShow();
            //_timer.Start();
            _timerHelp.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _model.Timer_Tick();
            _model.SecCount += _timer.Interval;
            if (_clicked != -1)
            {
                if (_clicked == _model.Random)
                {
                    _model.Good++;
                }
                else
                {
                    _model.Bad++;
                }
            }
            for (int i = 0; i < _model.GameTable.Size; i++)
            {
                _buttonGrid[i].BackgroundImage = null;
            }
            for(int i = 0; i < _model.GameTable.Size; i++)
            {
                _buttonGrid[i].Enabled = true;
            }
            _match.BackgroundImage = imgs[_model.Random];
            _clicked = -1;

        }
        private void ButtonGrid_MouseClick(Object sender, MouseEventArgs e)
        {
            Int32 x = ((sender as Button).TabIndex);
            _buttonGrid[x].BackgroundImage = imgs[_model.GameTable.GetValue(x)];
            _clicked = _model.GameTable.GetValue(x);
            for (int i = 0; i < _model.GameTable.Size; i++)
            {
                _buttonGrid[i].Enabled = false;
            }
        }
        private void GenerateTable()
        {
            if (_buttonGrid != null)
            {
                for (int i = 0; i < _buttonGrid.Length; i++)
                {
                    Controls.Remove(_buttonGrid[i]);
                }
            }
            _buttonGrid = new Button[_model.GameTable.Size];
            for (Int32 i = 0; i < _model.GameTable.Size; i++)
            {
                {
                    _buttonGrid[i] = new Button();
                    _buttonGrid[i].Location = new Point(5 + 80 * i, 35 + 80); // elhelyezkedés
                    _buttonGrid[i].Size = new Size(80, 80); // méret
                    _buttonGrid[i].Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold); // betűtípus
                    _buttonGrid[i].Enabled = false; // kikapcsolt állapot
                    _buttonGrid[i].TabIndex = i; // a gomb számát a TabIndex-ben tároljuk
                    _buttonGrid[i].FlatStyle = FlatStyle.Flat; // lapított stípus
                    _buttonGrid[i].BackgroundImageLayout = ImageLayout.Stretch;
                    _buttonGrid[i].MouseClick += new MouseEventHandler(ButtonGrid_MouseClick);
                    Controls.Add(_buttonGrid[i]);
                }
            }
            if (_match == null)
            {
                _match = new Button();
                _match.Location = new Point(250, 200); //1-1
                _match.Size = new Size(80, 80);
                _match.Enabled = false;
                _match.Font = new Font(FontFamily.GenericSansSerif, 25, FontStyle.Bold);
                Controls.Add(_match);
            }
        }
        private void SetupTable()
        {
            for (Int32 i = 0; i < _model.GameTable.Size; i++)
            {

                _buttonGrid[i].Enabled = true;
                _buttonGrid[i].BackColor = Color.White;
            }
            _match.BackgroundImage = imgs[_model.Random];
            _match.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
