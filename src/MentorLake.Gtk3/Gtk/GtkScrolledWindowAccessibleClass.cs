namespace MentorLake.Gtk;


public class GtkScrolledWindowAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkScrolledWindowAccessibleClassExtensions
{

	public static GtkScrolledWindowAccessibleClass Dereference(this GtkScrolledWindowAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrolledWindowAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkScrolledWindowAccessibleClassExterns
{
}


public struct GtkScrolledWindowAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
