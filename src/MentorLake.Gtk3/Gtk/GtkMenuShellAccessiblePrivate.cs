namespace MentorLake.Gtk;


public class GtkMenuShellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuShellAccessiblePrivateExtensions
{

	public static GtkMenuShellAccessiblePrivate Dereference(this GtkMenuShellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuShellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkMenuShellAccessiblePrivateExterns
{
}


public struct GtkMenuShellAccessiblePrivate
{
}
