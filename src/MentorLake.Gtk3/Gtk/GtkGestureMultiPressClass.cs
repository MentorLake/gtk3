namespace MentorLake.Gtk;

public class GtkGestureMultiPressClassHandle : BaseSafeHandle
{
}


public static class GtkGestureMultiPressClassExtensions
{

	public static GtkGestureMultiPressClass Dereference(this GtkGestureMultiPressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureMultiPressClass>(x.DangerousGetHandle());
}
internal class GtkGestureMultiPressClassExterns
{
}

public struct GtkGestureMultiPressClass
{
}
