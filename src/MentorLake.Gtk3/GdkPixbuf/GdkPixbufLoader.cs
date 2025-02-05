namespace MentorLake.Gtk3.GdkPixbuf;

public class GdkPixbufLoaderHandle : GObjectHandle
{
	public static GdkPixbufLoaderHandle New()
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new();
	}

	public static GdkPixbufLoaderHandle NewWithMimeType(string mime_type, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new_with_mime_type(mime_type, out error);
	}

	public static GdkPixbufLoaderHandle NewWithType(string image_type, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_new_with_type(image_type, out error);
	}

}

public static class GdkPixbufLoaderSignalExtensions
{

	public static IObservable<GdkPixbufLoaderSignalStructs.AreaPreparedSignal> Signal_AreaPrepared(this GdkPixbufLoaderHandle instance)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderSignalStructs.AreaPreparedSignal> obs) =>
		{
			GdkPixbufLoaderSignalDelegates.area_prepared handler = (GdkPixbufLoaderHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderSignalStructs.AreaPreparedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "area_prepared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkPixbufLoaderSignalStructs.AreaUpdatedSignal> Signal_AreaUpdated(this GdkPixbufLoaderHandle instance)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderSignalStructs.AreaUpdatedSignal> obs) =>
		{
			GdkPixbufLoaderSignalDelegates.area_updated handler = (GdkPixbufLoaderHandle self, int x, int y, int width, int height, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderSignalStructs.AreaUpdatedSignal()
				{
					Self = self, X = x, Y = y, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "area_updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkPixbufLoaderSignalStructs.ClosedSignal> Signal_Closed(this GdkPixbufLoaderHandle instance)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderSignalStructs.ClosedSignal> obs) =>
		{
			GdkPixbufLoaderSignalDelegates.closed handler = (GdkPixbufLoaderHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkPixbufLoaderSignalStructs.SizePreparedSignal> Signal_SizePrepared(this GdkPixbufLoaderHandle instance)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderSignalStructs.SizePreparedSignal> obs) =>
		{
			GdkPixbufLoaderSignalDelegates.size_prepared handler = (GdkPixbufLoaderHandle self, int width, int height, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderSignalStructs.SizePreparedSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "size_prepared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkPixbufLoaderSignalStructs
{

public struct AreaPreparedSignal
{
	public GdkPixbufLoaderHandle Self;
	public IntPtr UserData;
}

public struct AreaUpdatedSignal
{
	public GdkPixbufLoaderHandle Self;
	public int X;
	public int Y;
	public int Width;
	public int Height;
	public IntPtr UserData;
}

public struct ClosedSignal
{
	public GdkPixbufLoaderHandle Self;
	public IntPtr UserData;
}

public struct SizePreparedSignal
{
	public GdkPixbufLoaderHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
}
}

public static class GdkPixbufLoaderSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void area_prepared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkPixbufLoaderHandle>))] GdkPixbufLoaderHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void area_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkPixbufLoaderHandle>))] GdkPixbufLoaderHandle self, int x, int y, int width, int height, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkPixbufLoaderHandle>))] GdkPixbufLoaderHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_prepared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkPixbufLoaderHandle>))] GdkPixbufLoaderHandle self, int width, int height, IntPtr user_data);

}


public static class GdkPixbufLoaderHandleExtensions
{
	public static bool Close(this GdkPixbufLoaderHandle loader, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_close(loader, out error);
	}

	public static GdkPixbufAnimationHandle GetAnimation(this GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_get_animation(loader);
	}

	public static GdkPixbufFormatHandle GetFormat(this GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_get_format(loader);
	}

	public static GdkPixbufHandle GetPixbuf(this GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_get_pixbuf(loader);
	}

	public static T SetSize<T>(this T loader, int width, int height) where T : GdkPixbufLoaderHandle
	{
		GdkPixbufLoaderExterns.gdk_pixbuf_loader_set_size(loader, width, height);
		return loader;
	}

	public static bool Write(this GdkPixbufLoaderHandle loader, string buf, UIntPtr count, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_write(loader, buf, count, out error);
	}

	public static bool WriteBytes(this GdkPixbufLoaderHandle loader, GBytesHandle buffer, out GErrorHandle error)
	{
		return GdkPixbufLoaderExterns.gdk_pixbuf_loader_write_bytes(loader, buffer, out error);
	}

}

internal class GdkPixbufLoaderExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufLoaderHandle gdk_pixbuf_loader_new();

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_mime_type(string mime_type, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_type(string image_type, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_loader_close(GdkPixbufLoaderHandle loader, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufAnimationHandle gdk_pixbuf_loader_get_animation(GdkPixbufLoaderHandle loader);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufFormatHandle gdk_pixbuf_loader_get_format(GdkPixbufLoaderHandle loader);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufHandle gdk_pixbuf_loader_get_pixbuf(GdkPixbufLoaderHandle loader);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_loader_set_size(GdkPixbufLoaderHandle loader, int width, int height);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_loader_write(GdkPixbufLoaderHandle loader, string buf, UIntPtr count, out GErrorHandle error);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_loader_write_bytes(GdkPixbufLoaderHandle loader, GBytesHandle buffer, out GErrorHandle error);

}
