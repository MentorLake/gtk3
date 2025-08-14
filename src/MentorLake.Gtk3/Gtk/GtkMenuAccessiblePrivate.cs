namespace MentorLake.Gtk;


public class GtkMenuAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuAccessiblePrivateExtensions
{

	public static GtkMenuAccessiblePrivate Dereference(this GtkMenuAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkMenuAccessiblePrivateExterns
{
}


public struct GtkMenuAccessiblePrivate
{
}
