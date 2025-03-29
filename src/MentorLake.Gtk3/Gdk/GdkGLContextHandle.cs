namespace MentorLake.Gdk;

public class GdkGLContextHandle : GObjectHandle
{
	public static void ClearCurrent()
	{
		GdkGLContextHandleExterns.gdk_gl_context_clear_current();
	}

	public static MentorLake.Gdk.GdkGLContextHandle GetCurrent()
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_current();
	}

}

public static class GdkGLContextHandleExtensions
{
	public static bool GetDebugEnabled(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_debug_enabled(context);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_display(context);
	}

	public static bool GetForwardCompatible(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_forward_compatible(context);
	}

	public static T GetRequiredVersion<T>(this T context, out int major, out int minor) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_get_required_version(context, out major, out minor);
		return context;
	}

	public static MentorLake.Gdk.GdkGLContextHandle GetSharedContext(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_shared_context(context);
	}

	public static bool GetUseEs(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_use_es(context);
	}

	public static T GetVersion<T>(this T context, out int major, out int minor) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_get_version(context, out major, out minor);
		return context;
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_window(context);
	}

	public static bool IsLegacy(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		return GdkGLContextHandleExterns.gdk_gl_context_is_legacy(context);
	}

	public static T MakeCurrent<T>(this T context) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_make_current(context);
		return context;
	}

	public static bool Realize(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		var externCallResult = GdkGLContextHandleExterns.gdk_gl_context_realize(context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetDebugEnabled<T>(this T context, bool enabled) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_set_debug_enabled(context, enabled);
		return context;
	}

	public static T SetForwardCompatible<T>(this T context, bool compatible) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_set_forward_compatible(context, compatible);
		return context;
	}

	public static T SetRequiredVersion<T>(this T context, int major, int minor) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_set_required_version(context, major, minor);
		return context;
	}

	public static T SetUseEs<T>(this T context, int use_es) where T : GdkGLContextHandle
	{
		GdkGLContextHandleExterns.gdk_gl_context_set_use_es(context, use_es);
		return context;
	}

}

internal class GdkGLContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_get_debug_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_gl_context_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_get_forward_compatible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_get_required_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, out int major, out int minor);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gdk_gl_context_get_shared_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_get_use_es([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_get_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, out int major, out int minor);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_gl_context_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_is_legacy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_make_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_set_debug_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, bool enabled);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_set_forward_compatible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, bool compatible);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_set_required_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, int major, int minor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_set_use_es([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, int use_es);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_clear_current();

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gdk_gl_context_get_current();

}
