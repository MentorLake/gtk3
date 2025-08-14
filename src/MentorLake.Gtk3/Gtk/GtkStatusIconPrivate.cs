namespace MentorLake.Gtk;


public class GtkStatusIconPrivateHandle : BaseSafeHandle
{
}


public static class GtkStatusIconPrivateExtensions
{

	public static GtkStatusIconPrivate Dereference(this GtkStatusIconPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStatusIconPrivate>(x.DangerousGetHandle());
}
internal class GtkStatusIconPrivateExterns
{
}


public struct GtkStatusIconPrivate
{
}
