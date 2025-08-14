namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkCellRendererPixbuf can be used to render an image in a cell. It allows
/// to render either a given #GdkPixbuf (set via the
/// #GtkCellRendererPixbuf:pixbuf property) or a named icon (set via the
/// #GtkCellRendererPixbuf:icon-name property).
/// </para>
/// <para>
/// To support the tree view, #GtkCellRendererPixbuf also supports rendering two
/// alternative pixbufs, when the #GtkCellRenderer:is-expander property is %TRUE.
/// If the #GtkCellRenderer:is-expanded property is %TRUE and the
/// #GtkCellRendererPixbuf:pixbuf-expander-open property is set to a pixbuf, it
/// renders that pixbuf, if the #GtkCellRenderer:is-expanded property is %FALSE
/// and the #GtkCellRendererPixbuf:pixbuf-expander-closed property is set to a
/// pixbuf, it renders that one.
/// </para>
/// </summary>

public class GtkCellRendererPixbufHandle : GtkCellRendererHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererPixbuf. Adjust rendering
/// parameters using object properties. Object properties can be set
/// globally (with g_object_set()). Also, with #GtkTreeViewColumn, you
/// can bind a property to a value in a #GtkTreeModel. For example, you
/// can bind the “pixbuf” property on the cell renderer to a pixbuf value
/// in the model, thus rendering a different image in each row of the
/// #GtkTreeView.
/// </para>
/// </summary>

/// <return>
/// the new cell renderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererPixbufHandle New()
	{
		return GtkCellRendererPixbufHandleExterns.gtk_cell_renderer_pixbuf_new();
	}

}

public static class GtkCellRendererPixbufHandleExtensions
{
}

internal class GtkCellRendererPixbufHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererPixbufHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererPixbufHandle gtk_cell_renderer_pixbuf_new();

}
