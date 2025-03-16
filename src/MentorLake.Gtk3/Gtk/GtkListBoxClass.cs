namespace MentorLake.Gtk;

public class GtkListBoxClassHandle : BaseSafeHandle
{
}


public static class GtkListBoxClassExtensions
{

	public static GtkListBoxClass Dereference(this GtkListBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListBoxClass>(x.DangerousGetHandle());
}
internal class GtkListBoxClassExterns
{
}

public struct GtkListBoxClass
{
	public GtkContainerClass parent_class;
	public IntPtr row_selected;
	public IntPtr row_activated;
	public IntPtr activate_cursor_row;
	public IntPtr toggle_cursor_row;
	public IntPtr move_cursor;
	public IntPtr selected_rows_changed;
	public IntPtr select_all;
	public IntPtr unselect_all;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
}
