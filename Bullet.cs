using System;
using static System.Net.Mime.MediaTypeNames;

public class Bullet : Projectile
{
    private static Random random = new Random();

    public Bullet(int damage) : base(damage) { }

    public override void HitTarget(IDamageable target)
    {
        int scatterDamage = random.Next(damage - 3, damage + 4); 
        Console.WriteLine($"Bullet hits with {scatterDamage} damage.");
        target.TakeDamage(scatterDamage);
    }
}
