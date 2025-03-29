namespace MentorLake.GdkPixbuf;

public class GdkPixbufLoaderHandle : GObjectHandle
{
	public static MentorLake.GdkPixbuf.GdkPixbufLoaderHandle New()
	{
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_new();
	}

	public static MentorLake.GdkPixbuf.GdkPixbufLoaderHandle NewWithMimeType(string mime_type)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_new_with_mime_type(mime_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufLoaderHandle NewWithType(string image_type)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_new_with_type(image_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
public static class GdkPixbufLoaderHandleSignalExtensions
{

	public static IObservable<GdkPixbufLoaderHandleSignalStructs.AreaPreparedSignal> Signal_AreaPrepared(this GdkPixbufLoaderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderHandleSignalStructs.AreaPreparedSignal> obs) =>
		{
			GdkPixbufLoaderHandleSignalDelegates.area_prepared handler = ( MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderHandleSignalStructs.AreaPreparedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "area-prepared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkPixbufLoaderHandleSignalStructs.AreaUpdatedSignal> Signal_AreaUpdated(this GdkPixbufLoaderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderHandleSignalStructs.AreaUpdatedSignal> obs) =>
		{
			GdkPixbufLoaderHandleSignalDelegates.area_updated handler = ( MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self,  int x,  int y,  int width,  int height,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderHandleSignalStructs.AreaUpdatedSignal()
				{
					Self = self, X = x, Y = y, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "area-updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkPixbufLoaderHandleSignalStructs.ClosedSignal> Signal_Closed(this GdkPixbufLoaderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderHandleSignalStructs.ClosedSignal> obs) =>
		{
			GdkPixbufLoaderHandleSignalDelegates.closed handler = ( MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderHandleSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkPixbufLoaderHandleSignalStructs.SizePreparedSignal> Signal_SizePrepared(this GdkPixbufLoaderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkPixbufLoaderHandleSignalStructs.SizePreparedSignal> obs) =>
		{
			GdkPixbufLoaderHandleSignalDelegates.size_prepared handler = ( MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self,  int width,  int height,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkPixbufLoaderHandleSignalStructs.SizePreparedSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "size-prepared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkPixbufLoaderHandleSignalStructs
{

public struct AreaPreparedSignal
{
	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;
	public IntPtr UserData;
}

public struct AreaUpdatedSignal
{
	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;
	public int X;
	public int Y;
	public int Width;
	public int Height;
	public IntPtr UserData;
}

public struct ClosedSignal
{
	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;
	public IntPtr UserData;
}

public struct SizePreparedSignal
{
	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
}
}

public static class GdkPixbufLoaderHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void area_prepared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void area_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, int x, int y, int width, int height, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_prepared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, int width, int height, IntPtr user_data);

}


public static class GdkPixbufLoaderHandleExtensions
{
	public static bool Close(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_close(loader, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle GetAnimation(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_get_animation(loader);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle GetFormat(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_get_format(loader);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_get_pixbuf(loader);
	}

	public static T SetSize<T>(this T loader, int width, int height) where T : GdkPixbufLoaderHandle
	{
		GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_set_size(loader, width, height);
		return loader;
	}

	public static bool Write(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, char[] buf, UIntPtr count)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_write(loader, buf, count, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool WriteBytes(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, MentorLake.GLib.GBytesHandle buffer)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_write_bytes(loader, buffer, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GdkPixbufLoaderHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufLoaderHandle gdk_pixbuf_loader_new();

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_mime_type(string mime_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_type(string image_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_loader_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_loader_get_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_loader_get_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_loader_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_loader_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_loader_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, char[] buf, UIntPtr count, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_loader_write_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle buffer, out MentorLake.GLib.GErrorHandle error);

}
