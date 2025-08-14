namespace MentorLake.Gtk;


public class GtkActionPrivateHandle : BaseSafeHandle
{
}


public static class GtkActionPrivateExtensions
{

	public static GtkActionPrivate Dereference(this GtkActionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionPrivate>(x.DangerousGetHandle());
}
internal class GtkActionPrivateExterns
{
}


public struct GtkActionPrivate
{
}
