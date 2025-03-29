namespace MentorLake.GdkPixbuf;

public class GdkPixbufHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static MentorLake.GdkPixbuf.GdkPixbufHandle New(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new(colorspace, has_alpha, bits_per_sample, width, height);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromBytes(MentorLake.GLib.GBytesHandle data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_bytes(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromData(char[] data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, MentorLake.GdkPixbuf.GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_data(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride, destroy_fn, destroy_fn_data);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromFile(string filename, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_file(filename, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromFileAtScale(string filename, int width, int height, bool preserve_aspect_ratio, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_file_at_scale(filename, width, height, preserve_aspect_ratio, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromFileAtSize(string filename, int width, int height, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_file_at_size(filename, width, height, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromInline(int data_length, byte[] data, bool copy_pixels, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_inline(data_length, data, copy_pixels, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromResource(string resource_path, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_resource(resource_path, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromResourceAtScale(string resource_path, int width, int height, bool preserve_aspect_ratio, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_resource_at_scale(resource_path, width, height, preserve_aspect_ratio, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromStream(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream(stream, cancellable, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromStreamAtScale(MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_at_scale(stream, width, height, preserve_aspect_ratio, cancellable, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_finish(async_result, error);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromXpmData(string[] data)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_xpm_data(data);
	}

	public static int CalculateRowstride(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_calculate_rowstride(colorspace, has_alpha, bits_per_sample, width, height);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle GetFileInfo(string filename, out int width, out int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_file_info(filename, out width, out height);
	}

	public static void GetFileInfoAsync(string filename, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufHandleExterns.gdk_pixbuf_get_file_info_async(filename, cancellable, callback, user_data);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle GetFileInfoFinish(MentorLake.Gio.GAsyncResultHandle async_result, out int width, out int height, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_file_info_finish(async_result, out width, out height, error);
	}

	public static MentorLake.GLib.GSListHandle GetFormats()
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_formats();
	}

	public static bool InitModules(string path, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_init_modules(path, error);
	}

	public static void NewFromStreamAsync(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_async(stream, cancellable, callback, user_data);
	}

	public static void NewFromStreamAtScaleAsync(MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_at_scale_async(stream, width, height, preserve_aspect_ratio, cancellable, callback, user_data);
	}

	public static bool SaveToStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_stream_finish(async_result, error);
	}

}

public static class GdkPixbufHandleExtensions
{
	public static MentorLake.GdkPixbuf.GdkPixbufHandle AddAlpha(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool substitute_color, char r, char g, char b)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_add_alpha(pixbuf, substitute_color, r, g, b);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle ApplyEmbeddedOrientation(this MentorLake.GdkPixbuf.GdkPixbufHandle src)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_apply_embedded_orientation(src);
	}

	public static T Composite<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_composite(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha);
		return src;
	}

	public static T CompositeColor<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_composite_color(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha, check_x, check_y, check_size, color1, color2);
		return src;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle CompositeColorSimple(this MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_composite_color_simple(src, dest_width, dest_height, interp_type, overall_alpha, check_size, color1, color2);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle Copy(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_copy(pixbuf);
	}

	public static T CopyArea<T>(this T src_pixbuf, int src_x, int src_y, int width, int height, MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_copy_area(src_pixbuf, src_x, src_y, width, height, dest_pixbuf, dest_x, dest_y);
		return src_pixbuf;
	}

	public static bool CopyOptions(this MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_copy_options(src_pixbuf, dest_pixbuf);
	}

	public static T Fill<T>(this T pixbuf, uint pixel) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_fill(pixbuf, pixel);
		return pixbuf;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle Flip(this MentorLake.GdkPixbuf.GdkPixbufHandle src, bool horizontal)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_flip(src, horizontal);
	}

	public static int GetBitsPerSample(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_bits_per_sample(pixbuf);
	}

	public static UIntPtr GetByteLength(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_byte_length(pixbuf);
	}

	public static MentorLake.GdkPixbuf.GdkColorspace GetColorspace(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_colorspace(pixbuf);
	}

	public static bool GetHasAlpha(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_has_alpha(pixbuf);
	}

	public static int GetHeight(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_height(pixbuf);
	}

	public static int GetNChannels(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_n_channels(pixbuf);
	}

	public static string GetOption(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_option(pixbuf, key);
	}

	public static MentorLake.GLib.GHashTableHandle GetOptions(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_options(pixbuf);
	}

	public static char[] GetPixels(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_pixels(pixbuf);
	}

	public static char[] GetPixelsWithLength(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out uint length)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_pixels_with_length(pixbuf, out length);
	}

	public static int GetRowstride(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_rowstride(pixbuf);
	}

	public static int GetWidth(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_width(pixbuf);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewSubpixbuf(this MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_subpixbuf(src_pixbuf, src_x, src_y, width, height);
	}

	public static MentorLake.GLib.GBytesHandle ReadPixelBytes(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_read_pixel_bytes(pixbuf);
	}

	public static byte ReadPixels(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_read_pixels(pixbuf);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle Ref(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_ref(pixbuf);
	}

	public static bool RemoveOption(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_remove_option(pixbuf, key);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RotateSimple(this MentorLake.GdkPixbuf.GdkPixbufHandle src, MentorLake.GdkPixbuf.GdkPixbufRotation angle)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_rotate_simple(src, angle);
	}

	public static T SaturateAndPixelate<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, float saturation, bool pixelate) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_saturate_and_pixelate(src, dest, saturation, pixelate);
		return src;
	}

	public static bool Save(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, IntPtr error, IntPtr @__arglist)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save(pixbuf, filename, type, error, @__arglist);
	}

	public static bool SaveToBuffer(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out byte[] buffer, out UIntPtr buffer_size, string type, IntPtr error, IntPtr @__arglist)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_buffer(pixbuf, out buffer, out buffer_size, type, error, @__arglist);
	}

	public static bool SaveToBufferv(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out byte[] buffer, out UIntPtr buffer_size, string type, string[] option_keys, string[] option_values, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_bufferv(pixbuf, out buffer, out buffer_size, type, option_keys, option_values, error);
	}

	public static bool SaveToCallback(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, IntPtr error, IntPtr @__arglist)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_callback(pixbuf, save_func, user_data, type, error, @__arglist);
	}

	public static bool SaveToCallbackv(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_callbackv(pixbuf, save_func, user_data, type, option_keys, option_values, error);
	}

	public static bool SaveToStream(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, IntPtr @__arglist)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_stream(pixbuf, stream, type, cancellable, error, @__arglist);
	}

	public static T SaveToStreamAsync<T>(this T pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__arglist) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_save_to_stream_async(pixbuf, stream, type, cancellable, callback, user_data, @__arglist);
		return pixbuf;
	}

	public static bool SaveToStreamv(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_streamv(pixbuf, stream, type, option_keys, option_values, cancellable, error);
	}

	public static T SaveToStreamvAsync<T>(this T pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_save_to_streamv_async(pixbuf, stream, type, option_keys, option_values, cancellable, callback, user_data);
		return pixbuf;
	}

	public static bool Savev(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, IntPtr error)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_savev(pixbuf, filename, type, option_keys, option_values, error);
	}

	public static T Scale<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_scale(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type);
		return src;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle ScaleSimple(this MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_scale_simple(src, dest_width, dest_height, interp_type);
	}

	public static bool SetOption(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key, string value)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_set_option(pixbuf, key, value);
	}

	public static T Unref<T>(this T pixbuf) where T : GdkPixbufHandle
	{
		GdkPixbufHandleExterns.gdk_pixbuf_unref(pixbuf);
		return pixbuf;
	}

}

internal class GdkPixbufHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_data(char[] data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, MentorLake.GdkPixbuf.GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_file(string filename, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, bool preserve_aspect_ratio, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_inline(int data_length, byte[] data, bool copy_pixels, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_resource(string resource_path, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, bool preserve_aspect_ratio, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_stream_at_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_xpm_data(string[] data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_add_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool substitute_color, char r, char g, char b);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_apply_embedded_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_composite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_composite_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_composite_color_simple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_copy_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_copy_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, uint pixel);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_flip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, bool horizontal);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_bits_per_sample([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern UIntPtr gdk_pixbuf_get_byte_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkColorspace gdk_pixbuf_get_colorspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_get_has_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_n_channels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_pixbuf_get_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle gdk_pixbuf_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern char[] gdk_pixbuf_get_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern char[] gdk_pixbuf_get_pixels_with_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out uint length);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_rowstride([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_subpixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle gdk_pixbuf_read_pixel_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern byte gdk_pixbuf_read_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_remove_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_rotate_simple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, MentorLake.GdkPixbuf.GdkPixbufRotation angle);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_saturate_and_pixelate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, float saturation, bool pixelate);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out byte[] buffer, out UIntPtr buffer_size, string type, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_bufferv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out byte[] buffer, out UIntPtr buffer_size, string type, string[] option_keys, string[] option_values, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_callbackv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_save_to_stream_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_streamv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_save_to_streamv_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_savev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_scale_simple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_set_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key, string value);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_calculate_rowstride(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_get_file_info(string filename, out int width, out int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_get_file_info_async(string filename, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_get_file_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, out int width, out int height, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gdk_pixbuf_get_formats();

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_init_modules(string path, IntPtr error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_new_from_stream_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_new_from_stream_at_scale_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, IntPtr error);

}
