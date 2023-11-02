using DeweyDecimalApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_2_Dictionary
{
    public partial class MatchingGame : Form
    {

        private TableLayoutPanel questionTable;
        private TableLayoutPanel answerTable;

        public int WinningPoints;
        public int LosingPoints;


        DeweyDecimalLibrary library = new DeweyDecimalLibrary();

        private Dictionary<string, string> deweyCatergories = new Dictionary<string, string> {
            {"000","General Knowledge"},
            {"100","Philosophy & Pschology"},
            {"200","Religion"},
            {"300","Social Science"},
            {"400","Languages"},
            {"500","Science"},
            {"600","Technology" },
            {"700","Arts & Recreation"},
            {"800","Literature"},
            {"900","History & Geography"}

        };

        //Store Correct Answers for the Pair Checks of t Q and A ( 4 Answers and 4 Questions)
        private Dictionary<string, string> CorrectQuizAnswers = new Dictionary<string, string>();

        //Containing and Storing the users input for There answers
        private Dictionary<string, string> UserAnswers = new Dictionary<string, string>();

        //Containing Each Label of Questions and Answers
        private List<string> questions = new List<string> (); // 4 Questions
        private List<string> randomAnswers = new List<string>();// 7 answers

 //============================================================================================================================================================================//         
        public MatchingGame()
        {
            //Create Deafault as Blank Comments
            CreateGameQuiz();

            



            InitializeComponent();
        }

//==========================================================================================================
private Dictionary<string,string> RandomDeweyCategory()
        {
            Dictionary<string, string> category = new Dictionary<string, string>();

            Random random = new Random(); // Create a single Random object outside the loop

            while (category.Count < 4)
            {
                int randomIndex = random.Next(0, deweyCatergories.Count());
                KeyValuePair<string, string> randomPair = deweyCatergories.ElementAt(randomIndex);

                if (!category.ContainsKey(randomPair.Key))
                {
                    category.Add(randomPair.Key, randomPair.Value);
                }
            }

            return category;            
        }
//===========================================================================================================
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ButtonComplete.Enabled = true;
            ButtonEndGame.Enabled = true;   

            //Create a Random List of Question Values and Answers
            btnStartGame.Hide();
            var keyForRange  = RandomDeweyCategory();
            CorrectQuizAnswers = library.GeneratePair(keyForRange);

            this.Controls.Add(CreateStartQuestionGameTables(CorrectQuizAnswers));
            this.Controls.Add(CreateStartAnswerGameTables(CorrectQuizAnswers));

        }
//============================================================================================================

        //Create New Panel For Values
       
//=============================================================================================================
        private void CreateGameQuiz()
        {
             //Inserting Question Table Containing 4 Values
       
            questionTable = new TableLayoutPanel();
            questionTable.Location = new Point(75, 50);
            questionTable.Size = new Size(300, 500); // Set the size here
            //questionTable.Padding = new Padding(10);
            questionTable.ColumnCount = 1;

            foreach(string question in questions)
            {
                questionTable.Controls.Add(CreatePanels(question)); //Add the random generate dewey catergory
            }
            this.Controls.Add(questionTable);
            
            //Inserting Answer Table Containing 7 Values

            answerTable = new TableLayoutPanel();  
            answerTable.Location = new Point(475, 50);
            answerTable.Size = new Size(300, 550);
           // answerTable.Padding= new Padding(10);
            answerTable.ColumnCount = 1;

            foreach(string answer in randomAnswers)
            {
                answerTable.Controls.Add(CreatePanels(answer));   
            }
            this.Controls.Add(answerTable);

        }
//=========================================================================================================================
private TableLayoutPanel CreateStartQuestionGameTables(Dictionary<string,string> pairs)
        {
            
            questionTable.Dispose();

            questionTable = new TableLayoutPanel();
            questionTable.Location = new Point(75, 50);
            questionTable.Size = new Size(300, 500); // Set the size here
            questionTable.Padding = new Padding(10);
            questionTable.ColumnCount = 1;

            foreach (string question in pairs.Keys)
            {
                questionTable.Controls.Add(CreatePanels(question)); //Add the random generate dewey catergory
            }
            this.Controls.Add(questionTable);

            return questionTable;   

        }
//==========================================================================================================================
       private List<string> AnswersRows(Dictionary<string,string> pairs)
        {
            List<string> answers = new List<string>();
            

            Random random = new Random();

            // Select 4 random answers from your dictionary and add them to the list
            var answerKeys = pairs.Keys.ToList();

            for (int i = 0; i < 4; i++)
            {
                int randomIndex = random.Next(0, answerKeys.Count);
                string randomAnswer = pairs[answerKeys[randomIndex]];
                answers.Add(randomAnswer);
                answerKeys.RemoveAt(randomIndex); // Remove the selected answer to prevent duplicates
            }

            // Fill the list with 3 additional random answers (if desired)
            while (answers.Count < 7)
            {
                //int randomIndex = random.Next(0, answers.Count);
                string randomAnswer = library.RandomCallNumber();
                answers.Add(randomAnswer);
            }
            randomAnswers = answers;

            return answers;
        }
//========================================================================================================================================    
        private TableLayoutPanel CreateStartAnswerGameTables(Dictionary<string, string> pairs)
        {
              answerTable.Dispose();
            

            answerTable = new TableLayoutPanel();
            answerTable.Location = new Point(475, 50);
            answerTable.Size = new Size(300, 700); // Set the size here
            answerTable.Padding = new Padding(10);
            answerTable.ColumnCount = 1;

            //
            var AnswersList = AnswersRows(pairs);
            //

            foreach (string answers in AnswersList)
            {
                answerTable.Controls.Add(CreatePanels(answers)); //Add the random generate dewey catergory
            }
            this.Controls.Add(answerTable);

            return answerTable;

        }
//==========================================================================================================================
        private Panel CreatePanels(string labelText)
        {
            Label label = new Label
            {
                Text = labelText,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Arial",15)
                
            };
            Panel panel = new Panel
            {
                Size = new Size(220, 70),
                BorderStyle = BorderStyle.FixedSingle
                //Dock = DockStyle.Fill
            };
            panel.Controls.Add(label);
            return panel;
        }
//====================================================================================================================================
        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            PanelA.BackColor = CheckAnswerA(Convert.ToInt32(AnswerA.Value));

            PanelB.BackColor = CheckAnswerB(Convert.ToInt32(AnswerB.Value));

            PanelC.BackColor = CheckAnswerC(Convert.ToInt32(AnswerC.Value));

            PanelD.BackColor = CheckAnswerD(Convert.ToInt32(AnswerD.Value));

            //OnClick Change 
            ButtonComplete.Enabled = false;
            ButtonRetry.Show();
        }
        #region
        //Checking Answers for UserAnswers
        private Color CheckAnswerA(int indexOfAnswer)
        {
            Color CheckConfirm;

            var userAnswer = randomAnswers[indexOfAnswer - 1];

            if (userAnswer.Equals(CorrectQuizAnswers.ElementAt(0).Value))
            {
                WinningPoints++;

                WinBoard.Text = Convert.ToString(WinningPoints);
                
                CheckConfirm = Color.Green;
                return CheckConfirm;
            }
            else
            {
                LosingPoints++;

                LossBoard.Text = Convert.ToString(LosingPoints);

                CheckConfirm = Color.Red;   
                return CheckConfirm;
            }

        }

        private Color CheckAnswerB(int indexOfAnswer)
        {
            Color CheckConfirm;

            var userAnswer = randomAnswers[indexOfAnswer - 1];

            if (userAnswer.Equals(CorrectQuizAnswers.ElementAt(1).Value))
            {
                WinningPoints++;

                WinBoard.Text = Convert.ToString(WinningPoints);

                CheckConfirm = Color.Green;
                return CheckConfirm;
            }
            else
            {
                LosingPoints++;

                LossBoard.Text = Convert.ToString(LosingPoints);

                CheckConfirm = Color.Red;
                return CheckConfirm;
            }
        }

        private Color CheckAnswerC(int indexOfAnswer)
        {
            Color CheckConfirm;

            var userAnswer = randomAnswers[indexOfAnswer - 1];

            if (userAnswer.Equals(CorrectQuizAnswers.ElementAt(2).Value))
            {
                WinningPoints++;

                WinBoard.Text = Convert.ToString(WinningPoints);

                CheckConfirm = Color.Green;
                return CheckConfirm;
            }
            else
            {
                LosingPoints++;

                LossBoard.Text = Convert.ToString(LosingPoints);

                CheckConfirm = Color.Red;
                return CheckConfirm;
            }
        }
        private Color CheckAnswerD(int indexOfAnswer)
        {
            Color CheckConfirm;

            var userAnswer = randomAnswers[indexOfAnswer - 1];

            if (userAnswer.Equals(CorrectQuizAnswers.ElementAt(3).Value))
            {
                WinningPoints++;

                WinBoard.Text = Convert.ToString(WinningPoints);

                CheckConfirm = Color.Green;
                return CheckConfirm;
            }
            else
            {
                LosingPoints++;

                LossBoard.Text = Convert.ToString(LosingPoints);

                CheckConfirm = Color.Red;
                return CheckConfirm;
            }
        }
        #endregion

        private void ButtonEndGame_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu();
            gameMenu.Show();
            this.Close();
            
        }
//===================================================================================================================================
       

    }
   }
     

