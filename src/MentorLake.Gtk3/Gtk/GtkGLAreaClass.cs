namespace MentorLake.Gtk;

public class GtkGLAreaClassHandle : BaseSafeHandle
{
}


public static class GtkGLAreaClassExtensions
{

	public static GtkGLAreaClass Dereference(this GtkGLAreaClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGLAreaClass>(x.DangerousGetHandle());
}
internal class GtkGLAreaClassExterns
{
}

public struct GtkGLAreaClass
{
	public IntPtr render;
	public IntPtr resize;
	public IntPtr create_context;
}
