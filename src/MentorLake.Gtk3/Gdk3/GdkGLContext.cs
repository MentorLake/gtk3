namespace MentorLake.Gtk3.Gdk3;

public class GdkGLContextHandle : GObjectHandle
{
	public static void GdkGlContextClearCurrent()
	{
		GdkGLContextExterns.gdk_gl_context_clear_current();
	}

	public static GdkGLContextHandle GdkGlContextGetCurrent()
	{
		return GdkGLContextExterns.gdk_gl_context_get_current();
	}

}

public static class GdkGLContextHandleExtensions
{
	public static bool GdkGlContextGetDebugEnabled(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_debug_enabled(context);
	}

	public static GdkDisplayHandle GdkGlContextGetDisplay(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_display(context);
	}

	public static bool GdkGlContextGetForwardCompatible(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_forward_compatible(context);
	}

	public static T GdkGlContextGetRequiredVersion<T>(this T context, out int major, out int minor) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_get_required_version(context, out major, out minor);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextGetSharedContext(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_shared_context(context);
	}

	public static bool GdkGlContextGetUseEs(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_use_es(context);
	}

	public static T GdkGlContextGetVersion<T>(this T context, out int major, out int minor) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_get_version(context, out major, out minor);
		return context;
	}

	public static GdkWindowHandle GdkGlContextGetWindow(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_window(context);
	}

	public static bool GdkGlContextIsLegacy(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_is_legacy(context);
	}

	public static T GdkGlContextMakeCurrent<T>(this T context) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_make_current(context);
		return context;
	}

	public static bool GdkGlContextRealize(this GdkGLContextHandle context, out GErrorHandle error)
	{
		return GdkGLContextExterns.gdk_gl_context_realize(context, out error);
	}

	public static T GdkGlContextSetDebugEnabled<T>(this T context, bool enabled) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_set_debug_enabled(context, enabled);
		return context;
	}

	public static T GdkGlContextSetForwardCompatible<T>(this T context, bool compatible) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_set_forward_compatible(context, compatible);
		return context;
	}

	public static T GdkGlContextSetRequiredVersion<T>(this T context, int major, int minor) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_set_required_version(context, major, minor);
		return context;
	}

	public static T GdkGlContextSetUseEs<T>(this T context, int use_es) where T : GdkGLContextHandle
	{
		GdkGLContextExterns.gdk_gl_context_set_use_es(context, use_es);
		return context;
	}

}

internal class GdkGLContextExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_gl_context_get_debug_enabled(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_gl_context_get_display(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_gl_context_get_forward_compatible(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_get_required_version(GdkGLContextHandle context, out int major, out int minor);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkGLContextHandle gdk_gl_context_get_shared_context(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_gl_context_get_use_es(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_get_version(GdkGLContextHandle context, out int major, out int minor);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_gl_context_get_window(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_gl_context_is_legacy(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_make_current(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_gl_context_realize(GdkGLContextHandle context, out GErrorHandle error);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_set_debug_enabled(GdkGLContextHandle context, bool enabled);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_set_forward_compatible(GdkGLContextHandle context, bool compatible);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_set_required_version(GdkGLContextHandle context, int major, int minor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_set_use_es(GdkGLContextHandle context, int use_es);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_gl_context_clear_current();

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkGLContextHandle gdk_gl_context_get_current();

}
