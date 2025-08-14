namespace MentorLake.Gtk;


public class GtkTreeModelSortPrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeModelSortPrivateExtensions
{

	public static GtkTreeModelSortPrivate Dereference(this GtkTreeModelSortPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeModelSortPrivate>(x.DangerousGetHandle());
}
internal class GtkTreeModelSortPrivateExterns
{
}


public struct GtkTreeModelSortPrivate
{
}
