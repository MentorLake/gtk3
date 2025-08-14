namespace MentorLake.Gtk;


public class GtkHScaleClassHandle : BaseSafeHandle
{
}


public static class GtkHScaleClassExtensions
{

	public static GtkHScaleClass Dereference(this GtkHScaleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHScaleClass>(x.DangerousGetHandle());
}
internal class GtkHScaleClassExterns
{
}


public struct GtkHScaleClass
{
	
public GtkScaleClass parent_class;
}
