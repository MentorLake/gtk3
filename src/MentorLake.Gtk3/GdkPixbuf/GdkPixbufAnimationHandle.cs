namespace MentorLake.GdkPixbuf;

public class GdkPixbufAnimationHandle : GObjectHandle
{
	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromFile(string filename)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_file(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromResource(string resource_path)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_resource(resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromStream(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result)
	{
		var externCallResult = GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream_finish(async_result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void NewFromStreamAsync(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream_async(stream, cancellable, callback, user_data);
	}

}

public static class GdkPixbufAnimationHandleExtensions
{
	public static int GetHeight(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_height(animation);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle GetIter(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation, MentorLake.GLib.GTimeValHandle start_time)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_iter(animation, start_time);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetStaticImage(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_static_image(animation);
	}

	public static int GetWidth(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_width(animation);
	}

	public static bool IsStaticImage(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_is_static_image(animation);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle Ref(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationHandle)");
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_ref(animation);
	}

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle>))]
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
