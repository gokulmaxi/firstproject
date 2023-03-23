namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssesHero hero = new AssesHero("hero",50,1);
            AssesHero villian = new AssesHero("villian",50,3);
            Random rn = new Random();
            while (true)
            {
                if (rn.Next(2) == 1)
                {
                    if(hero.shoot())break;
                }
                else
                {
                    if(villian.shoot())break;
                }
            }
        }
    }
}