namespace MentorLake.Gtk;

public class GtkTreeViewAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkTreeViewAccessibleClassExtensions
{

	public static GtkTreeViewAccessibleClass Dereference(this GtkTreeViewAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeViewAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkTreeViewAccessibleClassExterns
{
}

public struct GtkTreeViewAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
