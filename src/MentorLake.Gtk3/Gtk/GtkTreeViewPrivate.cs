namespace MentorLake.Gtk;

public class GtkTreeViewPrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeViewPrivateExtensions
{

	public static GtkTreeViewPrivate Dereference(this GtkTreeViewPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeViewPrivate>(x.DangerousGetHandle());
}
internal class GtkTreeViewPrivateExterns
{
}

public struct GtkTreeViewPrivate
{
}
