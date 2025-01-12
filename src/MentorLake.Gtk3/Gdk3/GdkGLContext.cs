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

	public static GdkGLContextHandle GdkGlContextGetRequiredVersion(this GdkGLContextHandle context, out int major, out int minor)
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

	public static GdkGLContextHandle GdkGlContextGetVersion(this GdkGLContextHandle context, out int major, out int minor)
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

	public static GdkGLContextHandle GdkGlContextMakeCurrent(this GdkGLContextHandle context)
	{
		GdkGLContextExterns.gdk_gl_context_make_current(context);
		return context;
	}

	public static bool GdkGlContextRealize(this GdkGLContextHandle context, out GErrorHandle error)
	{
		return GdkGLContextExterns.gdk_gl_context_realize(context, out error);
	}

	public static GdkGLContextHandle GdkGlContextSetDebugEnabled(this GdkGLContextHandle context, bool enabled)
	{
		GdkGLContextExterns.gdk_gl_context_set_debug_enabled(context, enabled);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextSetForwardCompatible(this GdkGLContextHandle context, bool compatible)
	{
		GdkGLContextExterns.gdk_gl_context_set_forward_compatible(context, compatible);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextSetRequiredVersion(this GdkGLContextHandle context, int major, int minor)
	{
		GdkGLContextExterns.gdk_gl_context_set_required_version(context, major, minor);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextSetUseEs(this GdkGLContextHandle context, int use_es)
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
