namespace MentorLake.Gtk;


public class GtkGestureSingleClassHandle : BaseSafeHandle
{
}


public static class GtkGestureSingleClassExtensions
{

	public static GtkGestureSingleClass Dereference(this GtkGestureSingleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureSingleClass>(x.DangerousGetHandle());
}
internal class GtkGestureSingleClassExterns
{
}


public struct GtkGestureSingleClass
{
}
