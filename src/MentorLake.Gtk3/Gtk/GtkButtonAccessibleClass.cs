namespace MentorLake.Gtk;


public class GtkButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkButtonAccessibleClassExtensions
{

	public static GtkButtonAccessibleClass Dereference(this GtkButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkButtonAccessibleClassExterns
{
}


public struct GtkButtonAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
