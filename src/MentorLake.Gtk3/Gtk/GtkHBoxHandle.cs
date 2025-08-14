namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkHBox is a container that organizes child widgets into a single row.
/// </para>
/// <para>
/// Use the #GtkBox packing interface to determine the arrangement,
/// spacing, width, and alignment of #GtkHBox children.
/// </para>
/// <para>
/// All children are allocated the same height.
/// </para>
/// <para>
/// GtkHBox has been deprecated. You can use #GtkBox instead, which is a
/// very quick and easy change. If you have derived your own classes from
/// GtkHBox, you can simply change the inheritance to derive directly
/// from #GtkBox. No further changes are needed, since the default
/// value of the #GtkOrientable:orientation property is
/// %GTK_ORIENTATION_HORIZONTAL.
/// </para>
/// <para>
/// If you have a grid-like layout composed of nested boxes, and you don’t
/// need first-child or last-child styling, the recommendation is to switch
/// to #GtkGrid. For more information about migrating to #GtkGrid, see
/// [Migrating from other containers to GtkGrid][gtk-migrating-GtkGrid].
/// </para>
/// </summary>

public class GtkHBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkHBox.
/// </para>
/// </summary>

/// <param name="homogeneous">
/// %TRUE if all children are to be given equal space allotments.
/// </param>
/// <param name="spacing">
/// the number of pixels to place by default between children.
/// </param>
/// <return>
/// a new #GtkHBox.
/// </return>

	public static MentorLake.Gtk.GtkHBoxHandle New(bool homogeneous, int spacing)
	{
		return GtkHBoxHandleExterns.gtk_hbox_new(homogeneous, spacing);
	}

}

public static class GtkHBoxHandleExtensions
{
}

internal class GtkHBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkHBoxHandle gtk_hbox_new(bool homogeneous, int spacing);

}
