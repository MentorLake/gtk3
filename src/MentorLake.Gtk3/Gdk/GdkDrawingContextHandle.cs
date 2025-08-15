namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// #GdkDrawingContext is an object that represents the current drawing
/// state of a #GdkWindow.
/// </para>
/// <para>
/// It&apos;s possible to use a #GdkDrawingContext to draw on a #GdkWindow
/// via rendering API like Cairo or OpenGL.
/// </para>
/// <para>
/// A #GdkDrawingContext can only be created by calling gdk_window_begin_draw_frame()
/// and will be valid until a call to gdk_window_end_draw_frame().
/// </para>
/// <para>
/// #GdkDrawingContext is available since GDK 3.22
/// </para>
/// </summary>

public class GdkDrawingContextHandle : GObjectHandle
{
}

public static class GdkDrawingContextHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves a Cairo context to be used to draw on the #GdkWindow
/// that created the #GdkDrawingContext.
/// </para>
/// <para>
/// The returned context is guaranteed to be valid as long as the
/// #GdkDrawingContext is valid, that is between a call to
/// gdk_window_begin_draw_frame() and gdk_window_end_draw_frame().
/// </para>
/// </summary>

/// <param name="context">
/// </param>
/// <return>
/// a Cairo context to be used to draw
///   the contents of the #GdkWindow. The context is owned by the
///   #GdkDrawingContext and should not be destroyed
/// </return>

	public static MentorLake.cairo.cairo_tHandle GetCairoContext(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_get_cairo_context(context);
	}

/// <summary>
/// <para>
/// Retrieves a copy of the clip region used when creating the @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDrawingContext
/// </param>
/// <return>
/// a Cairo region
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle GetClip(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_get_clip(context);
	}

/// <summary>
/// <para>
/// Retrieves the window that created the drawing @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDrawingContext
/// </param>
/// <return>
/// a #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_get_window(context);
	}

/// <summary>
/// <para>
/// Checks whether the given #GdkDrawingContext is valid.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDrawingContext
/// </param>
/// <return>
/// %TRUE if the context is valid
/// </return>

	public static bool IsValid(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_is_valid(context);
	}

}

internal class GdkDrawingContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))]
	internal static extern MentorLake.cairo.cairo_tHandle gdk_drawing_context_get_cairo_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_drawing_context_get_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drawing_context_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_drawing_context_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

}
