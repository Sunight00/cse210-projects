namespace Goal
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        
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

        }

        public void CreateGoal()
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is the description of it? ");
            string description = Console.ReadLine();
            Console.Write("Points for goal? ");
            string points = Console.ReadLine();

        }

        public void RecordEvent()
        {

        }

        public void SaveGoals()
        {

        }

        public void LoadGoals()
        {

        }
    }
}