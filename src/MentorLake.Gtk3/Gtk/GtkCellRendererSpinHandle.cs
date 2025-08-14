namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCellRendererSpin renders text in a cell like #GtkCellRendererText from
/// which it is derived. But while #GtkCellRendererText offers a simple entry to
/// edit the text, #GtkCellRendererSpin offers a #GtkSpinButton widget. Of course,
/// that means that the text has to be parseable as a floating point number.
/// </para>
/// <para>
/// The range of the spinbutton is taken from the adjustment property of the
/// cell renderer, which can be set explicitly or mapped to a column in the
/// tree model, like all properties of cell renders. #GtkCellRendererSpin
/// also has properties for the #GtkCellRendererSpin:climb-rate and the number
/// of #GtkCellRendererSpin:digits to display. Other #GtkSpinButton properties
/// can be set in a handler for the #GtkCellRenderer::editing-started signal.
/// </para>
/// <para>
/// The #GtkCellRendererSpin cell renderer was added in GTK+ 2.10.
/// </para>
/// </summary>

public class GtkCellRendererSpinHandle : GtkCellRendererTextHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererSpin.
/// </para>
/// </summary>

/// <return>
/// a new #GtkCellRendererSpin
/// </return>

	public static MentorLake.Gtk.GtkCellRendererSpinHandle New()
	{
		return GtkCellRendererSpinHandleExterns.gtk_cell_renderer_spin_new();
	}

}

public static class GtkCellRendererSpinHandleExtensions
{
}

internal class GtkCellRendererSpinHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererSpinHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererSpinHandle gtk_cell_renderer_spin_new();

}
