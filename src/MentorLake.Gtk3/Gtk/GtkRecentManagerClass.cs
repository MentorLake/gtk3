namespace MentorLake.Gtk;

public class GtkRecentManagerClassHandle : BaseSafeHandle
{
}


public static class GtkRecentManagerClassExtensions
{

	public static GtkRecentManagerClass Dereference(this GtkRecentManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentManagerClass>(x.DangerousGetHandle());
}
internal class GtkRecentManagerClassExterns
{
}

public struct GtkRecentManagerClass
{
	public IntPtr changed;
	public IntPtr _gtk_recent1;
	public IntPtr _gtk_recent2;
	public IntPtr _gtk_recent3;
	public IntPtr _gtk_recent4;
}
