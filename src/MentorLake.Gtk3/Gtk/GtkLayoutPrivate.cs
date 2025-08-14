namespace MentorLake.Gtk;


public class GtkLayoutPrivateHandle : BaseSafeHandle
{
}


public static class GtkLayoutPrivateExtensions
{

	public static GtkLayoutPrivate Dereference(this GtkLayoutPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLayoutPrivate>(x.DangerousGetHandle());
}
internal class GtkLayoutPrivateExterns
{
}


public struct GtkLayoutPrivate
{
}
