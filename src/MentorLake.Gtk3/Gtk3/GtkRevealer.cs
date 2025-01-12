namespace MentorLake.Gtk3.Gtk3;

public class GtkRevealerHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkRevealerHandle New()
	{
		return GtkRevealerExterns.gtk_revealer_new();
	}

}

public static class GtkRevealerHandleExtensions
{
	public static bool GetChildRevealed(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_child_revealed(revealer);
	}

	public static bool GetRevealChild(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_reveal_child(revealer);
	}

	public static uint GetTransitionDuration(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_transition_duration(revealer);
	}

	public static GtkRevealerTransitionType GetTransitionType(this GtkRevealerHandle revealer)
	{
		return GtkRevealerExterns.gtk_revealer_get_transition_type(revealer);
	}

	public static GtkRevealerHandle SetRevealChild(this GtkRevealerHandle revealer, bool reveal_child)
	{
		GtkRevealerExterns.gtk_revealer_set_reveal_child(revealer, reveal_child);
		return revealer;
	}

	public static GtkRevealerHandle SetTransitionDuration(this GtkRevealerHandle revealer, uint duration)
	{
		GtkRevealerExterns.gtk_revealer_set_transition_duration(revealer, duration);
		return revealer;
	}

	public static GtkRevealerHandle SetTransitionType(this GtkRevealerHandle revealer, GtkRevealerTransitionType transition)
	{
		GtkRevealerExterns.gtk_revealer_set_transition_type(revealer, transition);
		return revealer;
	}

}

internal class GtkRevealerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRevealerHandle gtk_revealer_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_revealer_get_child_revealed(GtkRevealerHandle revealer);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_revealer_get_reveal_child(GtkRevealerHandle revealer);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_revealer_get_transition_duration(GtkRevealerHandle revealer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRevealerTransitionType gtk_revealer_get_transition_type(GtkRevealerHandle revealer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_revealer_set_reveal_child(GtkRevealerHandle revealer, bool reveal_child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_revealer_set_transition_duration(GtkRevealerHandle revealer, uint duration);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_revealer_set_transition_type(GtkRevealerHandle revealer, GtkRevealerTransitionType transition);

}
