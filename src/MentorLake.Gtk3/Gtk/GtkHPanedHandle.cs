namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The HPaned widget is a container widget with two
/// children arranged horizontally. The division between
/// the two panes is adjustable by the user by dragging
/// a handle. See #GtkPaned for details.
/// </para>
/// <para>
/// GtkHPaned has been deprecated, use #GtkPaned instead.
/// </para>
/// </summary>

public class GtkHPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Create a new #GtkHPaned
/// </para>
/// </summary>

/// <return>
/// the new #GtkHPaned
/// </return>

	public static MentorLake.Gtk.GtkHPanedHandle New()
	{
		return GtkHPanedHandleExterns.gtk_hpaned_new();
	}

}

public static class GtkHPanedHandleExtensions
{
}

internal class GtkHPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHPanedHandle>))]
	internal static extern MentorLake.Gtk.GtkHPanedHandle gtk_hpaned_new();

}
