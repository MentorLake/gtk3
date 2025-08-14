namespace MentorLake.Gtk;


public class GtkRangePrivateHandle : BaseSafeHandle
{
}


public static class GtkRangePrivateExtensions
{

	public static GtkRangePrivate Dereference(this GtkRangePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRangePrivate>(x.DangerousGetHandle());
}
internal class GtkRangePrivateExterns
{
}


public struct GtkRangePrivate
{
}
