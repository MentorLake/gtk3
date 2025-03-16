namespace MentorLake.Gtk;

public class GtkEventControllerClassHandle : BaseSafeHandle
{
}


public static class GtkEventControllerClassExtensions
{

	public static GtkEventControllerClass Dereference(this GtkEventControllerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEventControllerClass>(x.DangerousGetHandle());
}
internal class GtkEventControllerClassExterns
{
}

public struct GtkEventControllerClass
{
}
