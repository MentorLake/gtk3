namespace MentorLake.Gtk;

public class GtkColorButtonClassHandle : BaseSafeHandle
{
}


public static class GtkColorButtonClassExtensions
{

	public static GtkColorButtonClass Dereference(this GtkColorButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorButtonClass>(x.DangerousGetHandle());
}
internal class GtkColorButtonClassExterns
{
}

public struct GtkColorButtonClass
{
	public GtkButtonClass parent_class;
	public IntPtr color_set;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
