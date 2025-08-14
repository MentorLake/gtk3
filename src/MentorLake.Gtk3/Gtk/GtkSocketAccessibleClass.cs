namespace MentorLake.Gtk;


public class GtkSocketAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkSocketAccessibleClassExtensions
{

	public static GtkSocketAccessibleClass Dereference(this GtkSocketAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSocketAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkSocketAccessibleClassExterns
{
}


public struct GtkSocketAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
