namespace MentorLake.Gtk;


public class GtkNumerableIconClassHandle : BaseSafeHandle
{
}


public static class GtkNumerableIconClassExtensions
{

	public static GtkNumerableIconClass Dereference(this GtkNumerableIconClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNumerableIconClass>(x.DangerousGetHandle());
}
internal class GtkNumerableIconClassExterns
{
}


public struct GtkNumerableIconClass
{
	
public GEmblemedIconClass parent_class;
	
public IntPtr padding;
}
