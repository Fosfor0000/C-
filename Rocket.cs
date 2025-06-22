using System;
using static System.Net.Mime.MediaTypeNames;

public class Rocket : Projectile
{
    private static Random random = new Random();

    public Rocket(int damage) : base(damage) { }

    public override void HitTarget(IDamageable target)
    {
        int scatterDamage = random.Next(damage - 5, damage + 6); 
        Console.WriteLine($"Rocket hits with {scatterDamage} damage!");
        target.TakeDamage(scatterDamage);
    }
}
