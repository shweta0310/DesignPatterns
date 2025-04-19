namespace DesignPatterns.TemplateMethodPattern
{
    internal class TemplateMethodPattern
    {
        public static void RunPattern()
        {
            Creature creature1 = new Creature(9, 9);
            Creature creature2 = new Creature(1, 1);

            CardGame temporaryCardDamageGame = new TemporaryCardDamageGame(creature1, creature2);
            Console.WriteLine("Temporary Card Damage Game:");
            temporaryCardDamageGame.Play();

            creature1 = new Creature(9, 9);
            creature2 = new Creature(1, 1);

            Console.WriteLine();
            CardGame permanentCardDamageGame = new PermanentCardDamageGame(creature1, creature2);
            Console.WriteLine("Permanent Card Damage Game:");
            permanentCardDamageGame.Play();
        }
    }
}
