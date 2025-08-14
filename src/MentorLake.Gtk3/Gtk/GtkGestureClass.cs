namespace MentorLake.Gtk;


public class GtkGestureClassHandle : BaseSafeHandle
{
}


public static class GtkGestureClassExtensions
{

	public static GtkGestureClass Dereference(this GtkGestureClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureClass>(x.DangerousGetHandle());
}
internal class GtkGestureClassExterns
{
}


public struct GtkGestureClass
{
}
