namespace MentorLake.Gtk;

public class GtkApplicationPrivateHandle : BaseSafeHandle
{
}


public static class GtkApplicationPrivateExtensions
{

	public static GtkApplicationPrivate Dereference(this GtkApplicationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkApplicationPrivate>(x.DangerousGetHandle());
}
internal class GtkApplicationPrivateExterns
{
}

public struct GtkApplicationPrivate
{
}
