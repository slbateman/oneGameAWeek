using Godot;
using System;

public partial class ClickButton : Area3D
{
	[Signal]
	public delegate void ClickButtonPressedEventHandler();

	private CsgCylinder3D ButtonBody => GetNode<CsgCylinder3D>("ButtonBody");

	public override void _InputEvent(
		Camera3D camera,
		InputEvent @event,
		Vector3 position,
		Vector3 normal,
		int shapeIdx)
	{
		if (@event is InputEventMouseButton mouseEvent &&
			mouseEvent.Pressed &&
			mouseEvent.ButtonIndex == MouseButton.Left)
		{
			MoveButtonDown();
			GetTree().CreateTimer(0.1f).Timeout += MoveButtonUp;
			EmitSignal(nameof(ClickButtonPressed));
		}
	}

	public void _on_timer_time_up()
	{
		SetProcessInput(false);
		// pause
		GetTree().Paused = true;
	}

	private void MoveButtonDown()
	{
		ButtonBody.Position -= new Vector3(0, 0.1f, 0);
	}
	private void MoveButtonUp()
	{
		ButtonBody.Position += new Vector3(0, 0.1f, 0);
	}
}
