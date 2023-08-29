using Godot;
using System;

public class KinematicBody2DMovement : KinematicBody2D
{
	private Vector2 velocity = Vector2.zero;
	private Vector2 acceleration = Vector2.zero;

	private void _physics_process(float delta)
	{
		// Update velocity
		velocity += acceleration * delta;

		// Apply velocity to the physics body
		move_and_slide(velocity);
	}

	private void _on_input(InputEvent event)
	{
		// Control object movement with keyboard
		if (event.is_action_pressed("ui_left"))
		{
			velocity.x -= 100;
		}
		else if (event.is_action_pressed("ui_right"))
		{
			velocity.x += 100;
		}
		if (event.is_action_pressed("ui_up"))
		{
			velocity.y -= 100;
		}
		else if (event.is_action_pressed("ui_down"))
		{
			velocity.y += 100;
		}
	}
}
