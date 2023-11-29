using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public int ControllerId;

    public int Hp;
    public string Name;
    public int Direction;

    public AnimatedSprite2D ASprite;


    public override void _Ready()
    {
    }

    public void ChangeDirection()
    {
        Direction *= -1;
        ASprite.Scale = new Vector2(6 * Direction, 6);
    }
}
