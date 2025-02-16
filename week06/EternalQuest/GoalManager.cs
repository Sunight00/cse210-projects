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
            Console.WriteLine("Simple Goal");
            Console.WriteLine("Eternal Goal");
            Console.WriteLine("Checklist Gaol");
        }

        public void ListGoalDetails()
        {

        }

        public void CreateGoal()
        {

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