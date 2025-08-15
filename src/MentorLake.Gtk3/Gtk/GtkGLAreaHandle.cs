namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGLArea is a widget that allows drawing with OpenGL.
/// </para>
/// <para>
/// #GtkGLArea sets up its own #GdkGLContext for the window it creates, and
/// creates a custom GL framebuffer that the widget will do GL rendering onto.
/// It also ensures that this framebuffer is the default GL rendering target
/// when rendering.
/// </para>
/// <para>
/// In order to draw, you have to connect to the #GtkGLArea::render signal,
/// or subclass #GtkGLArea and override the @GtkGLAreaClass.render() virtual
/// function.
/// </para>
/// <para>
/// The #GtkGLArea widget ensures that the #GdkGLContext is associated with
/// the widget&apos;s drawing area, and it is kept updated when the size and
/// position of the drawing area changes.
/// </para>
/// <para>
/// ## Drawing with GtkGLArea ##
/// </para>
/// <para>
/// The simplest way to draw using OpenGL commands in a #GtkGLArea is to
/// create a widget instance and connect to the #GtkGLArea::render signal:
/// </para>
/// <code>
///   // create a GtkGLArea instance
///   // create a GtkGLArea instance
///   GtkWidget *gl_area = gtk_gl_area_new ();
/// 
///   // connect to the &quot;render&quot; signal
///   g_signal_connect (gl_area, &quot;render&quot;, G_CALLBACK (render), NULL);
/// </code>
/// <para>
/// The `render()` function will be called when the #GtkGLArea is ready
/// for you to draw its content:
/// </para>
/// <code>
///   static gboolean
///   static gboolean
///   render (GtkGLArea *area, GdkGLContext *context)
///   {
///     // inside this function it&apos;s safe to use GL; the given
///     // #GdkGLContext has been made current to the drawable
///     // surface used by the #GtkGLArea and the viewport has
///     // already been set to be the size of the allocation
/// 
///     // we can start by clearing the buffer
///     glClearColor (0, 0, 0, 0);
///     glClear (GL_COLOR_BUFFER_BIT);
/// 
///     // draw your object
///     draw_an_object ();
/// 
///     // we completed our drawing; the draw commands will be
///     // flushed at the end of the signal emission chain, and
///     // the buffers will be drawn on the window
///     return TRUE;
///   }
/// </code>
/// <para>
/// If you need to initialize OpenGL state, e.g. buffer objects or
/// shaders, you should use the #GtkWidget::realize signal; you
/// can use the #GtkWidget::unrealize signal to clean up. Since the
/// #GdkGLContext creation and initialization may fail, you will
/// need to check for errors, using gtk_gl_area_get_error(). An example
/// of how to safely initialize the GL state is:
/// </para>
/// <code>
///   static void
///   static void
///   on_realize (GtkGLarea *area)
///   {
///     // We need to make the context current if we want to
///     // call GL API
///     gtk_gl_area_make_current (area);
/// 
///     // If there were errors during the initialization or
///     // when trying to make the context current, this
///     // function will return a #GError for you to catch
///     if (gtk_gl_area_get_error (area) != NULL)
///       return;
/// 
///     // You can also use gtk_gl_area_set_error() in order
///     // to show eventual initialization errors on the
///     // GtkGLArea widget itself
///     GError *internal_error = NULL;
///     init_buffer_objects (&amp;error);
///     if (error != NULL)
///       {
///         gtk_gl_area_set_error (area, error);
///         g_error_free (error);
///         return;
///       }
/// 
///     init_shaders (&amp;error);
///     if (error != NULL)
///       {
///         gtk_gl_area_set_error (area, error);
///         g_error_free (error);
///         return;
///       }
///   }
/// </code>
/// <para>
/// If you need to change the options for creating the #GdkGLContext
/// you should use the #GtkGLArea::create-context signal.
/// </para>
/// </summary>

public class GtkGLAreaHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkGLArea widget.
/// </para>
/// </summary>

/// <return>
/// a new #GtkGLArea
/// </return>

	public static MentorLake.Gtk.GtkGLAreaHandle New()
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_new();
	}

}
public static class GtkGLAreaHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::create-context signal is emitted when the widget is being
/// realized, and allows you to override how the GL context is
/// created. This is useful when you want to reuse an existing GL
/// context, or if you want to try creating different kinds of GL
/// options.
/// </para>
/// <para>
/// If context creation fails then the signal handler can use
/// gtk_gl_area_set_error() to register a more detailed error
/// of how the construction failed.
/// </para>
/// </summary>

	public static IObservable<GtkGLAreaHandleSignalStructs.CreateContextSignal> Signal_CreateContext(this GtkGLAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGLAreaHandleSignalStructs.CreateContextSignal> obs) =>
		{
			GtkGLAreaHandleSignalDelegates.create_context handler = ( MentorLake.Gtk.GtkGLAreaHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGLAreaHandleSignalStructs.CreateContextSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-context", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::render signal is emitted every time the contents
/// of the #GtkGLArea should be redrawn.
/// </para>
/// <para>
/// The @context is bound to the @area prior to emitting this function,
/// and the buffers are painted to the window once the emission terminates.
/// </para>
/// </summary>

	public static IObservable<GtkGLAreaHandleSignalStructs.RenderSignal> Signal_Render(this GtkGLAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGLAreaHandleSignalStructs.RenderSignal> obs) =>
		{
			GtkGLAreaHandleSignalDelegates.render handler = ( MentorLake.Gtk.GtkGLAreaHandle self,  MentorLake.Gdk.GdkGLContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGLAreaHandleSignalStructs.RenderSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "render", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::resize signal is emitted once when the widget is realized, and
/// then each time the widget is changed while realized. This is useful
/// in order to keep GL state up to date with the widget size, like for
/// instance camera properties which may depend on the width/height ratio.
/// </para>
/// <para>
/// The GL context for the area is guaranteed to be current when this signal
/// is emitted.
/// </para>
/// <para>
/// The default handler sets up the GL viewport.
/// </para>
/// </summary>

	public static IObservable<GtkGLAreaHandleSignalStructs.ResizeSignal> Signal_Resize(this GtkGLAreaHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGLAreaHandleSignalStructs.ResizeSignal> obs) =>
		{
			GtkGLAreaHandleSignalDelegates.resize handler = ( MentorLake.Gtk.GtkGLAreaHandle self,  int width,  int height,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGLAreaHandleSignalStructs.ResizeSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGLAreaHandleSignalStructs
{

public class CreateContextSignal
{

	public MentorLake.Gtk.GtkGLAreaHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// a newly created #GdkGLContext;
///     the #GtkGLArea widget will take ownership of the returned value.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkGLContextHandle ReturnValue;
}

public class RenderSignal
{

	public MentorLake.Gtk.GtkGLAreaHandle Self;
/// <summary>
/// <para>
/// the #GdkGLContext used by @area
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkGLContextHandle Context;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ResizeSignal
{

	public MentorLake.Gtk.GtkGLAreaHandle Self;
/// <summary>
/// <para>
/// the width of the viewport
/// </para>
/// </summary>

	public int Width;
/// <summary>
/// <para>
/// the height of the viewport
/// </para>
/// </summary>

	public int Height;

	public IntPtr UserData;
}
}

public static class GtkGLAreaHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::create-context signal is emitted when the widget is being
/// realized, and allows you to override how the GL context is
/// created. This is useful when you want to reuse an existing GL
/// context, or if you want to try creating different kinds of GL
/// options.
/// </para>
/// <para>
/// If context creation fails then the signal handler can use
/// gtk_gl_area_set_error() to register a more detailed error
/// of how the construction failed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// a newly created #GdkGLContext;
///     the #GtkGLArea widget will take ownership of the returned value.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gdk.GdkGLContextHandle create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::render signal is emitted every time the contents
/// of the #GtkGLArea should be redrawn.
/// </para>
/// <para>
/// The @context is bound to the @area prior to emitting this function,
/// and the buffers are painted to the window once the emission terminates.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the #GdkGLContext used by @area
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// The ::resize signal is emitted once when the widget is realized, and
/// then each time the widget is changed while realized. This is useful
/// in order to keep GL state up to date with the widget size, like for
/// instance camera properties which may depend on the width/height ratio.
/// </para>
/// <para>
/// The GL context for the area is guaranteed to be current when this signal
/// is emitted.
/// </para>
/// <para>
/// The default handler sets up the GL viewport.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="width">
/// the width of the viewport
/// </param>
/// <param name="height">
/// the height of the viewport
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle self, int width, int height, IntPtr user_data);

}


public static class GtkGLAreaHandleExtensions
{
/// <summary>
/// <para>
/// Ensures that the @area framebuffer object is made the current draw
/// and read target, and that all the required buffers for the @area
/// are created and bound to the frambuffer.
/// </para>
/// <para>
/// This function is automatically called before emitting the
/// #GtkGLArea::render signal, and doesn&apos;t normally need to be called
/// by application code.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>

	public static T AttachBuffers<T>(this T area) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_attach_buffers(area);
		return area;
	}

/// <summary>
/// <para>
/// Returns whether the area is in auto render mode or not.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// %TRUE if the @area is auto rendering, %FALSE otherwise
/// </return>

	public static bool GetAutoRender(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_auto_render(area);
	}

/// <summary>
/// <para>
/// Retrieves the #GdkGLContext used by @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// the #GdkGLContext
/// </return>

	public static MentorLake.Gdk.GdkGLContextHandle GetContext(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_context(area);
	}

/// <summary>
/// <para>
/// Gets the current error set on the @area.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// the #GError or %NULL
/// </return>

	public static MentorLake.GLib.GErrorHandle GetError(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_error(area);
	}

/// <summary>
/// <para>
/// Returns whether the area has an alpha component.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// %TRUE if the @area has an alpha component, %FALSE otherwise
/// </return>

	public static bool GetHasAlpha(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_has_alpha(area);
	}

/// <summary>
/// <para>
/// Returns whether the area has a depth buffer.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// %TRUE if the @area has a depth buffer, %FALSE otherwise
/// </return>

	public static bool GetHasDepthBuffer(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_has_depth_buffer(area);
	}

/// <summary>
/// <para>
/// Returns whether the area has a stencil buffer.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// %TRUE if the @area has a stencil buffer, %FALSE otherwise
/// </return>

	public static bool GetHasStencilBuffer(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_has_stencil_buffer(area);
	}

/// <summary>
/// <para>
/// Retrieves the required version of OpenGL set
/// using gtk_gl_area_set_required_version().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="major">
/// return location for the required major version
/// </param>
/// <param name="minor">
/// return location for the required minor version
/// </param>

	public static T GetRequiredVersion<T>(this T area, out int major, out int minor) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_get_required_version(area, out major, out minor);
		return area;
	}

/// <summary>
/// <para>
/// Retrieves the value set by gtk_gl_area_set_use_es().
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <return>
/// %TRUE if the #GtkGLArea should create an OpenGL ES context
///   and %FALSE otherwise
/// </return>

	public static bool GetUseEs(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		return GtkGLAreaHandleExterns.gtk_gl_area_get_use_es(area);
	}

/// <summary>
/// <para>
/// Ensures that the #GdkGLContext used by @area is associated with
/// the #GtkGLArea.
/// </para>
/// <para>
/// This function is automatically called before emitting the
/// #GtkGLArea::render signal, and doesn&apos;t normally need to be called
/// by application code.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>

	public static T MakeCurrent<T>(this T area) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_make_current(area);
		return area;
	}

/// <summary>
/// <para>
/// Marks the currently rendered data (if any) as invalid, and queues
/// a redraw of the widget, ensuring that the #GtkGLArea::render signal
/// is emitted during the draw.
/// </para>
/// <para>
/// This is only needed when the gtk_gl_area_set_auto_render() has
/// been called with a %FALSE value. The default behaviour is to
/// emit #GtkGLArea::render on each draw.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>

	public static T QueueRender<T>(this T area) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_queue_render(area);
		return area;
	}

/// <summary>
/// <para>
/// If @auto_render is %TRUE the #GtkGLArea::render signal will be
/// emitted every time the widget draws. This is the default and is
/// useful if drawing the widget is faster.
/// </para>
/// <para>
/// If @auto_render is %FALSE the data from previous rendering is kept
/// around and will be used for drawing the widget the next time,
/// unless the window is resized. In order to force a rendering
/// gtk_gl_area_queue_render() must be called. This mode is useful when
/// the scene changes seldomly, but takes a long time to redraw.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="auto_render">
/// a boolean
/// </param>

	public static T SetAutoRender<T>(this T area, bool auto_render) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_auto_render(area, auto_render);
		return area;
	}

/// <summary>
/// <para>
/// Sets an error on the area which will be shown instead of the
/// GL rendering. This is useful in the #GtkGLArea::create-context
/// signal if GL context creation fails.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="error">
/// a new #GError, or %NULL to unset the error
/// </param>

	public static T SetError<T>(this T area, MentorLake.GLib.GErrorHandle error) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_error(area, error);
		return area;
	}

/// <summary>
/// <para>
/// If @has_alpha is %TRUE the buffer allocated by the widget will have
/// an alpha channel component, and when rendering to the window the
/// result will be composited over whatever is below the widget.
/// </para>
/// <para>
/// If @has_alpha is %FALSE there will be no alpha channel, and the
/// buffer will fully replace anything below the widget.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="has_alpha">
/// %TRUE to add an alpha component
/// </param>

	public static T SetHasAlpha<T>(this T area, bool has_alpha) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_has_alpha(area, has_alpha);
		return area;
	}

/// <summary>
/// <para>
/// If @has_depth_buffer is %TRUE the widget will allocate and
/// enable a depth buffer for the target framebuffer. Otherwise
/// there will be none.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="has_depth_buffer">
/// %TRUE to add a depth buffer
/// </param>

	public static T SetHasDepthBuffer<T>(this T area, bool has_depth_buffer) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_has_depth_buffer(area, has_depth_buffer);
		return area;
	}

/// <summary>
/// <para>
/// If @has_stencil_buffer is %TRUE the widget will allocate and
/// enable a stencil buffer for the target framebuffer. Otherwise
/// there will be none.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="has_stencil_buffer">
/// %TRUE to add a stencil buffer
/// </param>

	public static T SetHasStencilBuffer<T>(this T area, bool has_stencil_buffer) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_has_stencil_buffer(area, has_stencil_buffer);
		return area;
	}

/// <summary>
/// <para>
/// Sets the required version of OpenGL to be used when creating the context
/// for the widget.
/// </para>
/// <para>
/// This function must be called before the area has been realized.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="major">
/// the major version
/// </param>
/// <param name="minor">
/// the minor version
/// </param>

	public static T SetRequiredVersion<T>(this T area, int major, int minor) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_required_version(area, major, minor);
		return area;
	}

/// <summary>
/// <para>
/// Sets whether the @area should create an OpenGL or an OpenGL ES context.
/// </para>
/// <para>
/// You should check the capabilities of the #GdkGLContext before drawing
/// with either API.
/// </para>
/// </summary>

/// <param name="area">
/// a #GtkGLArea
/// </param>
/// <param name="use_es">
/// whether to use OpenGL or OpenGL ES
/// </param>

	public static T SetUseEs<T>(this T area, bool use_es) where T : GtkGLAreaHandle
	{
		if (area.IsInvalid) throw new Exception("Invalid handle (GtkGLAreaHandle)");
		GtkGLAreaHandleExterns.gtk_gl_area_set_use_es(area, use_es);
		return area;
	}

}

internal class GtkGLAreaHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))]
	internal static extern MentorLake.Gtk.GtkGLAreaHandle gtk_gl_area_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_attach_buffers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gl_area_get_auto_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gtk_gl_area_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))]
	internal static extern MentorLake.GLib.GErrorHandle gtk_gl_area_get_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gl_area_get_has_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gl_area_get_has_depth_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gl_area_get_has_stencil_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_get_required_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, out int major, out int minor);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gl_area_get_use_es([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_make_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_queue_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_auto_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, bool auto_render);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_has_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, bool has_alpha);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_has_depth_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, bool has_depth_buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_has_stencil_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, bool has_stencil_buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_required_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, int major, int minor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_set_use_es([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area, bool use_es);

}
