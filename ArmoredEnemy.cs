using System;

public class ArmoredEnemy : IDamageable
{
    public int Health { get; private set; }
    private double resistance; // Наприклад, 0.5 означає 50% шкоди

    public ArmoredEnemy(int health, double resistance = 0.5)
    {
        Health = health;
        this.resistance = resistance;
    }

    public void TakeDamage(int damage)
    {
        int reducedDamage = (int)(damage * resistance);
        Health -= reducedDamage;
        Console.WriteLine($"Armored Enemy takes {reducedDamage} reduced damage. Remaining health: {Health}");

        if (Health <= 0)
        {
            Console.WriteLine("Armored Enemy is destroyed!");
        }
    }
}
