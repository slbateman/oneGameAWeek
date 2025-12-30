using Godot;
using System;

public partial class Counter : Control
{
	private Label CountLabel => GetNode<Label>("CountLabel");
	private int count = 0;

	public override void _Ready()
	{
		CountLabel.Text = $"Count: {count}";
	}
	private void _on_click_button_click_button_pressed()
	{
		count++;
		CountLabel.Text = $"Count: {count}";
	}
}
