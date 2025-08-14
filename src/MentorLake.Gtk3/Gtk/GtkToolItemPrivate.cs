namespace MentorLake.Gtk;


public class GtkToolItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkToolItemPrivateExtensions
{

	public static GtkToolItemPrivate Dereference(this GtkToolItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolItemPrivate>(x.DangerousGetHandle());
}
internal class GtkToolItemPrivateExterns
{
}


public struct GtkToolItemPrivate
{
}
