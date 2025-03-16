namespace MentorLake.Gtk;

public class GtkGestureSwipeClassHandle : BaseSafeHandle
{
}


public static class GtkGestureSwipeClassExtensions
{

	public static GtkGestureSwipeClass Dereference(this GtkGestureSwipeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureSwipeClass>(x.DangerousGetHandle());
}
internal class GtkGestureSwipeClassExterns
{
}

public struct GtkGestureSwipeClass
{
}
