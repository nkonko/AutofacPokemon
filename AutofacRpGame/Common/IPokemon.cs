namespace AutofacRpGame.Pokemon
{
   public interface IPokemon
    {
        string Name { get; set; }

        string Type { get; set; }

        int Level { get; set; }

        int BaseAttack { get; set; }

        int Healt { get; set; }

        void Attack();

        void Escape();

        void UseObject();
    }
}
