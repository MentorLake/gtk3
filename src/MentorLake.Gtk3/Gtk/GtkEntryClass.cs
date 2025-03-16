namespace MentorLake.Gtk;

public class GtkEntryClassHandle : BaseSafeHandle
{
}


public static class GtkEntryClassExtensions
{

	public static GtkEntryClass Dereference(this GtkEntryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryClass>(x.DangerousGetHandle());
}
internal class GtkEntryClassExterns
{
}

public struct GtkEntryClass
{
	public GtkWidgetClass parent_class;
	public IntPtr populate_popup;
	public IntPtr activate;
	public IntPtr move_cursor;
	public IntPtr insert_at_cursor;
	public IntPtr delete_from_cursor;
	public IntPtr backspace;
	public IntPtr cut_clipboard;
	public IntPtr copy_clipboard;
	public IntPtr paste_clipboard;
	public IntPtr toggle_overwrite;
	public IntPtr get_text_area_size;
	public IntPtr get_frame_size;
	public IntPtr insert_emoji;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
}
