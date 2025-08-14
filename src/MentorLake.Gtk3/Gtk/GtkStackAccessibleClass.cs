namespace MentorLake.Gtk;


public class GtkStackAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkStackAccessibleClassExtensions
{

	public static GtkStackAccessibleClass Dereference(this GtkStackAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStackAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkStackAccessibleClassExterns
{
}


public struct GtkStackAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
