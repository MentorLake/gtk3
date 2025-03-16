namespace MentorLake.Gtk;

public class GtkEntryBufferClassHandle : BaseSafeHandle
{
}


public static class GtkEntryBufferClassExtensions
{

	public static GtkEntryBufferClass Dereference(this GtkEntryBufferClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryBufferClass>(x.DangerousGetHandle());
}
internal class GtkEntryBufferClassExterns
{
}

public struct GtkEntryBufferClass
{
	public GObjectClass parent_class;
	public IntPtr inserted_text;
	public IntPtr deleted_text;
	public IntPtr get_text;
	public IntPtr get_length;
	public IntPtr insert_text;
	public IntPtr delete_text;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
