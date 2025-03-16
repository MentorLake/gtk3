namespace MentorLake.Gtk;

public class GtkApplicationWindowClassHandle : BaseSafeHandle
{
}


public static class GtkApplicationWindowClassExtensions
{

	public static GtkApplicationWindowClass Dereference(this GtkApplicationWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkApplicationWindowClass>(x.DangerousGetHandle());
}
internal class GtkApplicationWindowClassExterns
{
}

public struct GtkApplicationWindowClass
{
	public GtkWindowClass parent_class;
}
