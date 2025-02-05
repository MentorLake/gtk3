namespace MentorLake.Gtk3.Gtk3;

public class GtkGLAreaHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkGLAreaHandle GtkGlAreaNew()
	{
		return GtkGLAreaExterns.gtk_gl_area_new();
	}

}

public static class GtkGLAreaSignalExtensions
{

	public static IObservable<GtkGLAreaSignalStructs.CreateContextSignal> Signal_CreateContext(this GtkGLAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkGLAreaSignalStructs.CreateContextSignal> obs) =>
		{
			GtkGLAreaSignalDelegates.create_context handler = (GtkGLAreaHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGLAreaSignalStructs.CreateContextSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "create_context", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGLAreaSignalStructs.RenderSignal> Signal_Render(this GtkGLAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkGLAreaSignalStructs.RenderSignal> obs) =>
		{
			GtkGLAreaSignalDelegates.render handler = (GtkGLAreaHandle self, GdkGLContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGLAreaSignalStructs.RenderSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "render", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkGLAreaSignalStructs.ResizeSignal> Signal_Resize(this GtkGLAreaHandle instance)
	{
		return Observable.Create((IObserver<GtkGLAreaSignalStructs.ResizeSignal> obs) =>
		{
			GtkGLAreaSignalDelegates.resize handler = (GtkGLAreaHandle self, int width, int height, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGLAreaSignalStructs.ResizeSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkGLAreaSignalStructs
{

public struct CreateContextSignal
{
	public GtkGLAreaHandle Self;
	public IntPtr UserData;
	public GdkGLContextHandle ReturnValue;
}

public struct RenderSignal
{
	public GtkGLAreaHandle Self;
	public GdkGLContextHandle Context;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ResizeSignal
{
	public GtkGLAreaHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
}
}

public static class GtkGLAreaSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GdkGLContextHandle create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGLAreaHandle>))] GtkGLAreaHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGLAreaHandle>))] GtkGLAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkGLContextHandle>))] GdkGLContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGLAreaHandle>))] GtkGLAreaHandle self, int width, int height, IntPtr user_data);

}


public static class GtkGLAreaHandleExtensions
{
	public static T GtkGlAreaAttachBuffers<T>(this T area) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_attach_buffers(area);
		return area;
	}

	public static bool GtkGlAreaGetAutoRender(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_auto_render(area);
	}

	public static GdkGLContextHandle GtkGlAreaGetContext(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_context(area);
	}

	public static GErrorHandle GtkGlAreaGetError(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_error(area);
	}

	public static bool GtkGlAreaGetHasAlpha(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_alpha(area);
	}

	public static bool GtkGlAreaGetHasDepthBuffer(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_depth_buffer(area);
	}

	public static bool GtkGlAreaGetHasStencilBuffer(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_stencil_buffer(area);
	}

	public static T GtkGlAreaGetRequiredVersion<T>(this T area, out int major, out int minor) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_get_required_version(area, out major, out minor);
		return area;
	}

	public static bool GtkGlAreaGetUseEs(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_use_es(area);
	}

	public static T GtkGlAreaMakeCurrent<T>(this T area) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_make_current(area);
		return area;
	}

	public static T GtkGlAreaQueueRender<T>(this T area) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_queue_render(area);
		return area;
	}

	public static T GtkGlAreaSetAutoRender<T>(this T area, bool auto_render) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_auto_render(area, auto_render);
		return area;
	}

	public static T GtkGlAreaSetError<T>(this T area, GErrorHandle error) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_error(area, error);
		return area;
	}

	public static T GtkGlAreaSetHasAlpha<T>(this T area, bool has_alpha) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_alpha(area, has_alpha);
		return area;
	}

	public static T GtkGlAreaSetHasDepthBuffer<T>(this T area, bool has_depth_buffer) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_depth_buffer(area, has_depth_buffer);
		return area;
	}

	public static T GtkGlAreaSetHasStencilBuffer<T>(this T area, bool has_stencil_buffer) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_stencil_buffer(area, has_stencil_buffer);
		return area;
	}

	public static T GtkGlAreaSetRequiredVersion<T>(this T area, int major, int minor) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_required_version(area, major, minor);
		return area;
	}

	public static T GtkGlAreaSetUseEs<T>(this T area, bool use_es) where T : GtkGLAreaHandle
	{
		GtkGLAreaExterns.gtk_gl_area_set_use_es(area, use_es);
		return area;
	}

}

internal class GtkGLAreaExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGLAreaHandle gtk_gl_area_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_attach_buffers(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gl_area_get_auto_render(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkGLContextHandle gtk_gl_area_get_context(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GErrorHandle gtk_gl_area_get_error(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gl_area_get_has_alpha(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gl_area_get_has_depth_buffer(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gl_area_get_has_stencil_buffer(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_get_required_version(GtkGLAreaHandle area, out int major, out int minor);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gl_area_get_use_es(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_make_current(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_queue_render(GtkGLAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_auto_render(GtkGLAreaHandle area, bool auto_render);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_error(GtkGLAreaHandle area, GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_has_alpha(GtkGLAreaHandle area, bool has_alpha);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_has_depth_buffer(GtkGLAreaHandle area, bool has_depth_buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_has_stencil_buffer(GtkGLAreaHandle area, bool has_stencil_buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_required_version(GtkGLAreaHandle area, int major, int minor);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gl_area_set_use_es(GtkGLAreaHandle area, bool use_es);

}
