namespace MentorLake.Gtk;


public class GtkGestureRotateClassHandle : BaseSafeHandle
{
}


public static class GtkGestureRotateClassExtensions
{

	public static GtkGestureRotateClass Dereference(this GtkGestureRotateClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureRotateClass>(x.DangerousGetHandle());
}
internal class GtkGestureRotateClassExterns
{
}


public struct GtkGestureRotateClass
{
}
