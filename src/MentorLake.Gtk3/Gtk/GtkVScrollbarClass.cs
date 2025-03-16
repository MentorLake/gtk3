namespace MentorLake.Gtk;

public class GtkVScrollbarClassHandle : BaseSafeHandle
{
}


public static class GtkVScrollbarClassExtensions
{

	public static GtkVScrollbarClass Dereference(this GtkVScrollbarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVScrollbarClass>(x.DangerousGetHandle());
}
internal class GtkVScrollbarClassExterns
{
}

public struct GtkVScrollbarClass
{
	public GtkScrollbarClass parent_class;
}
