using Godot;
using System;

public partial class player : CharacterBody2D
{
    [Export] public float speed = 300f; //300f = 300.0  f is float

/*Delta = time between frames, time taken to call next frame. 
 */
    public override void _PhysicsProcess(double delta)
    {
       LookAt(GetGlobalMousePosition()); //tell char to look towards mouse

    
       // Will create vector with ur bindings 
       Vector2 move_input = Input.GetVector("left", "right", "up", "down");

       Velocity = move_input * speed;

       MoveAndSlide(); // will apply velocity to our movements 
    }

    
}
