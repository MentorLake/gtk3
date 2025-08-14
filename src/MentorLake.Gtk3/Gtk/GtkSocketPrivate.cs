namespace MentorLake.Gtk;


public class GtkSocketPrivateHandle : BaseSafeHandle
{
}


public static class GtkSocketPrivateExtensions
{

	public static GtkSocketPrivate Dereference(this GtkSocketPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSocketPrivate>(x.DangerousGetHandle());
}
internal class GtkSocketPrivateExterns
{
}


public struct GtkSocketPrivate
{
}
