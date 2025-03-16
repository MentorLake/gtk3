namespace MentorLake.Gtk;

public class GtkTextBufferClassHandle : BaseSafeHandle
{
}


public static class GtkTextBufferClassExtensions
{

	public static GtkTextBufferClass Dereference(this GtkTextBufferClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextBufferClass>(x.DangerousGetHandle());
}
internal class GtkTextBufferClassExterns
{
}

public struct GtkTextBufferClass
{
	public GObjectClass parent_class;
	public IntPtr insert_text;
	public IntPtr insert_pixbuf;
	public IntPtr insert_child_anchor;
	public IntPtr delete_range;
	public IntPtr changed;
	public IntPtr modified_changed;
	public IntPtr mark_set;
	public IntPtr mark_deleted;
	public IntPtr apply_tag;
	public IntPtr remove_tag;
	public IntPtr begin_user_action;
	public IntPtr end_user_action;
	public IntPtr paste_done;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
