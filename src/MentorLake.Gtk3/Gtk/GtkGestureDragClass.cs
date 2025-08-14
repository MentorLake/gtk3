namespace MentorLake.Gtk;


public class GtkGestureDragClassHandle : BaseSafeHandle
{
}


public static class GtkGestureDragClassExtensions
{

	public static GtkGestureDragClass Dereference(this GtkGestureDragClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureDragClass>(x.DangerousGetHandle());
}
internal class GtkGestureDragClassExterns
{
}


public struct GtkGestureDragClass
{
}
