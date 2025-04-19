namespace DesignPatterns.TemplateMethodPattern
{
    internal abstract class CardGame
    {
        public Creature Creature1 { get; set; }
        public Creature Creature2 { get; set; }

        public CardGame(Creature creature1, Creature creature2)
        {
            Creature1 = creature1;
            Creature2 = creature2;
        }

        protected abstract void Hit(Creature attacker, Creature defender);

        public void Play()
        {
            Console.WriteLine("Game Start!");
            while (Creature1.Health > 0 && Creature2.Health > 0)
            {
                Hit(Creature1, Creature2);
                Console.WriteLine($"Creature 1 attacks Creature 2. Creature 2 Health: {Creature2.Health}");
                Hit(Creature2, Creature1);
                Console.WriteLine($"Creature 2 attacks Creature 1. Creature 1 Health: {Creature1.Health}");
            }

            if (Creature1.Health <= 0)
            {
                Console.WriteLine("Creature 2 wins!");
            }
            else if (Creature2.Health <= 0)
            {
                Console.WriteLine("Creature 1 wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }

    internal class TemporaryCardDamageGame : CardGame
    {
        public TemporaryCardDamageGame(Creature creature1, Creature creature2) : base(creature1, creature2)
        {
        }

        protected override void Hit(Creature attacker, Creature defender)
        {
            var oldDefenderHealth = defender.Health;
            defender.Health -= attacker.AttackPower;

            if (defender.Health > 0)
            {
                defender.Health = oldDefenderHealth;
            }
        }
    }

    internal class PermanentCardDamageGame : CardGame
    {
        public PermanentCardDamageGame(Creature creature1, Creature creature2) : base(creature1, creature2)
        {
        }

        protected override void Hit(Creature attacker, Creature defender)
        {
            defender.Health -= attacker.AttackPower;
        }
    }
}
