namespace MentorLake.Gtk;

public class GtkTextViewClassHandle : BaseSafeHandle
{
}


public static class GtkTextViewClassExtensions
{

	public static GtkTextViewClass Dereference(this GtkTextViewClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextViewClass>(x.DangerousGetHandle());
}
internal class GtkTextViewClassExterns
{
}

public struct GtkTextViewClass
{
	public GtkContainerClass parent_class;
	public IntPtr populate_popup;
	public IntPtr move_cursor;
	public IntPtr set_anchor;
	public IntPtr insert_at_cursor;
	public IntPtr delete_from_cursor;
	public IntPtr backspace;
	public IntPtr cut_clipboard;
	public IntPtr copy_clipboard;
	public IntPtr paste_clipboard;
	public IntPtr toggle_overwrite;
	public IntPtr create_buffer;
	public IntPtr draw_layer;
	public IntPtr extend_selection;
	public IntPtr insert_emoji;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
