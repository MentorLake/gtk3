namespace MentorLake.Gtk;

public class GtkRcContextHandle : BaseSafeHandle
{
}


public static class GtkRcContextExtensions
{

	public static GtkRcContext Dereference(this GtkRcContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRcContext>(x.DangerousGetHandle());
}
internal class GtkRcContextExterns
{
}

public struct GtkRcContext
{
}
