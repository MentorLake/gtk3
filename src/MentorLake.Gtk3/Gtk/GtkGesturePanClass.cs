namespace MentorLake.Gtk;

public class GtkGesturePanClassHandle : BaseSafeHandle
{
}


public static class GtkGesturePanClassExtensions
{

	public static GtkGesturePanClass Dereference(this GtkGesturePanClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGesturePanClass>(x.DangerousGetHandle());
}
internal class GtkGesturePanClassExterns
{
}

public struct GtkGesturePanClass
{
}
