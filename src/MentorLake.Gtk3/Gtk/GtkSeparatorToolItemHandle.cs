namespace MentorLake.Gtk;

public class GtkSeparatorToolItemHandle : GtkToolItemHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSeparatorToolItemHandle New()
	{
		return GtkSeparatorToolItemHandleExterns.gtk_separator_tool_item_new();
	}

}

public static class GtkSeparatorToolItemHandleExtensions
{
	public static bool GetDraw(this MentorLake.Gtk.GtkSeparatorToolItemHandle item)
	{
		return GtkSeparatorToolItemHandleExterns.gtk_separator_tool_item_get_draw(item);
	}

	public static T SetDraw<T>(this T item, bool draw) where T : GtkSeparatorToolItemHandle
	{
		GtkSeparatorToolItemHandleExterns.gtk_separator_tool_item_set_draw(item, draw);
		return item;
	}

}

internal class GtkSeparatorToolItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSeparatorToolItemHandle gtk_separator_tool_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_separator_tool_item_get_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorToolItemHandle>))] MentorLake.Gtk.GtkSeparatorToolItemHandle item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_separator_tool_item_set_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorToolItemHandle>))] MentorLake.Gtk.GtkSeparatorToolItemHandle item, bool draw);

}
