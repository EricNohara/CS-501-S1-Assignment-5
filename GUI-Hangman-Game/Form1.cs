using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hangman_Game
{
    public partial class Form1 : Form
    {
        private List<Tuple<string, string>> wordList;
        private Button[] letterButtons;
        private int mistakeCount;
        private string currentWord;
        private string currentHint;
        private Label[] wordLabels;
        private bool startPage = true;

        public Form1()
        {
            InitializeComponent();
            PopulateWordList();
            PopulateButtons();
            SetPageState();
        }

        private void PopulateWordList()
        {
            wordList = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("APPLE", "A fruit"),
                new Tuple<string, string>("BANANA", "A yellow fruit"),
                new Tuple<string, string>("COMPUTER", "An electronic device"),
                new Tuple<string, string>("HANGMAN", "A classic word guessing game"),
                new Tuple<string, string>("GUITAR", "A musical instrument"),
                new Tuple<string, string>("ELEPHANT", "The largest land animal"),
                new Tuple<string, string>("JUNGLE", "A dense forest"),
                new Tuple<string, string>("PYRAMID", "An ancient structure in Egypt"),
                new Tuple<string, string>("OCEAN", "A large body of salt water")
            };
        }

        private void PopulateButtons() // creating each letter button from A to Z
        {
            letterButtons = new Button[26];
            char letter = 'A';

            for (int i = 0; i< 26; i++)
            {
                letterButtons[i] = new Button
                {
                    Text = letter.ToString()
                };

                letterButtons[i].Click += LetterButton_Click;

                buttonLayoutPanel.Controls.Add(letterButtons[i]);
                letter++;
                
            }

        }

        private void UpdateHangManPicture()
        {
            string imageName = $"Mistake_{mistakeCount}";
            hangManPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string guessedLetter = button.Text;
            button.Enabled = false;

            if (currentWord.Contains(guessedLetter))
            {
                // Correct guess
                UpdateWordDisplay(guessedLetter);
                CheckWinCondition();
            }
            else
            {
                // Incorrect guess
                mistakeCount++;
                UpdateHangManPicture();
                CheckLoseCondition();
            }


        }

        private void UpdateWordDisplay(string guessedLetter) 
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i].ToString().ToUpper() == guessedLetter)
                {
                    wordLabels[i].Text = guessedLetter;
                }
            }
        }

        private void CheckWinCondition()
        {
            bool allRevealed = true;
            foreach (var label in wordLabels)
            {
                if (label.Text == "__")
                {
                    allRevealed = false;
                    break;
                }
            }
            if (allRevealed)
            {
                MessageBox.Show("Congratulations, You win!");
                startPage = true;
                SetPageState();

            }
        }

        private void CheckLoseCondition()
        {
            if (mistakeCount >= 6) // hangman is full
            {
                MessageBox.Show($"Sorry, you lost.");
                startPage = true;
                SetPageState();
            }
        }

        private void PopulateWord(string currentWord) // creating labels for each letter in the word
        {
            wordLabels = new Label[currentWord.Length];
            for (int i = 0; i < currentWord.Length; i++)
            {
                wordLabels[i] = new Label
                {
                    Text = "__",
                    AutoSize = false, 
                    Size = new Size(40, 40),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                wordLayoutPanel.Controls.Add(wordLabels[i]);
            }
        }

        private void StartNewGame()
        {
            if (wordLabels != null) // resets labels for the given word
            {
                foreach (var label in wordLabels)
                {
                    wordLayoutPanel.Controls.Remove(label);
                }
            }

            // resetting all variables and getting new word 
            Random rand = new Random();
            var selectedWord = wordList[rand.Next(wordList.Count)];
            currentWord = selectedWord.Item1;
            currentHint = selectedWord.Item2;
            mistakeCount = 0;

            //resetting UI
            hintWordLabel.Text = $"Hint: {currentHint}";
            UpdateHangManPicture();
            foreach (var button in letterButtons)
            {
                button.Enabled = true;
            }
            PopulateWord(currentWord);


        }

        private void SetPageState() //controlling visibility of controls
        {
            if (startPage)
            {
                foreach (Control control in gamePanel.Controls)
                {
                    control.Enabled = false;
                    control.Visible = false;
                }
                startGameButton.Enabled = true;
                startGameButton.Visible = true;
            } else
            {
                foreach (Control control in gamePanel.Controls)
                {
                    control.Enabled = true;
                    control.Visible = true;
                }
                startGameButton.Enabled = false;
                startGameButton.Visible = false;
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startPage = false;
            SetPageState();
            StartNewGame();
        }
    }
}
