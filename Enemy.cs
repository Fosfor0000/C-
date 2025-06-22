using System;

public class Enemy : IDamageable
{
    public int Health { get; private set; }

    public Enemy(int health)
    {
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"Enemy takes {damage} damage. Remaining health: {Health}");

        if (Health <= 0)
        {
            Console.WriteLine("Enemy is destroyed!");
        }
    }
}
