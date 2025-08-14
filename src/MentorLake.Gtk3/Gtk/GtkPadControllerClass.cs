namespace MentorLake.Gtk;


public class GtkPadControllerClassHandle : BaseSafeHandle
{
}


public static class GtkPadControllerClassExtensions
{

	public static GtkPadControllerClass Dereference(this GtkPadControllerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPadControllerClass>(x.DangerousGetHandle());
}
internal class GtkPadControllerClassExterns
{
}


public struct GtkPadControllerClass
{
}
