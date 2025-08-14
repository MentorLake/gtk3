namespace MentorLake.Gtk;


public class GtkEventControllerMotionClassHandle : BaseSafeHandle
{
}


public static class GtkEventControllerMotionClassExtensions
{

	public static GtkEventControllerMotionClass Dereference(this GtkEventControllerMotionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEventControllerMotionClass>(x.DangerousGetHandle());
}
internal class GtkEventControllerMotionClassExterns
{
}


public struct GtkEventControllerMotionClass
{
}
