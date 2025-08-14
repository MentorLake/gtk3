namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkCellRendererSpinner renders a spinning animation in a cell, very
/// similar to #GtkSpinner. It can often be used as an alternative
/// to a #GtkCellRendererProgress for displaying indefinite activity,
/// instead of actual progress.
/// </para>
/// <para>
/// To start the animation in a cell, set the #GtkCellRendererSpinner:active
/// property to %TRUE and increment the #GtkCellRendererSpinner:pulse property
/// at regular intervals. The usual way to set the cell renderer properties
/// for each cell is to bind them to columns in your tree model using e.g.
/// gtk_tree_view_column_add_attribute().
/// </para>
/// </summary>

public class GtkCellRendererSpinnerHandle : GtkCellRendererHandle
{
/// <summary>
/// <para>
/// Returns a new cell renderer which will show a spinner to indicate
/// activity.
/// </para>
/// </summary>

/// <return>
/// a new #GtkCellRenderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererSpinnerHandle New()
	{
		return GtkCellRendererSpinnerHandleExterns.gtk_cell_renderer_spinner_new();
	}

}

public static class GtkCellRendererSpinnerHandleExtensions
{
}

internal class GtkCellRendererSpinnerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererSpinnerHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererSpinnerHandle gtk_cell_renderer_spinner_new();

}
