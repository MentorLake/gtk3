namespace MentorLake.Gtk;

public class GtkFixedChildHandle : BaseSafeHandle
{
}


public static class GtkFixedChildExtensions
{

	public static GtkFixedChild Dereference(this GtkFixedChildHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFixedChild>(x.DangerousGetHandle());
}
internal class GtkFixedChildExterns
{
}

public struct GtkFixedChild
{
	public IntPtr widget;
	public int x;
	public int y;
}
