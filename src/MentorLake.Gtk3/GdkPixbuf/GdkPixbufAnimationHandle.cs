namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// An opaque object representing an animation.
/// </para>
/// <para>
/// The GdkPixBuf library provides a simple mechanism to load and
/// represent animations. An animation is conceptually a series of
/// frames to be displayed over time.
/// </para>
/// <para>
/// The animation may not be represented as a series of frames
/// internally; for example, it may be stored as a sprite and
/// instructions for moving the sprite around a background.
/// </para>
/// <para>
/// To display an animation you don&apos;t need to understand its
/// representation, however; you just ask `GdkPixbuf` what should
/// be displayed at a given point in time.
/// </para>
/// </summary>

public class GdkPixbufAnimationHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new animation by loading it from a file.
/// </para>
/// <para>
/// The file format is detected automatically.
/// </para>
/// <para>
/// If the file&apos;s format does not support multi-frame images, then an animation
/// with a single frame will be created.
/// </para>
/// <para>
/// Possible errors are in the `GDK_PIXBUF_ERROR` and `G_FILE_ERROR` domains.
/// </para>
/// </summary>

/// <param name="filename">
/// Name of file to load, in the GLib file
///   name encoding
/// </param>
/// <return>
/// A newly-created animation
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromFile(string filename)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_file(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf animation by loading an image from an resource.
/// </para>
/// <para>
/// The file format is detected automatically. If `NULL` is returned, then
/// @error will be set.
/// </para>
/// </summary>

/// <param name="resource_path">
/// the path of the resource file
/// </param>
/// <return>
/// A newly-created animation
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromResource(string resource_path)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_resource(resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new animation by loading it from an input stream.
/// </para>
/// <para>
/// The file format is detected automatically.
/// </para>
/// <para>
/// If `NULL` is returned, then @error will be set.
/// </para>
/// <para>
/// The @cancellable can be used to abort the operation from another thread.
/// If the operation was cancelled, the error `G_IO_ERROR_CANCELLED` will be
/// returned. Other possible errors are in the `GDK_PIXBUF_ERROR` and
/// `G_IO_ERROR` domains.
/// </para>
/// <para>
/// The stream is not closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a `GInputStream` to load the pixbuf from
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object
/// </param>
/// <return>
/// A newly-created animation
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromStream(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous pixbuf animation creation operation started with
/// [func@GdkPixbuf.PixbufAnimation.new_from_stream_async].
/// </para>
/// </summary>

/// <param name="async_result">
/// a #GAsyncResult
/// </param>
/// <return>
/// the newly created animation
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream_finish(async_result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new animation by asynchronously loading an image from an input stream.
/// </para>
/// <para>
/// For more details see gdk_pixbuf_new_from_stream(), which is the synchronous
/// version of this function.
/// </para>
/// <para>
/// When the operation is finished, `callback` will be called in the main thread.
/// You can then call gdk_pixbuf_animation_new_from_stream_finish() to get the
/// result of the operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GInputStream from which to load the animation
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object
/// </param>
/// <param name="callback">
/// a `GAsyncReadyCallback` to call when the pixbuf is loaded
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static void NewFromStreamAsync(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream_async(stream, cancellable, callback, user_data);
	}

}

public static class GdkPixbufAnimationHandleExtensions
{
/// <summary>
/// <para>
/// Queries the height of the bounding box of a pixbuf animation.
/// </para>
/// </summary>

/// <param name="animation">
/// An animation.
/// </param>
/// <return>
/// Height of the bounding box of the animation.
/// </return>

	public static int GetHeight(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_height(animation);
	}

/// <summary>
/// <para>
/// Get an iterator for displaying an animation.
/// </para>
/// <para>
/// The iterator provides the frames that should be displayed at a
/// given time.
/// </para>
/// <para>
/// @start_time would normally come from g_get_current_time(), and marks
/// the beginning of animation playback. After creating an iterator, you
/// should immediately display the pixbuf returned by
/// gdk_pixbuf_animation_iter_get_pixbuf(). Then, you should install
/// a timeout (with g_timeout_add()) or by some other mechanism ensure
/// that you&apos;ll update the image after
/// gdk_pixbuf_animation_iter_get_delay_time() milliseconds. Each time
/// the image is updated, you should reinstall the timeout with the new,
/// possibly-changed delay time.
/// </para>
/// <para>
/// As a shortcut, if @start_time is `NULL`, the result of
/// g_get_current_time() will be used automatically.
/// </para>
/// <para>
/// To update the image (i.e. possibly change the result of
/// gdk_pixbuf_animation_iter_get_pixbuf() to a new frame of the animation),
/// call gdk_pixbuf_animation_iter_advance().
/// </para>
/// <para>
/// If you&apos;re using #GdkPixbufLoader, in addition to updating the image
/// after the delay time, you should also update it whenever you
/// receive the area_updated signal and
/// gdk_pixbuf_animation_iter_on_currently_loading_frame() returns
/// `TRUE`. In this case, the frame currently being fed into the loader
/// has received new data, so needs to be refreshed. The delay time for
/// a frame may also be modified after an area_updated signal, for
/// example if the delay time for a frame is encoded in the data after
/// the frame itself. So your timeout should be reinstalled after any
/// area_updated signal.
/// </para>
/// <para>
/// A delay time of -1 is possible, indicating &quot;infinite&quot;.
/// </para>
/// </summary>

/// <param name="animation">
/// a #GdkPixbufAnimation
/// </param>
/// <param name="start_time">
/// time when the animation starts playing
/// </param>
/// <return>
/// an iterator to move over the animation
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle GetIter(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation, MentorLake.GLib.GTimeValHandle start_time)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_iter(animation, start_time);
	}

/// <summary>
/// <para>
/// Retrieves a static image for the animation.
/// </para>
/// <para>
/// If an animation is really just a plain image (has only one frame),
/// this function returns that image.
/// </para>
/// <para>
/// If the animation is an animation, this function returns a reasonable
/// image to use as a static unanimated image, which might be the first
/// frame, or something more sophisticated depending on the file format.
/// </para>
/// <para>
/// If an animation hasn&apos;t loaded any frames yet, this function will
/// return `NULL`.
/// </para>
/// </summary>

/// <param name="animation">
/// a #GdkPixbufAnimation
/// </param>
/// <return>
/// unanimated image representing the animation
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetStaticImage(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_static_image(animation);
	}

/// <summary>
/// <para>
/// Queries the width of the bounding box of a pixbuf animation.
/// </para>
/// </summary>

/// <param name="animation">
/// An animation.
/// </param>
/// <return>
/// Width of the bounding box of the animation.
/// </return>

	public static int GetWidth(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_width(animation);
	}

/// <summary>
/// <para>
/// Checks whether the animation is a static image.
/// </para>
/// <para>
/// If you load a file with gdk_pixbuf_animation_new_from_file() and it
/// turns out to be a plain, unanimated image, then this function will
/// return `TRUE`. Use gdk_pixbuf_animation_get_static_image() to retrieve
/// the image.
/// </para>
/// </summary>

/// <param name="animation">
/// a #GdkPixbufAnimation
/// </param>
/// <return>
/// `TRUE` if the &quot;animation&quot; was really just an image
/// </return>

	public static bool IsStaticImage(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_is_static_image(animation);
	}

/// <summary>
/// <para>
/// Adds a reference to an animation.
/// </para>
/// </summary>

/// <param name="animation">
/// An animation.
/// </param>
/// <return>
/// The same as the @animation argument.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle Ref(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_ref(animation);
	}

/// <summary>
/// <para>
/// Removes a reference from an animation.
/// </para>
/// </summary>

/// <param name="animation">
/// An animation.
/// </param>

	public static T Unref<T>(this T animation) where T : GdkPixbufAnimationHandle
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_unref(animation);
		return animation;
	}

}

internal class GdkPixbufAnimationHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_file(string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_resource(string resource_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_animation_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle gdk_pixbuf_animation_get_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle start_time);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_animation_get_static_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_animation_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_animation_is_static_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_animation_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_animation_new_from_stream_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
