namespace MentorLake.Gtk;

public class GtkIconThemeClassHandle : BaseSafeHandle
{
}


public static class GtkIconThemeClassExtensions
{

	public static GtkIconThemeClass Dereference(this GtkIconThemeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconThemeClass>(x.DangerousGetHandle());
}
internal class GtkIconThemeClassExterns
{
}

public struct GtkIconThemeClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
