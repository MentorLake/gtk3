namespace MentorLake.Gtk;


public class GtkToolItemGroupPrivateHandle : BaseSafeHandle
{
}


public static class GtkToolItemGroupPrivateExtensions
{

	public static GtkToolItemGroupPrivate Dereference(this GtkToolItemGroupPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolItemGroupPrivate>(x.DangerousGetHandle());
}
internal class GtkToolItemGroupPrivateExterns
{
}


public struct GtkToolItemGroupPrivate
{
}
