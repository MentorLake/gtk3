namespace MentorLake.Gtk;

public class GtkToplevelAccessibleHandle : AtkObjectHandle
{
}

public static class GtkToplevelAccessibleHandleExtensions
{
	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gtk.GtkToplevelAccessibleHandle accessible)
	{
		return GtkToplevelAccessibleHandleExterns.gtk_toplevel_accessible_get_children(accessible);
	}

}

internal class GtkToplevelAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_toplevel_accessible_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToplevelAccessibleHandle>))] MentorLake.Gtk.GtkToplevelAccessibleHandle accessible);

}
