namespace MentorLake.Gtk;


public class GtkHPanedClassHandle : BaseSafeHandle
{
}


public static class GtkHPanedClassExtensions
{

	public static GtkHPanedClass Dereference(this GtkHPanedClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHPanedClass>(x.DangerousGetHandle());
}
internal class GtkHPanedClassExterns
{
}


public struct GtkHPanedClass
{
	
public GtkPanedClass parent_class;
}
