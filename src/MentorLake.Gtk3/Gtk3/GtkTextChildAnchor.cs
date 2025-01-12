namespace MentorLake.Gtk3.Gtk3;

public class GtkTextChildAnchorHandle : GObjectHandle
{
	public static GtkTextChildAnchorHandle New()
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new();
	}

}

public static class GtkTextChildAnchorHandleExtensions
{
	public static bool GetDeleted(this GtkTextChildAnchorHandle anchor)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_deleted(anchor);
	}

	public static GListHandle GetWidgets(this GtkTextChildAnchorHandle anchor)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_widgets(anchor);
	}

}

internal class GtkTextChildAnchorExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_child_anchor_get_deleted(GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_text_child_anchor_get_widgets(GtkTextChildAnchorHandle anchor);

}
