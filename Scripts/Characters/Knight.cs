using Godot;
using System;

public partial class Knight : Player
{
    public override void _Ready()
    {
        Hp = 100;
        Name = "Knight";
    }
}
