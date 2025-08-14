namespace MentorLake.Gtk;


public class GtkScalePrivateHandle : BaseSafeHandle
{
}


public static class GtkScalePrivateExtensions
{

	public static GtkScalePrivate Dereference(this GtkScalePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScalePrivate>(x.DangerousGetHandle());
}
internal class GtkScalePrivateExterns
{
}


public struct GtkScalePrivate
{
}
