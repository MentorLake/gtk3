namespace MentorLake.Gtk;

public class GtkHScrollbarClassHandle : BaseSafeHandle
{
}


public static class GtkHScrollbarClassExtensions
{

	public static GtkHScrollbarClass Dereference(this GtkHScrollbarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHScrollbarClass>(x.DangerousGetHandle());
}
internal class GtkHScrollbarClassExterns
{
}

public struct GtkHScrollbarClass
{
	public GtkScrollbarClass parent_class;
}
