namespace MentorLake.Gtk;


public class GtkListBoxRowAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkListBoxRowAccessibleClassExtensions
{

	public static GtkListBoxRowAccessibleClass Dereference(this GtkListBoxRowAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListBoxRowAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkListBoxRowAccessibleClassExterns
{
}


public struct GtkListBoxRowAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
