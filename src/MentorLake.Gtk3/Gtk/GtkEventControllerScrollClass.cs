namespace MentorLake.Gtk;


public class GtkEventControllerScrollClassHandle : BaseSafeHandle
{
}


public static class GtkEventControllerScrollClassExtensions
{

	public static GtkEventControllerScrollClass Dereference(this GtkEventControllerScrollClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEventControllerScrollClass>(x.DangerousGetHandle());
}
internal class GtkEventControllerScrollClassExterns
{
}


public struct GtkEventControllerScrollClass
{
}
