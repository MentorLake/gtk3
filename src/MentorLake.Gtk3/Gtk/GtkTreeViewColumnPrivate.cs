namespace MentorLake.Gtk;

public class GtkTreeViewColumnPrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeViewColumnPrivateExtensions
{

	public static GtkTreeViewColumnPrivate Dereference(this GtkTreeViewColumnPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeViewColumnPrivate>(x.DangerousGetHandle());
}
internal class GtkTreeViewColumnPrivateExterns
{
}

public struct GtkTreeViewColumnPrivate
{
}
