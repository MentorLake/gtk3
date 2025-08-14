namespace MentorLake.Gtk;


public class GtkMenuButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkMenuButtonAccessibleClassExtensions
{

	public static GtkMenuButtonAccessibleClass Dereference(this GtkMenuButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkMenuButtonAccessibleClassExterns
{
}


public struct GtkMenuButtonAccessibleClass
{
	
public GtkToggleButtonAccessibleClass parent_class;
}
