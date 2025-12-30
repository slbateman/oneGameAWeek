using Godot;
using System;

public partial class MainMenu : Control
{
	private void _on_StartButton_pressed()
	{
		GetTree().ChangeSceneToFile("res://Game/Game.tscn");
	}

	private void _on_QuitButton_pressed()
	{
		GetTree().Quit();
	}
}
