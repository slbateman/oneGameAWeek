using Godot;
using System;

public partial class PausMenu : Control
{
	public override void _Ready()
	{
		ProcessMode = Node.ProcessModeEnum.Always;
		Visible = GetTree().Paused;
	}

	public override void _Process(double delta)
	{
		Visible = GetTree().Paused;
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event.IsActionPressed("ui_cancel"))
		{
			GetTree().Paused = !GetTree().Paused;
		}
	}

	private void _on_ResumeButton_pressed()
	{
		// unpause
		GetTree().Paused = false;
	}

	private void _on_QuitButton_pressed()
	{
		GetTree().Quit();
	}

	private void _on_RestartButton_pressed()
	{
		GetTree().Paused = false;
		GetTree().ReloadCurrentScene();
	}
}
