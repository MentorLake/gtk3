namespace MentorLake.Gtk;

public class GtkHeaderBarAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkHeaderBarAccessibleClassExtensions
{

	public static GtkHeaderBarAccessibleClass Dereference(this GtkHeaderBarAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHeaderBarAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkHeaderBarAccessibleClassExterns
{
}

public struct GtkHeaderBarAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
