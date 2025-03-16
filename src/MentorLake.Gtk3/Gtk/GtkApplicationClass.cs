namespace MentorLake.Gtk;

public class GtkApplicationClassHandle : BaseSafeHandle
{
}


public static class GtkApplicationClassExtensions
{

	public static GtkApplicationClass Dereference(this GtkApplicationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkApplicationClass>(x.DangerousGetHandle());
}
internal class GtkApplicationClassExterns
{
}

public struct GtkApplicationClass
{
	public GApplicationClass parent_class;
	public IntPtr window_added;
	public IntPtr window_removed;
}
