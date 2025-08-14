namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCellRendererProgress renders a numeric value as a progress par in a cell.
/// Additionally, it can display a text on top of the progress bar.
/// </para>
/// <para>
/// The #GtkCellRendererProgress cell renderer was added in GTK+ 2.6.
/// </para>
/// </summary>

public class GtkCellRendererProgressHandle : GtkCellRendererHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererProgress.
/// </para>
/// </summary>

/// <return>
/// the new cell renderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererProgressHandle New()
	{
		return GtkCellRendererProgressHandleExterns.gtk_cell_renderer_progress_new();
	}

}

public static class GtkCellRendererProgressHandleExtensions
{
}

internal class GtkCellRendererProgressHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererProgressHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererProgressHandle gtk_cell_renderer_progress_new();

}
