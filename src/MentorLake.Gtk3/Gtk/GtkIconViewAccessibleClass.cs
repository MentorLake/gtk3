namespace MentorLake.Gtk;


public class GtkIconViewAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkIconViewAccessibleClassExtensions
{

	public static GtkIconViewAccessibleClass Dereference(this GtkIconViewAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconViewAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkIconViewAccessibleClassExterns
{
}


public struct GtkIconViewAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
