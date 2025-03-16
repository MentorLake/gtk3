namespace MentorLake.Gtk;

public class GtkScrolledWindowPrivateHandle : BaseSafeHandle
{
}


public static class GtkScrolledWindowPrivateExtensions
{

	public static GtkScrolledWindowPrivate Dereference(this GtkScrolledWindowPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrolledWindowPrivate>(x.DangerousGetHandle());
}
internal class GtkScrolledWindowPrivateExterns
{
}

public struct GtkScrolledWindowPrivate
{
}
