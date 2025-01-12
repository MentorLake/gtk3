namespace MentorLake.Gtk3.Gtk3;

public class GtkToplevelAccessibleHandle : AtkObjectHandle
{
}

public static class GtkToplevelAccessibleHandleExtensions
{
	public static GListHandle GetChildren(this GtkToplevelAccessibleHandle accessible)
	{
		return GtkToplevelAccessibleExterns.gtk_toplevel_accessible_get_children(accessible);
	}

}

internal class GtkToplevelAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_toplevel_accessible_get_children(GtkToplevelAccessibleHandle accessible);

}
