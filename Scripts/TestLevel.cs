using Godot;
using System;

public partial class TestLevel : Node2D
{
	PackedScene knightScene = GD.Load<PackedScene>("res://Scenes/Characters/Knight.tscn");

	Player player1;
	Player player2;

	public override void _Ready()
	{
		player1 = knightScene.Instantiate<Player>();
        player2 = knightScene.Instantiate<Player>();

		player1.Position = new Vector2(100, 300);
		player1.ControllerId = 0;
		player1.Direction = 1;

        player2.Position = new Vector2(700, 300);
		player2.ControllerId = 1;
		player2.Direction = 1;
		player2.ChangeDirection();

        AddChild(player1);
        AddChild(player2);
    }

	public override void _Process(double delta)
	{
	}
}
