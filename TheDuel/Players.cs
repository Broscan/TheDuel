namespace TheDuel
{
    internal class Player
    {

        public int Health { get; set; }

        public int Damage { get; set; }

        public Player(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public int RollDamage()
        {
            Random randomDamage = new Random();

            randomDamage.Next(0, 25);

            return randomDamage.Next(0, 25);
        }








    }


}

