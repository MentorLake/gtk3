namespace MentorLake.Gtk;

public class GtkTreeViewAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeViewAccessiblePrivateExtensions
{

	public static GtkTreeViewAccessiblePrivate Dereference(this GtkTreeViewAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeViewAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkTreeViewAccessiblePrivateExterns
{
}

public struct GtkTreeViewAccessiblePrivate
{
}
