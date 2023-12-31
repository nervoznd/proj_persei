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
        ASprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        ASprite.Animation = "idle";
        ASprite.Play();
    }

    public void ChangeDirection()
    {
        Direction *= -1;
        ASprite.Scale = new Vector2(6 * Direction, 6);
    }
}
