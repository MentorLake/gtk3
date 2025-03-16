namespace MentorLake.Gtk;

public class GtkRendererCellAccessibleHandle : GtkCellAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkTableCellHandle
{
	public static MentorLake.Gtk.GtkRendererCellAccessibleHandle New(MentorLake.Gtk.GtkCellRendererHandle renderer)
	{
		return GtkRendererCellAccessibleHandleExterns.gtk_renderer_cell_accessible_new(renderer);
	}

}

public static class GtkRendererCellAccessibleHandleExtensions
{
}

internal class GtkRendererCellAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRendererCellAccessibleHandle gtk_renderer_cell_accessible_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer);

}
