namespace MentorLake.Gtk;

public class GtkButtonClassHandle : BaseSafeHandle
{
}


public static class GtkButtonClassExtensions
{

	public static GtkButtonClass Dereference(this GtkButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonClass>(x.DangerousGetHandle());
}
internal class GtkButtonClassExterns
{
}

public struct GtkButtonClass
{
	public GtkBinClass parent_class;
	public IntPtr pressed;
	public IntPtr released;
	public IntPtr clicked;
	public IntPtr enter;
	public IntPtr leave;
	public IntPtr activate;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
