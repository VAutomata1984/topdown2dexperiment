using Godot;
using System;

public partial class Health : Node2D
{
    [Export] public float max_health = 100f;
    float health;


    public override void _Ready()
    {
        health = max_health; // when we start game health full
    }

    public void Damage(float damage){
        health -= damage;

        if (health <= 0){
            GetParent().QueueFree();
            
        }
    }
}
