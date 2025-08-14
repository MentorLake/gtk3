namespace MentorLake.Gtk;


public class GtkSeparatorToolItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkSeparatorToolItemPrivateExtensions
{

	public static GtkSeparatorToolItemPrivate Dereference(this GtkSeparatorToolItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSeparatorToolItemPrivate>(x.DangerousGetHandle());
}
internal class GtkSeparatorToolItemPrivateExterns
{
}


public struct GtkSeparatorToolItemPrivate
{
}
