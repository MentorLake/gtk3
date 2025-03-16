namespace MentorLake.Gtk;

public class GtkTreeSelectionPrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeSelectionPrivateExtensions
{

	public static GtkTreeSelectionPrivate Dereference(this GtkTreeSelectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeSelectionPrivate>(x.DangerousGetHandle());
}
internal class GtkTreeSelectionPrivateExterns
{
}

public struct GtkTreeSelectionPrivate
{
}
