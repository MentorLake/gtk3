namespace MentorLake.Gtk;

public class GtkGLAreaHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkGLAreaHandle New()
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_new();
	}

}
public static class GtkGLAreaHandleSignalExtensions
{

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

public struct CreateContextSignal
{
	public MentorLake.Gtk.GtkGLAreaHandle Self;
	public IntPtr UserData;
	public MentorLake.Gdk.GdkGLContextHandle ReturnValue;
}

public struct RenderSignal
{
	public MentorLake.Gtk.GtkGLAreaHandle Self;
	public MentorLake.Gdk.GdkGLContextHandle Context;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ResizeSignal
{
	public MentorLake.Gtk.GtkGLAreaHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
}
}

public static class GtkGLAreaHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gdk.GdkGLContextHandle create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))] MentorLake.Gdk.GdkGLContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle self, int width, int height, IntPtr user_data);

}


public static class GtkGLAreaHandleExtensions
{
	public static T AttachBuffers<T>(this T area) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_attach_buffers(area);
		return area;
	}

	public static bool GetAutoRender(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_auto_render(area);
	}

	public static MentorLake.Gdk.GdkGLContextHandle GetContext(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_context(area);
	}

	public static MentorLake.GLib.GErrorHandle GetError(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_error(area);
	}

	public static bool GetHasAlpha(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_has_alpha(area);
	}

	public static bool GetHasDepthBuffer(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_has_depth_buffer(area);
	}

	public static bool GetHasStencilBuffer(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_has_stencil_buffer(area);
	}

	public static T GetRequiredVersion<T>(this T area, out int major, out int minor) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_get_required_version(area, out major, out minor);
		return area;
	}

	public static bool GetUseEs(this MentorLake.Gtk.GtkGLAreaHandle area)
	{
		return GtkGLAreaHandleExterns.gtk_gl_area_get_use_es(area);
	}

	public static T MakeCurrent<T>(this T area) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_make_current(area);
		return area;
	}

	public static T QueueRender<T>(this T area) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_queue_render(area);
		return area;
	}

	public static T SetAutoRender<T>(this T area, bool auto_render) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_auto_render(area, auto_render);
		return area;
	}

	public static T SetError<T>(this T area, MentorLake.GLib.GErrorHandle error) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_error(area, error);
		return area;
	}

	public static T SetHasAlpha<T>(this T area, bool has_alpha) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_has_alpha(area, has_alpha);
		return area;
	}

	public static T SetHasDepthBuffer<T>(this T area, bool has_depth_buffer) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_has_depth_buffer(area, has_depth_buffer);
		return area;
	}

	public static T SetHasStencilBuffer<T>(this T area, bool has_stencil_buffer) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_has_stencil_buffer(area, has_stencil_buffer);
		return area;
	}

	public static T SetRequiredVersion<T>(this T area, int major, int minor) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_required_version(area, major, minor);
		return area;
	}

	public static T SetUseEs<T>(this T area, bool use_es) where T : GtkGLAreaHandle
	{
		GtkGLAreaHandleExterns.gtk_gl_area_set_use_es(area, use_es);
		return area;
	}

}

internal class GtkGLAreaHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGLAreaHandle gtk_gl_area_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gl_area_attach_buffers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gl_area_get_auto_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gtk_gl_area_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGLAreaHandle>))] MentorLake.Gtk.GtkGLAreaHandle area);

	[DllImport(GtkLibrary.Name)]
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
