namespace MentorLake.Gtk;

public class GtkInfoBarClassHandle : BaseSafeHandle
{
}


public static class GtkInfoBarClassExtensions
{

	public static GtkInfoBarClass Dereference(this GtkInfoBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkInfoBarClass>(x.DangerousGetHandle());
}
internal class GtkInfoBarClassExterns
{
}

public struct GtkInfoBarClass
{
	public GtkBoxClass parent_class;
	public IntPtr response;
	public IntPtr close;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
