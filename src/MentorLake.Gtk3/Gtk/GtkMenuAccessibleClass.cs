namespace MentorLake.Gtk;


public class GtkMenuAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkMenuAccessibleClassExtensions
{

	public static GtkMenuAccessibleClass Dereference(this GtkMenuAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkMenuAccessibleClassExterns
{
}


public struct GtkMenuAccessibleClass
{
	
public GtkMenuShellAccessibleClass parent_class;
}
