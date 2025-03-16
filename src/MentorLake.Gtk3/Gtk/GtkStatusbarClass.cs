namespace MentorLake.Gtk;

public class GtkStatusbarClassHandle : BaseSafeHandle
{
}


public static class GtkStatusbarClassExtensions
{

	public static GtkStatusbarClass Dereference(this GtkStatusbarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStatusbarClass>(x.DangerousGetHandle());
}
internal class GtkStatusbarClassExterns
{
}

public struct GtkStatusbarClass
{
	public GtkBoxClass parent_class;
	public IntPtr reserved;
	public IntPtr text_pushed;
	public IntPtr text_popped;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
