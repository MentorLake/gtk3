namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkVBox is a container that organizes child widgets into a single column.
/// </para>
/// <para>
/// Use the #GtkBox packing interface to determine the arrangement,
/// spacing, height, and alignment of #GtkVBox children.
/// </para>
/// <para>
/// All children are allocated the same width.
/// </para>
/// <para>
/// GtkVBox has been deprecated. You can use #GtkBox with a #GtkOrientable:orientation
/// set to %GTK_ORIENTATION_VERTICAL instead when calling gtk_box_new(),
/// which is a very quick and easy change.
/// </para>
/// <para>
/// If you have derived your own classes from GtkVBox, you can change the
/// inheritance to derive directly from #GtkBox, and set the #GtkOrientable:orientation
/// property to %GTK_ORIENTATION_VERTICAL in your instance init function,
/// with a call like:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   gtk_orientable_set_orientation (GTK_ORIENTABLE (object),
///                                   GTK_ORIENTATION_VERTICAL);
/// ]|
/// </para>
/// <para>
/// If you have a grid-like layout composed of nested boxes, and you don’t
/// need first-child or last-child styling, the recommendation is to switch
/// to #GtkGrid. For more information about migrating to #GtkGrid, see
/// [Migrating from other containers to GtkGrid][gtk-migrating-GtkGrid].
/// </para>
/// </summary>

public class GtkVBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkVBox.
/// </para>
/// </summary>

/// <param name="homogeneous">
/// %TRUE if all children are to be given equal space allotments.
/// </param>
/// <param name="spacing">
/// the number of pixels to place by default between children.
/// </param>
/// <return>
/// a new #GtkVBox.
/// </return>

	public static MentorLake.Gtk.GtkVBoxHandle New(bool homogeneous, int spacing)
	{
		return GtkVBoxHandleExterns.gtk_vbox_new(homogeneous, spacing);
	}

}

public static class GtkVBoxHandleExtensions
{
}

internal class GtkVBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkVBoxHandle gtk_vbox_new(bool homogeneous, int spacing);

}
