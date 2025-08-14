namespace MentorLake.Gtk;


public class GtkGestureZoomClassHandle : BaseSafeHandle
{
}


public static class GtkGestureZoomClassExtensions
{

	public static GtkGestureZoomClass Dereference(this GtkGestureZoomClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureZoomClass>(x.DangerousGetHandle());
}
internal class GtkGestureZoomClassExterns
{
}


public struct GtkGestureZoomClass
{
}
