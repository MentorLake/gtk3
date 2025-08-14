namespace MentorLake.Gtk;


public class GtkToplevelAccessibleHandle : AtkObjectHandle
{
}

public static class GtkToplevelAccessibleHandleExtensions
{

/// <param name="accessible">
/// </param>
/// <return>
/// List of
///   children.
/// </return>

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gtk.GtkToplevelAccessibleHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (GtkToplevelAccessibleHandle)");
		return GtkToplevelAccessibleHandleExterns.gtk_toplevel_accessible_get_children(accessible);
	}

}

internal class GtkToplevelAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_toplevel_accessible_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToplevelAccessibleHandle>))] MentorLake.Gtk.GtkToplevelAccessibleHandle accessible);

}
