namespace MentorLake.Gtk;


public class GtkScrolledWindowAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkScrolledWindowAccessiblePrivateExtensions
{

	public static GtkScrolledWindowAccessiblePrivate Dereference(this GtkScrolledWindowAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrolledWindowAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkScrolledWindowAccessiblePrivateExterns
{
}


public struct GtkScrolledWindowAccessiblePrivate
{
}
