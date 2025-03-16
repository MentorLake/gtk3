namespace MentorLake.Gtk;

public class GtkGestureStylusClassHandle : BaseSafeHandle
{
}


public static class GtkGestureStylusClassExtensions
{

	public static GtkGestureStylusClass Dereference(this GtkGestureStylusClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureStylusClass>(x.DangerousGetHandle());
}
internal class GtkGestureStylusClassExterns
{
}

public struct GtkGestureStylusClass
{
}
