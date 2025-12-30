using Godot;
using System;

public partial class Timer : Control
{
	[Signal]
	public delegate void TimeUpEventHandler();

	private Label TimerLabel => GetNode<Label>("TimerLabel");
	private float countDownStartSeconds = 10f;

	public override void _Process(double delta)
	{
		if (countDownStartSeconds > 0f)
		{
			countDownStartSeconds -= (float)delta;
		}
		else
		{
			countDownStartSeconds = 0f;
			EmitSignal(nameof(TimeUp));
		}
		TimerLabel.Text = $"Time: {countDownStartSeconds:F2} s";
	}
}
