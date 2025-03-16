namespace MentorLake.Gtk;

public class GtkToolButtonClassHandle : BaseSafeHandle
{
}


public static class GtkToolButtonClassExtensions
{

	public static GtkToolButtonClass Dereference(this GtkToolButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolButtonClass>(x.DangerousGetHandle());
}
internal class GtkToolButtonClassExterns
{
}

public struct GtkToolButtonClass
{
	public GtkToolItemClass parent_class;
	public GType button_type;
	public IntPtr clicked;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
