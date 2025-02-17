namespace Goal
{
    public class GoalManager
    {
        private List<string> _goals = new List<string>();
        private int _score = 0;
        private List<int> _points = new List<int>();

        
        public GoalManager()
        {}

        public void Start()
        {

        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points");
        }

        public void ListGoalNames()
        {
           

            
        }

        public void ListGoalDetails()
        {  
            Console.WriteLine("The goals are: ");
            int number =1;
           foreach(string goal in _goals)
           {
                Console.WriteLine($"{number}. {goal}");
                number =number+1;
           }
        }

        public void CreateGoal()
        {
            string goalChoice = Console.ReadLine();
            Console.WriteLine(); 
                if (goalChoice=="1")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is the description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("Points for goal? ");
                    string points = Console.ReadLine();
                    SimpleGoal simpleGoal = new SimpleGoal(name,description,int.Parse(points));
                    
                    string goal =$"[ ] {name} ({description})";
                    _goals.Add(goal);
                    _points.Add(int.Parse(points));

                    Console.WriteLine();
                }
                else if (goalChoice=="2")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is the description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("Points for goal? ");
                    string points = Console.ReadLine();
                    EternalGoal eternalGoal = new EternalGoal(name,description,int.Parse(points));
                    string goal =$"[ ] {name} ({description})";
                    _goals.Add(goal);
                    _points.Add(int.Parse(points));

                    Console.WriteLine();
                }
                else if (goalChoice=="3")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is the description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("Points for goal? ");
                    string points = Console.ReadLine();
                    Console.Write("How many times does this goal need to be accomplished before a bonus? ");
                    string times = Console.ReadLine();
                    Console.Write("Bonus for completing number of times? ");
                    string bonus = Console.ReadLine();

                    CheckListGoal checkListGoal = new CheckListGoal(name,description,int.Parse(points),int.Parse(times),int.Parse(bonus));
                    string details= checkListGoal.GetDetailsString();
                    //string goal =$"[ ] {name} ({description})";
                    _goals.Add(details);
                    _points.Add(int.Parse(points));
                    Console.WriteLine();       
                }



            
           


   

        }

        public void RecordEvent()
        {
            Console.WriteLine();
            Console.WriteLine("What goal did you accomplish? ");


        }

        public void SaveGoals()
        {   
            Console.WriteLine();
            Console.WriteLine("What is the name of the file: ");
            string fileName= Console.ReadLine();


        }

        public void LoadGoals()
        {

        }
    }
}