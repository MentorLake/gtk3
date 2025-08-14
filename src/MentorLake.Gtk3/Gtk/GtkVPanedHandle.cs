namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The VPaned widget is a container widget with two
/// children arranged vertically. The division between
/// the two panes is adjustable by the user by dragging
/// a handle. See #GtkPaned for details.
/// </para>
/// <para>
/// GtkVPaned has been deprecated, use #GtkPaned instead.
/// </para>
/// </summary>

public class GtkVPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Create a new #GtkVPaned
/// </para>
/// </summary>

/// <return>
/// the new #GtkVPaned
/// </return>

	public static MentorLake.Gtk.GtkVPanedHandle New()
	{
		return GtkVPanedHandleExterns.gtk_vpaned_new();
	}

}

public static class GtkVPanedHandleExtensions
{
}

internal class GtkVPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVPanedHandle>))]
	internal static extern MentorLake.Gtk.GtkVPanedHandle gtk_vpaned_new();

}
