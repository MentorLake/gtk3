namespace MentorLake.Gdk;

public class GdkDrawingContextHandle : GObjectHandle
{
}

public static class GdkDrawingContextHandleExtensions
{
	public static MentorLake.cairo.cairo_tHandle GetCairoContext(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_get_cairo_context(context);
	}

	public static MentorLake.cairo.cairo_region_tHandle GetClip(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_get_clip(context);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_get_window(context);
	}

	public static bool IsValid(this MentorLake.Gdk.GdkDrawingContextHandle context)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GdkDrawingContextHandle)");
		return GdkDrawingContextHandleExterns.gdk_drawing_context_is_valid(context);
	}

}

internal class GdkDrawingContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_tHandle gdk_drawing_context_get_cairo_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_drawing_context_get_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drawing_context_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_drawing_context_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

}
