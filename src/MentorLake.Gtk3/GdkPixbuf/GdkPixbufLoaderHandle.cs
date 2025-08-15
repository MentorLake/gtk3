namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Incremental image loader.
/// </para>
/// <para>
/// `GdkPixbufLoader` provides a way for applications to drive the
/// process of loading an image, by letting them send the image data
/// directly to the loader instead of having the loader read the data
/// from a file. Applications can use this functionality instead of
/// `gdk_pixbuf_new_from_file()` or `gdk_pixbuf_animation_new_from_file()`
/// when they need to parse image data in small chunks. For example,
/// it should be used when reading an image from a (potentially) slow
/// network connection, or when loading an extremely large file.
/// </para>
/// <para>
/// To use `GdkPixbufLoader` to load an image, create a new instance,
/// and call [method@GdkPixbuf.PixbufLoader.write] to send the data
/// to it. When done, [method@GdkPixbuf.PixbufLoader.close] should be
/// called to end the stream and finalize everything.
/// </para>
/// <para>
/// The loader will emit three important signals throughout the process:
/// </para>
/// <para>
///  - [signal@GdkPixbuf.PixbufLoader::size-prepared] will be emitted as
///    soon as the image has enough information to determine the size of
///    the image to be used. If you want to scale the image while loading
///    it, you can call [method@GdkPixbuf.PixbufLoader.set_size] in
///    response to this signal.
///  - [signal@GdkPixbuf.PixbufLoader::area-prepared] will be emitted as
///    soon as the pixbuf of the desired has been allocated. You can obtain
///    the `GdkPixbuf` instance by calling [method@GdkPixbuf.PixbufLoader.get_pixbuf].
///    If you want to use it, simply acquire a reference to it. You can
///    also call `gdk_pixbuf_loader_get_pixbuf()` later to get the same
///    pixbuf.
///  - [signal@GdkPixbuf.PixbufLoader::area-updated] will be emitted every
///    time a region is updated. This way you can update a partially
///    completed image. Note that you do not know anything about the
///    completeness of an image from the updated area. For example, in an
///    interlaced image you will need to make several passes before the
///    image is done loading.
/// </para>
/// <para>
/// ## Loading an animation
/// </para>
/// <para>
/// Loading an animation is almost as easy as loading an image. Once the
/// first [signal@GdkPixbuf.PixbufLoader::area-prepared] signal has been
/// emitted, you can call [method@GdkPixbuf.PixbufLoader.get_animation] to
/// get the [class@GdkPixbuf.PixbufAnimation] instance, and then call
/// and [method@GdkPixbuf.PixbufAnimation.get_iter] to get a
/// [class@GdkPixbuf.PixbufAnimationIter] to retrieve the pixbuf for the
/// desired time stamp.
/// </para>
/// </summary>

public class GdkPixbufLoaderHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new pixbuf loader object.
/// </para>
/// </summary>

/// <return>
/// A newly-created pixbuf loader.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufLoaderHandle New()
	{
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_new();
	}

/// <summary>
/// <para>
/// Creates a new pixbuf loader object that always attempts to parse
/// image data as if it were an image of MIME type @mime_type, instead of
/// identifying the type automatically.
/// </para>
/// <para>
/// This function is useful if you want an error if the image isn&apos;t the
/// expected MIME type; for loading image formats that can&apos;t be reliably
/// identified by looking at the data; or if the user manually forces a
/// specific MIME type.
/// </para>
/// <para>
/// The list of supported mime types depends on what image loaders
/// are installed, but typically &quot;image/png&quot;, &quot;image/jpeg&quot;, &quot;image/gif&quot;,
/// &quot;image/tiff&quot; and &quot;image/x-xpixmap&quot; are among the supported mime types.
/// To obtain the full list of supported mime types, call
/// gdk_pixbuf_format_get_mime_types() on each of the #GdkPixbufFormat
/// structs returned by gdk_pixbuf_get_formats().
/// </para>
/// </summary>

/// <param name="mime_type">
/// the mime type to be loaded
/// </param>
/// <return>
/// A newly-created pixbuf loader.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufLoaderHandle NewWithMimeType(string mime_type)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_new_with_mime_type(mime_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf loader object that always attempts to parse
/// image data as if it were an image of type @image_type, instead of
/// identifying the type automatically.
/// </para>
/// <para>
/// This function is useful if you want an error if the image isn&apos;t the
/// expected type; for loading image formats that can&apos;t be reliably
/// identified by looking at the data; or if the user manually forces
/// a specific type.
/// </para>
/// <para>
/// The list of supported image formats depends on what image loaders
/// are installed, but typically &quot;png&quot;, &quot;jpeg&quot;, &quot;gif&quot;, &quot;tiff&quot; and
/// &quot;xpm&quot; are among the supported formats. To obtain the full list of
/// supported image formats, call gdk_pixbuf_format_get_name() on each
/// of the #GdkPixbufFormat structs returned by gdk_pixbuf_get_formats().
/// </para>
/// </summary>

/// <param name="image_type">
/// name of the image format to be loaded with the image
/// </param>
/// <return>
/// A newly-created pixbuf loader.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufLoaderHandle NewWithType(string image_type)
	{
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_new_with_type(image_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
public static class GdkPixbufLoaderHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the pixbuf loader has allocated the
/// pixbuf in the desired size.
/// </para>
/// <para>
/// After this signal is emitted, applications can call
/// gdk_pixbuf_loader_get_pixbuf() to fetch the partially-loaded
/// pixbuf.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a significant area of the image being
/// loaded has been updated.
/// </para>
/// <para>
/// Normally it means that a complete scanline has been read in, but
/// it could be a different area as well.
/// </para>
/// <para>
/// Applications can use this signal to know when to repaint
/// areas of an image that is being loaded.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when gdk_pixbuf_loader_close() is called.
/// </para>
/// <para>
/// It can be used by different parts of an application to receive
/// notification when an image loader is closed by the code that
/// drives it.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when the pixbuf loader has been fed the
/// initial amount of data that is required to figure out the size
/// of the image that it will create.
/// </para>
/// <para>
/// Applications can call gdk_pixbuf_loader_set_size() in response
/// to this signal to set the desired size to which the image
/// should be scaled.
/// </para>
/// </summary>

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

public class AreaPreparedSignal
{

	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;

	public IntPtr UserData;
}

public class AreaUpdatedSignal
{

	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;
/// <summary>
/// <para>
/// X offset of upper-left corner of the updated area.
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// Y offset of upper-left corner of the updated area.
/// </para>
/// </summary>

	public int Y;
/// <summary>
/// <para>
/// Width of updated area.
/// </para>
/// </summary>

	public int Width;
/// <summary>
/// <para>
/// Height of updated area.
/// </para>
/// </summary>

	public int Height;

	public IntPtr UserData;
}

public class ClosedSignal
{

	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;

	public IntPtr UserData;
}

public class SizePreparedSignal
{

	public MentorLake.GdkPixbuf.GdkPixbufLoaderHandle Self;
/// <summary>
/// <para>
/// the original width of the image
/// </para>
/// </summary>

	public int Width;
/// <summary>
/// <para>
/// the original height of the image
/// </para>
/// </summary>

	public int Height;

	public IntPtr UserData;
}
}

public static class GdkPixbufLoaderHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the pixbuf loader has allocated the
/// pixbuf in the desired size.
/// </para>
/// <para>
/// After this signal is emitted, applications can call
/// gdk_pixbuf_loader_get_pixbuf() to fetch the partially-loaded
/// pixbuf.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void area_prepared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a significant area of the image being
/// loaded has been updated.
/// </para>
/// <para>
/// Normally it means that a complete scanline has been read in, but
/// it could be a different area as well.
/// </para>
/// <para>
/// Applications can use this signal to know when to repaint
/// areas of an image that is being loaded.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// X offset of upper-left corner of the updated area.
/// </param>
/// <param name="y">
/// Y offset of upper-left corner of the updated area.
/// </param>
/// <param name="width">
/// Width of updated area.
/// </param>
/// <param name="height">
/// Height of updated area.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void area_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, int x, int y, int width, int height, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when gdk_pixbuf_loader_close() is called.
/// </para>
/// <para>
/// It can be used by different parts of an application to receive
/// notification when an image loader is closed by the code that
/// drives it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the pixbuf loader has been fed the
/// initial amount of data that is required to figure out the size
/// of the image that it will create.
/// </para>
/// <para>
/// Applications can call gdk_pixbuf_loader_set_size() in response
/// to this signal to set the desired size to which the image
/// should be scaled.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="width">
/// the original width of the image
/// </param>
/// <param name="height">
/// the original height of the image
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_prepared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle self, int width, int height, IntPtr user_data);

}


public static class GdkPixbufLoaderHandleExtensions
{
/// <summary>
/// <para>
/// Informs a pixbuf loader that no further writes with
/// gdk_pixbuf_loader_write() will occur, so that it can free its
/// internal loading structures.
/// </para>
/// <para>
/// This function also tries to parse any data that hasn&apos;t yet been parsed;
/// if the remaining data is partial or corrupt, an error will be returned.
/// </para>
/// <para>
/// If `FALSE` is returned, `error` will be set to an error from the
/// `GDK_PIXBUF_ERROR` or `G_FILE_ERROR` domains.
/// </para>
/// <para>
/// If you&apos;re just cancelling a load rather than expecting it to be finished,
/// passing `NULL` for `error` to ignore it is reasonable.
/// </para>
/// <para>
/// Remember that this function does not release a reference on the loader, so
/// you will need to explicitly release any reference you hold.
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader.
/// </param>
/// <return>
/// `TRUE` if all image data written so far was successfully
///   passed out via the update_area signal
/// </return>

	public static bool Close(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_close(loader, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Queries the #GdkPixbufAnimation that a pixbuf loader is currently creating.
/// </para>
/// <para>
/// In general it only makes sense to call this function after the
/// [signal@GdkPixbuf.PixbufLoader::area-prepared] signal has been emitted by
/// the loader.
/// </para>
/// <para>
/// If the loader doesn&apos;t have enough bytes yet, and hasn&apos;t emitted the `area-prepared`
/// signal, this function will return `NULL`.
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader
/// </param>
/// <return>
/// The animation that the loader is
///   currently loading
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle GetAnimation(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_get_animation(loader);
	}

/// <summary>
/// <para>
/// Obtains the available information about the format of the
/// currently loading image file.
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader.
/// </param>
/// <return>
/// A #GdkPixbufFormat
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle GetFormat(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_get_format(loader);
	}

/// <summary>
/// <para>
/// Queries the #GdkPixbuf that a pixbuf loader is currently creating.
/// </para>
/// <para>
/// In general it only makes sense to call this function after the
/// [signal@GdkPixbuf.PixbufLoader::area-prepared] signal has been
/// emitted by the loader; this means that enough data has been read
/// to know the size of the image that will be allocated.
/// </para>
/// <para>
/// If the loader has not received enough data via gdk_pixbuf_loader_write(),
/// then this function returns `NULL`.
/// </para>
/// <para>
/// The returned pixbuf will be the same in all future calls to the loader,
/// so if you want to keep using it, you should acquire a reference to it.
/// </para>
/// <para>
/// Additionally, if the loader is an animation, it will return the &quot;static
/// image&quot; of the animation (see gdk_pixbuf_animation_get_static_image()).
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader.
/// </param>
/// <return>
/// The pixbuf that the loader is
///   creating
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader)
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		return GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_get_pixbuf(loader);
	}

/// <summary>
/// <para>
/// Causes the image to be scaled while it is loaded.
/// </para>
/// <para>
/// The desired image size can be determined relative to the original
/// size of the image by calling gdk_pixbuf_loader_set_size() from a
/// signal handler for the ::size-prepared signal.
/// </para>
/// <para>
/// Attempts to set the desired image size  are ignored after the
/// emission of the ::size-prepared signal.
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader.
/// </param>
/// <param name="width">
/// The desired width of the image being loaded.
/// </param>
/// <param name="height">
/// The desired height of the image being loaded.
/// </param>

	public static T SetSize<T>(this T loader, int width, int height) where T : GdkPixbufLoaderHandle
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_set_size(loader, width, height);
		return loader;
	}

/// <summary>
/// <para>
/// Parses the next `count` bytes in the given image buffer.
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader.
/// </param>
/// <param name="buf">
/// Pointer to image data.
/// </param>
/// <param name="count">
/// Length of the @buf buffer in bytes.
/// </param>
/// <return>
/// `TRUE` if the write was successful, or
///   `FALSE` if the loader cannot parse the buffer
/// </return>

	public static bool Write(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, byte[] buf, UIntPtr count)
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_write(loader, buf, count, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses the next contents of the given image buffer.
/// </para>
/// </summary>

/// <param name="loader">
/// A pixbuf loader.
/// </param>
/// <param name="buffer">
/// The image data as a `GBytes` buffer.
/// </param>
/// <return>
/// `TRUE` if the write was successful, or `FALSE` if
///   the loader cannot parse the buffer
/// </return>

	public static bool WriteBytes(this MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, MentorLake.GLib.GBytesHandle buffer)
	{
		if (loader.IsInvalid) throw new Exception("Invalid handle (GdkPixbufLoaderHandle)");
		var externCallResult = GdkPixbufLoaderHandleExterns.gdk_pixbuf_loader_write_bytes(loader, buffer, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GdkPixbufLoaderHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufLoaderHandle gdk_pixbuf_loader_new();

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_mime_type(string mime_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufLoaderHandle gdk_pixbuf_loader_new_with_type(string image_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_loader_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_loader_get_animation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_loader_get_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_loader_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_loader_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_loader_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, byte[] buf, UIntPtr count, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_loader_write_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufLoaderHandle>))] MentorLake.GdkPixbuf.GdkPixbufLoaderHandle loader, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle buffer, out MentorLake.GLib.GErrorHandle error);

}
