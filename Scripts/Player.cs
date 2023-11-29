using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public int ControllerId;

    public int Hp;
    public string Name;
    public int Direction;

    public void ChangeDirection()
    {
        Direction *= -1;
        GetNode<AnimatedSprite2D>("AnimatedSprite2D").Scale = new Vector2(6 * Direction, 6);
    }
}
