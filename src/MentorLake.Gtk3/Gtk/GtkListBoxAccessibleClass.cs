namespace MentorLake.Gtk;


public class GtkListBoxAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkListBoxAccessibleClassExtensions
{

	public static GtkListBoxAccessibleClass Dereference(this GtkListBoxAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListBoxAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkListBoxAccessibleClassExterns
{
}


public struct GtkListBoxAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
