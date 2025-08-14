namespace MentorLake.Gtk;


public class GtkApplicationWindowPrivateHandle : BaseSafeHandle
{
}


public static class GtkApplicationWindowPrivateExtensions
{

	public static GtkApplicationWindowPrivate Dereference(this GtkApplicationWindowPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkApplicationWindowPrivate>(x.DangerousGetHandle());
}
internal class GtkApplicationWindowPrivateExterns
{
}


public struct GtkApplicationWindowPrivate
{
}
