using Godot;
using System;

public partial class Hud : Control
{
	[Signal]
	public delegate void TimeUpEventHandler();

	private Label TimerLabel => GetNode<Label>("TimerLabel");
	private float timerSeconds = 0f;

	public override void _Process(double delta)
	{
		if (GetTree().Paused) return;
		timerSeconds += (float)delta;
		TimerLabel.Text = $"Time: {timerSeconds:F2} s";
	}
}
