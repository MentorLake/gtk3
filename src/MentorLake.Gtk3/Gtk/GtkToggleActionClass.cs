namespace MentorLake.Gtk;

public class GtkToggleActionClassHandle : BaseSafeHandle
{
}


public static class GtkToggleActionClassExtensions
{

	public static GtkToggleActionClass Dereference(this GtkToggleActionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleActionClass>(x.DangerousGetHandle());
}
internal class GtkToggleActionClassExterns
{
}

public struct GtkToggleActionClass
{
	public GtkActionClass parent_class;
	public IntPtr toggled;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
