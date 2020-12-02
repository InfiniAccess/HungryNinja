namespace HungryNinja.Model
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
        {
            this.Name = Name;
            this.Calories = Calories;
            this.IsSpicy = IsSpicy;
            this.IsSweet = IsSweet;
        }

    }
}