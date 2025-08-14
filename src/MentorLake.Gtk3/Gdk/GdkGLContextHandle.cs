namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// #GdkGLContext is an object representing the platform-specific
/// OpenGL drawing context.
/// </para>
/// <para>
/// #GdkGLContexts are created for a #GdkWindow using
/// gdk_window_create_gl_context(), and the context will match
/// the #GdkVisual of the window.
/// </para>
/// <para>
/// A #GdkGLContext is not tied to any particular normal framebuffer.
/// For instance, it cannot draw to the #GdkWindow back buffer. The GDK
/// repaint system is in full control of the painting to that. Instead,
/// you can create render buffers or textures and use gdk_cairo_draw_from_gl()
/// in the draw function of your widget to draw them. Then GDK will handle
/// the integration of your rendering with that of other widgets.
/// </para>
/// <para>
/// Support for #GdkGLContext is platform-specific, context creation
/// can fail, returning %NULL context.
/// </para>
/// <para>
/// A #GdkGLContext has to be made "current" in order to start using
/// it, otherwise any OpenGL call will be ignored.
/// </para>
/// <para>
/// ## Creating a new OpenGL context ##
/// </para>
/// <para>
/// In order to create a new #GdkGLContext instance you need a
/// #GdkWindow, which you typically get during the realize call
/// of a widget.
/// </para>
/// <para>
/// A #GdkGLContext is not realized until either gdk_gl_context_make_current(),
/// or until it is realized using gdk_gl_context_realize(). It is possible to
/// specify details of the GL context like the OpenGL version to be used, or
/// whether the GL context should have extra state validation enabled after
/// calling gdk_window_create_gl_context() by calling gdk_gl_context_realize().
/// If the realization fails you have the option to change the settings of the
/// #GdkGLContext and try again.
/// </para>
/// <para>
/// ## Using a GdkGLContext ##
/// </para>
/// <para>
/// You will need to make the #GdkGLContext the current context
/// before issuing OpenGL calls; the system sends OpenGL commands to
/// whichever context is current. It is possible to have multiple
/// contexts, so you always need to ensure that the one which you
/// want to draw with is the current one before issuing commands:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   gdk_gl_context_make_current (context);
/// ]|
/// </para>
/// <para>
/// You can now perform your drawing using OpenGL commands.
/// </para>
/// <para>
/// You can check which #GdkGLContext is the current one by using
/// gdk_gl_context_get_current(); you can also unset any #GdkGLContext
/// that is currently set by calling gdk_gl_context_clear_current().
/// </para>
/// </summary>

public class GdkGLContextHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Clears the current #GdkGLContext.
/// </para>
/// <para>
/// Any OpenGL call after this function returns will be ignored
/// until gdk_gl_context_make_current() is called.
/// </para>
/// </summary>


	public static void ClearCurrent()
	{
		GdkGLContextHandleExterns.gdk_gl_context_clear_current();
	}

/// <summary>
/// <para>
/// Retrieves the current #GdkGLContext.
/// </para>
/// </summary>

/// <return>
/// the current #GdkGLContext, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkGLContextHandle GetCurrent()
	{
		return GdkGLContextHandleExterns.gdk_gl_context_get_current();
	}

}

public static class GdkGLContextHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the value set using gdk_gl_context_set_debug_enabled().
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// %TRUE if debugging is enabled
/// </return>

	public static bool GetDebugEnabled(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_get_debug_enabled(context);
	}

/// <summary>
/// <para>
/// Retrieves the #GdkDisplay the @context is created for
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// a #GdkDisplay or %NULL
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_get_display(context);
	}

/// <summary>
/// <para>
/// Retrieves the value set using gdk_gl_context_set_forward_compatible().
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// %TRUE if the context should be forward compatible
/// </return>

	public static bool GetForwardCompatible(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_get_forward_compatible(context);
	}

/// <summary>
/// <para>
/// Retrieves the major and minor version requested by calling
/// gdk_gl_context_set_required_version().
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <param name="major">
/// return location for the major version to request
/// </param>
/// <param name="minor">
/// return location for the minor version to request
/// </param>

	public static T GetRequiredVersion<T>(this T context, out int major, out int minor) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_get_required_version(context, out major, out minor);
		return context;
	}

/// <summary>
/// <para>
/// Retrieves the #GdkGLContext that this @context share data with.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// a #GdkGLContext or %NULL
/// </return>

	public static MentorLake.Gdk.GdkGLContextHandle GetSharedContext(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_get_shared_context(context);
	}

/// <summary>
/// <para>
/// Checks whether the @context is using an OpenGL or OpenGL ES profile.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// %TRUE if the #GdkGLContext is using an OpenGL ES profile
/// </return>

	public static bool GetUseEs(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_get_use_es(context);
	}

/// <summary>
/// <para>
/// Retrieves the OpenGL version of the @context.
/// </para>
/// <para>
/// The @context must be realized prior to calling this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <param name="major">
/// return location for the major version
/// </param>
/// <param name="minor">
/// return location for the minor version
/// </param>

	public static T GetVersion<T>(this T context, out int major, out int minor) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_get_version(context, out major, out minor);
		return context;
	}

/// <summary>
/// <para>
/// Retrieves the #GdkWindow used by the @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// a #GdkWindow or %NULL
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_get_window(context);
	}

/// <summary>
/// <para>
/// Whether the #GdkGLContext is in legacy mode or not.
/// </para>
/// <para>
/// The #GdkGLContext must be realized before calling this function.
/// </para>
/// <para>
/// When realizing a GL context, GDK will try to use the OpenGL 3.2 core
/// profile; this profile removes all the OpenGL API that was deprecated
/// prior to the 3.2 version of the specification. If the realization is
/// successful, this function will return %FALSE.
/// </para>
/// <para>
/// If the underlying OpenGL implementation does not support core profiles,
/// GDK will fall back to a pre-3.2 compatibility profile, and this function
/// will return %TRUE.
/// </para>
/// <para>
/// You can use the value returned by this function to decide which kind
/// of OpenGL API to use, or whether to do extension discovery, or what
/// kind of shader programs to load.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// %TRUE if the GL context is in legacy mode
/// </return>

	public static bool IsLegacy(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		return GdkGLContextHandleExterns.gdk_gl_context_is_legacy(context);
	}

/// <summary>
/// <para>
/// Makes the @context the current one.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>

	public static T MakeCurrent<T>(this T context) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_make_current(context);
		return context;
	}

/// <summary>
/// <para>
/// Realizes the given #GdkGLContext.
/// </para>
/// <para>
/// It is safe to call this function on a realized #GdkGLContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <return>
/// %TRUE if the context is realized
/// </return>

	public static bool Realize(this MentorLake.Gdk.GdkGLContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		var externCallResult = GdkGLContextHandleExterns.gdk_gl_context_realize(context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets whether the #GdkGLContext should perform extra validations and
/// run time checking. This is useful during development, but has
/// additional overhead.
/// </para>
/// <para>
/// The #GdkGLContext must not be realized or made current prior to
/// calling this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <param name="enabled">
/// whether to enable debugging in the context
/// </param>

	public static T SetDebugEnabled<T>(this T context, bool enabled) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_set_debug_enabled(context, enabled);
		return context;
	}

/// <summary>
/// <para>
/// Sets whether the #GdkGLContext should be forward compatible.
/// </para>
/// <para>
/// Forward compatibile contexts must not support OpenGL functionality that
/// has been marked as deprecated in the requested version; non-forward
/// compatible contexts, on the other hand, must support both deprecated and
/// non deprecated functionality.
/// </para>
/// <para>
/// The #GdkGLContext must not be realized or made current prior to calling
/// this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <param name="compatible">
/// whether the context should be forward compatible
/// </param>

	public static T SetForwardCompatible<T>(this T context, bool compatible) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_set_forward_compatible(context, compatible);
		return context;
	}

/// <summary>
/// <para>
/// Sets the major and minor version of OpenGL to request.
/// </para>
/// <para>
/// Setting @major and @minor to zero will use the default values.
/// </para>
/// <para>
/// The #GdkGLContext must not be realized or made current prior to calling
/// this function.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext
/// </param>
/// <param name="major">
/// the major version to request
/// </param>
/// <param name="minor">
/// the minor version to request
/// </param>

	public static T SetRequiredVersion<T>(this T context, int major, int minor) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_set_required_version(context, major, minor);
		return context;
	}

/// <summary>
/// <para>
/// Requests that GDK create a OpenGL ES context instead of an OpenGL one,
/// if the platform and windowing system allows it.
/// </para>
/// <para>
/// The @context must not have been realized.
/// </para>
/// <para>
/// By default, GDK will attempt to automatically detect whether the
/// underlying GL implementation is OpenGL or OpenGL ES once the @context
/// is realized.
/// </para>
/// <para>
/// You should check the return value of gdk_gl_context_get_use_es() after
/// calling gdk_gl_context_realize() to decide whether to use the OpenGL or
/// OpenGL ES API, extensions, or shaders.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkGLContext:
/// </param>
/// <param name="use_es">
/// whether the context should use OpenGL ES instead of OpenGL,
///   or -1 to allow auto-detection
/// </param>

	public static T SetUseEs<T>(this T context, int use_es) where T : GdkGLContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkGLContextHandle)");
		GdkGLContextHandleExterns.gdk_gl_context_set_use_es(context, use_es);
		return context;
	}

}

internal class GdkGLContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_get_debug_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_gl_context_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_get_forward_compatible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_get_required_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, out int major, out int minor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gdk_gl_context_get_shared_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_gl_context_get_use_es([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_gl_context_get_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, out int major, out int minor);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gdk_gl_context_get_current();

}
