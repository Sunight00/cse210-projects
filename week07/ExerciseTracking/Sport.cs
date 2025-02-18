namespace Sport
{
    public abstract class Sport
    {
        private int _length;
        DateTime _date = DateTime.Now;


            

        public Sport()
        {
            
        }

        public void setDistance( )
        {

        }

        public void displayDate()
        {
            Console.WriteLine(_date);
        }

        public abstract void Distance();
        public abstract void Speed();
        public abstract void Pace();


    }
}