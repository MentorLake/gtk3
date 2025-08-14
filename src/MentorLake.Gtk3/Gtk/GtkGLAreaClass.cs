namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The `GtkGLAreaClass` structure contains only private data.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The `GtkGLAreaClass` structure contains only private data.
/// </para>
/// </summary>

public struct GtkGLAreaClass
{
	/// <summary>
/// <para>
/// class closure for the #GtkGLArea::render signal
/// </para>
/// </summary>

public IntPtr render;
	/// <summary>
/// <para>
/// class closeure for the #GtkGLArea::resize signal
/// </para>
/// </summary>

public IntPtr resize;
	/// <summary>
/// <para>
/// class closure for the #GtkGLArea::create-context signal
/// </para>
/// </summary>

public IntPtr create_context;
}
