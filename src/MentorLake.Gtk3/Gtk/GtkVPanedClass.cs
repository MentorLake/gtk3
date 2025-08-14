namespace MentorLake.Gtk;


public class GtkVPanedClassHandle : BaseSafeHandle
{
}


public static class GtkVPanedClassExtensions
{

	public static GtkVPanedClass Dereference(this GtkVPanedClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVPanedClass>(x.DangerousGetHandle());
}
internal class GtkVPanedClassExterns
{
}


public struct GtkVPanedClass
{
	
public GtkPanedClass parent_class;
}
