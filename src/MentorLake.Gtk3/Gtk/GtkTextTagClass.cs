namespace MentorLake.Gtk;

public class GtkTextTagClassHandle : BaseSafeHandle
{
}


public static class GtkTextTagClassExtensions
{

	public static GtkTextTagClass Dereference(this GtkTextTagClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextTagClass>(x.DangerousGetHandle());
}
internal class GtkTextTagClassExterns
{
}

public struct GtkTextTagClass
{
	public GObjectClass parent_class;
	public IntPtr @event;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
