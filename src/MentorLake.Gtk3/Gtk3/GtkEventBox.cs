namespace MentorLake.Gtk3.Gtk3;

public class GtkEventBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkEventBoxHandle New()
	{
		return GtkEventBoxExterns.gtk_event_box_new();
	}

}

public static class GtkEventBoxHandleExtensions
{
	public static bool GetAboveChild(this GtkEventBoxHandle event_box)
	{
		return GtkEventBoxExterns.gtk_event_box_get_above_child(event_box);
	}

	public static bool GetVisibleWindow(this GtkEventBoxHandle event_box)
	{
		return GtkEventBoxExterns.gtk_event_box_get_visible_window(event_box);
	}

	public static GtkEventBoxHandle SetAboveChild(this GtkEventBoxHandle event_box, bool above_child)
	{
		GtkEventBoxExterns.gtk_event_box_set_above_child(event_box, above_child);
		return event_box;
	}

	public static GtkEventBoxHandle SetVisibleWindow(this GtkEventBoxHandle event_box, bool visible_window)
	{
		GtkEventBoxExterns.gtk_event_box_set_visible_window(event_box, visible_window);
		return event_box;
	}

}

internal class GtkEventBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEventBoxHandle gtk_event_box_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_event_box_get_above_child(GtkEventBoxHandle event_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_event_box_get_visible_window(GtkEventBoxHandle event_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_event_box_set_above_child(GtkEventBoxHandle event_box, bool above_child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_event_box_set_visible_window(GtkEventBoxHandle event_box, bool visible_window);

}
