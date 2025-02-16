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
            Console.WriteLine("The Types Of Goal Are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Gaol");

            
        }

        public void ListGoalDetails()
        {

        }

        public void CreateGoal()
        {
            Console.WriteLine("What type of goal would you love to create: ");
            string goal = Console.ReadLine();b

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