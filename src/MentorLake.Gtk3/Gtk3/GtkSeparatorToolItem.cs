namespace MentorLake.Gtk3.Gtk3;

public class GtkSeparatorToolItemHandle : GtkToolItemHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkSeparatorToolItemHandle New()
	{
		return GtkSeparatorToolItemExterns.gtk_separator_tool_item_new();
	}

}

public static class GtkSeparatorToolItemHandleExtensions
{
	public static bool GetDraw(this GtkSeparatorToolItemHandle item)
	{
		return GtkSeparatorToolItemExterns.gtk_separator_tool_item_get_draw(item);
	}

	public static GtkSeparatorToolItemHandle SetDraw(this GtkSeparatorToolItemHandle item, bool draw)
	{
		GtkSeparatorToolItemExterns.gtk_separator_tool_item_set_draw(item, draw);
		return item;
	}

}

internal class GtkSeparatorToolItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSeparatorToolItemHandle gtk_separator_tool_item_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_separator_tool_item_get_draw(GtkSeparatorToolItemHandle item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_separator_tool_item_set_draw(GtkSeparatorToolItemHandle item, bool draw);

}
