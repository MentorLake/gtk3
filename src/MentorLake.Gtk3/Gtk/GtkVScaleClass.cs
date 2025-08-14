namespace MentorLake.Gtk;


public class GtkVScaleClassHandle : BaseSafeHandle
{
}


public static class GtkVScaleClassExtensions
{

	public static GtkVScaleClass Dereference(this GtkVScaleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVScaleClass>(x.DangerousGetHandle());
}
internal class GtkVScaleClassExterns
{
}


public struct GtkVScaleClass
{
	
public GtkScaleClass parent_class;
}
