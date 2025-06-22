using System;

public class BreakableWall : IDamageable
{
    public int Durability { get; private set; }

    public BreakableWall(int durability)
    {
        Durability = durability;
    }

    public void TakeDamage(int damage)
    {
        Durability -= damage;
        Console.WriteLine($"Wall takes {damage} damage. Remaining durability: {Durability}");

        if (Durability <= 0)
        {
            Console.WriteLine("Wall is broken!");
        }
    }
}
