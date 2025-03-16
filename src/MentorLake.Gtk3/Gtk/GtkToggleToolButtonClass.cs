namespace MentorLake.Gtk;

public class GtkToggleToolButtonClassHandle : BaseSafeHandle
{
}


public static class GtkToggleToolButtonClassExtensions
{

	public static GtkToggleToolButtonClass Dereference(this GtkToggleToolButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleToolButtonClass>(x.DangerousGetHandle());
}
internal class GtkToggleToolButtonClassExterns
{
}

public struct GtkToggleToolButtonClass
{
	public GtkToolButtonClass parent_class;
	public IntPtr toggled;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
