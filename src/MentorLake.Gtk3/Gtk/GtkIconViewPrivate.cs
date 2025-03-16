namespace MentorLake.Gtk;

public class GtkIconViewPrivateHandle : BaseSafeHandle
{
}


public static class GtkIconViewPrivateExtensions
{

	public static GtkIconViewPrivate Dereference(this GtkIconViewPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconViewPrivate>(x.DangerousGetHandle());
}
internal class GtkIconViewPrivateExterns
{
}

public struct GtkIconViewPrivate
{
}
