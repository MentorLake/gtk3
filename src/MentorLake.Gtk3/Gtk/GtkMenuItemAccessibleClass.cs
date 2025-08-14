namespace MentorLake.Gtk;


public class GtkMenuItemAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkMenuItemAccessibleClassExtensions
{

	public static GtkMenuItemAccessibleClass Dereference(this GtkMenuItemAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuItemAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkMenuItemAccessibleClassExterns
{
}


public struct GtkMenuItemAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
