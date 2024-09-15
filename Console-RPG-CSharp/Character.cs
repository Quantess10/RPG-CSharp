namespace RPG
{
    class Character
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private int attack_power;

        public int AttackPower
        {
            get { return attack_power; }
            set { attack_power = value; }
        }

        private int defense;

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }


        public void Attack(Character target)
        {
            Console.WriteLine($"{Name} atakuje {target.Name} i zadaje: {AttackPower - Defense} obra¿eñ.");
            target.TakeDamage(AttackPower - Defense);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} traci {damage} punktów zdrowia. Pozosta³o {Health} PZ.");
            Console.WriteLine();
        }

    }
}