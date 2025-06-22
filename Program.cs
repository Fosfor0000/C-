using System;
using System.Collections.Generic;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        
        Projectile bullet = new Bullet(25);
        Projectile rocket = new Rocket(50);

        List<IDamageable> targets = new List<IDamageable>
        {
            new Enemy(60),
            new ArmoredEnemy(100),
            new BreakableWall(40)
        };

        Console.WriteLine("=== Bullet shots ===");
        foreach (var target in targets)
        {
            bullet.HitTarget(target);
            Console.WriteLine();
        }

        Console.WriteLine("=== Rocket shots ===");
        foreach (var target in targets)
        {
            rocket.HitTarget(target);
            Console.WriteLine();
        }
    }
}
