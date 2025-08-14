namespace MentorLake.Gtk;


public class GtkPopoverAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkPopoverAccessibleClassExtensions
{

	public static GtkPopoverAccessibleClass Dereference(this GtkPopoverAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPopoverAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkPopoverAccessibleClassExterns
{
}


public struct GtkPopoverAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
