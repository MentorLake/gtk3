namespace MentorLake.Gtk;


public class GtkNumerableIconPrivateHandle : BaseSafeHandle
{
}


public static class GtkNumerableIconPrivateExtensions
{

	public static GtkNumerableIconPrivate Dereference(this GtkNumerableIconPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNumerableIconPrivate>(x.DangerousGetHandle());
}
internal class GtkNumerableIconPrivateExterns
{
}


public struct GtkNumerableIconPrivate
{
}
