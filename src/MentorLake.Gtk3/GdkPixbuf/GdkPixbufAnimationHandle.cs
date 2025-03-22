namespace MentorLake.GdkPixbuf;

public class GdkPixbufAnimationHandle : GObjectHandle
{
	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromFile(string filename)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_file(filename);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromResource(string resource_path)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_resource(resource_path);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromStream(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream(stream, cancellable);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle NewFromStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_new_from_stream_finish(async_result);
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
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_height(animation);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle GetIter(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation, MentorLake.GLib.GTimeValHandle start_time)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_iter(animation, start_time);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetStaticImage(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_static_image(animation);
	}

	public static int GetWidth(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_get_width(animation);
	}

	public static bool IsStaticImage(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_is_static_image(animation);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufAnimationHandle Ref(this MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation)
	{
		return GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_ref(animation);
	}

	public static T Unref<T>(this T animation) where T : GdkPixbufAnimationHandle
	{
		GdkPixbufAnimationHandleExterns.gdk_pixbuf_animation_unref(animation);
		return animation;
	}

}

internal class GdkPixbufAnimationHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_file(string filename);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_resource(string resource_path);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_new_from_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_animation_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle gdk_pixbuf_animation_get_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle start_time);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_animation_get_static_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_animation_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_animation_is_static_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufAnimationHandle gdk_pixbuf_animation_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_animation_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_animation_new_from_stream_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
