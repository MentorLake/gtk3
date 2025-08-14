namespace MentorLake.Gtk;


public class GtkEventControllerKeyClassHandle : BaseSafeHandle
{
}


public static class GtkEventControllerKeyClassExtensions
{

	public static GtkEventControllerKeyClass Dereference(this GtkEventControllerKeyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEventControllerKeyClass>(x.DangerousGetHandle());
}
internal class GtkEventControllerKeyClassExterns
{
}


public struct GtkEventControllerKeyClass
{
}
