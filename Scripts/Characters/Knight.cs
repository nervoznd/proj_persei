using Godot;
using System;

public partial class Knight : Player
{
    public override void _Ready()
    {
        ASprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        ASprite.Play();

        Hp = 100;
        Name = "Knight";
    }
}
