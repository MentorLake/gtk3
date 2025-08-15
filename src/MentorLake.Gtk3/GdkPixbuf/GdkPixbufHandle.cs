namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// A pixel buffer.
/// </para>
/// <para>
/// `GdkPixbuf` contains information about an image&apos;s pixel data,
/// its color space, bits per sample, width and height, and the
/// rowstride (the number of bytes between the start of one row
/// and the start of the next).
/// </para>
/// <para>
/// ## Creating new `GdkPixbuf`
/// </para>
/// <para>
/// The most basic way to create a pixbuf is to wrap an existing pixel
/// buffer with a [class@GdkPixbuf.Pixbuf] instance. You can use the
/// [`ctor@GdkPixbuf.Pixbuf.new_from_data`] function to do this.
/// </para>
/// <para>
/// Every time you create a new `GdkPixbuf` instance for some data, you
/// will need to specify the destroy notification function that will be
/// called when the data buffer needs to be freed; this will happen when
/// a `GdkPixbuf` is finalized by the reference counting functions. If
/// you have a chunk of static data compiled into your application, you
/// can pass in `NULL` as the destroy notification function so that the
/// data will not be freed.
/// </para>
/// <para>
/// The [`ctor@GdkPixbuf.Pixbuf.new`] constructor function can be used
/// as a convenience to create a pixbuf with an empty buffer; this is
/// equivalent to allocating a data buffer using `malloc()` and then
/// wrapping it with `gdk_pixbuf_new_from_data()`. The `gdk_pixbuf_new()`
/// function will compute an optimal rowstride so that rendering can be
/// performed with an efficient algorithm.
/// </para>
/// <para>
/// As a special case, you can use the [`ctor@GdkPixbuf.Pixbuf.new_from_xpm_data`]
/// function to create a pixbuf from inline XPM image data.
/// </para>
/// <para>
/// You can also copy an existing pixbuf with the [method@Pixbuf.copy]
/// function. This is not the same as just acquiring a reference to
/// the old pixbuf instance: the copy function will actually duplicate
/// the pixel data in memory and create a new [class@Pixbuf] instance
/// for it.
/// </para>
/// <para>
/// ## Reference counting
/// </para>
/// <para>
/// `GdkPixbuf` structures are reference counted. This means that an
/// application can share a single pixbuf among many parts of the
/// code. When a piece of the program needs to use a pixbuf, it should
/// acquire a reference to it by calling `g_object_ref()`; when it no
/// longer needs the pixbuf, it should release the reference it acquired
/// by calling `g_object_unref()`. The resources associated with a
/// `GdkPixbuf` will be freed when its reference count drops to zero.
/// Newly-created `GdkPixbuf` instances start with a reference count
/// of one.
/// </para>
/// <para>
/// ## Image Data
/// </para>
/// <para>
/// Image data in a pixbuf is stored in memory in an uncompressed,
/// packed format. Rows in the image are stored top to bottom, and
/// in each row pixels are stored from left to right.
/// </para>
/// <para>
/// There may be padding at the end of a row.
/// </para>
/// <para>
/// The &quot;rowstride&quot; value of a pixbuf, as returned by [`method@GdkPixbuf.Pixbuf.get_rowstride`],
/// indicates the number of bytes between rows.
/// </para>
/// <para>
/// **NOTE**: If you are copying raw pixbuf data with `memcpy()` note that the
/// last row in the pixbuf may not be as wide as the full rowstride, but rather
/// just as wide as the pixel data needs to be; that is: it is unsafe to do
/// `memcpy (dest, pixels, rowstride * height)` to copy a whole pixbuf. Use
/// [method@GdkPixbuf.Pixbuf.copy] instead, or compute the width in bytes of the
/// last row as:
/// </para>
/// <para>
/// ```c
/// last_row = width * ((n_channels * bits_per_sample + 7) / 8);
/// ```
/// </para>
/// <para>
/// The same rule applies when iterating over each row of a `GdkPixbuf` pixels
/// array.
/// </para>
/// <para>
/// The following code illustrates a simple `put_pixel()`
/// function for RGB pixbufs with 8 bits per channel with an alpha
/// channel.
/// </para>
/// <para>
/// ```c
/// static void
/// put_pixel (GdkPixbuf *pixbuf,
///            int x,
/// 	   int y,
/// 	   guchar red,
/// 	   guchar green,
/// 	   guchar blue,
/// 	   guchar alpha)
/// {
///   int n_channels = gdk_pixbuf_get_n_channels (pixbuf);
/// </para>
/// <para>
///   // Ensure that the pixbuf is valid
///   g_assert (gdk_pixbuf_get_colorspace (pixbuf) == GDK_COLORSPACE_RGB);
///   g_assert (gdk_pixbuf_get_bits_per_sample (pixbuf) == 8);
///   g_assert (gdk_pixbuf_get_has_alpha (pixbuf));
///   g_assert (n_channels == 4);
/// </para>
/// <para>
///   int width = gdk_pixbuf_get_width (pixbuf);
///   int height = gdk_pixbuf_get_height (pixbuf);
/// </para>
/// <para>
///   // Ensure that the coordinates are in a valid range
///   g_assert (x &amp;gt;= 0 &amp;&amp; x &amp;lt; width);
///   g_assert (y &amp;gt;= 0 &amp;&amp; y &amp;lt; height);
/// </para>
/// <para>
///   int rowstride = gdk_pixbuf_get_rowstride (pixbuf);
/// </para>
/// <para>
///   // The pixel buffer in the GdkPixbuf instance
///   guchar *pixels = gdk_pixbuf_get_pixels (pixbuf);
/// </para>
/// <para>
///   // The pixel we wish to modify
///   guchar *p = pixels + y * rowstride + x * n_channels;
///   p[0] = red;
///   p[1] = green;
///   p[2] = blue;
///   p[3] = alpha;
/// }
/// ```
/// </para>
/// <para>
/// ## Loading images
/// </para>
/// <para>
/// The `GdkPixBuf` class provides a simple mechanism for loading
/// an image from a file in synchronous and asynchronous fashion.
/// </para>
/// <para>
/// For GUI applications, it is recommended to use the asynchronous
/// stream API to avoid blocking the control flow of the application.
/// </para>
/// <para>
/// Additionally, `GdkPixbuf` provides the [class@GdkPixbuf.PixbufLoader`]
/// API for progressive image loading.
/// </para>
/// <para>
/// ## Saving images
/// </para>
/// <para>
/// The `GdkPixbuf` class provides methods for saving image data in
/// a number of file formats. The formatted data can be written to a
/// file or to a memory buffer. `GdkPixbuf` can also call a user-defined
/// callback on the data, which allows to e.g. write the image
/// to a socket or store it in a database.
/// </para>
/// </summary>

public class GdkPixbufHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
/// <summary>
/// <para>
/// Creates a new `GdkPixbuf` structure and allocates a buffer for it.
/// </para>
/// <para>
/// If the allocation of the buffer failed, this function will return `NULL`.
/// </para>
/// <para>
/// The buffer has an optimal rowstride. Note that the buffer is not cleared;
/// you will have to fill it completely yourself.
/// </para>
/// </summary>

/// <param name="colorspace">
/// Color space for image
/// </param>
/// <param name="has_alpha">
/// Whether the image should have transparency information
/// </param>
/// <param name="bits_per_sample">
/// Number of bits per color sample
/// </param>
/// <param name="width">
/// Width of image in pixels, must be &amp;gt; 0
/// </param>
/// <param name="height">
/// Height of image in pixels, must be &amp;gt; 0
/// </param>
/// <return>
/// A newly-created pixel buffer
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle New(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new(colorspace, has_alpha, bits_per_sample, width, height);
	}

/// <summary>
/// <para>
/// Creates a new #GdkPixbuf out of in-memory readonly image data.
/// </para>
/// <para>
/// Currently only RGB images with 8 bits per sample are supported.
/// </para>
/// <para>
/// This is the `GBytes` variant of gdk_pixbuf_new_from_data(), useful
/// for language bindings.
/// </para>
/// </summary>

/// <param name="data">
/// Image data in 8-bit/sample packed format inside a #GBytes
/// </param>
/// <param name="colorspace">
/// Colorspace for the image data
/// </param>
/// <param name="has_alpha">
/// Whether the data has an opacity channel
/// </param>
/// <param name="bits_per_sample">
/// Number of bits per sample
/// </param>
/// <param name="width">
/// Width of the image in pixels, must be &amp;gt; 0
/// </param>
/// <param name="height">
/// Height of the image in pixels, must be &amp;gt; 0
/// </param>
/// <param name="rowstride">
/// Distance in bytes between row starts
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromBytes(MentorLake.GLib.GBytesHandle data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_bytes(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride);
	}

/// <summary>
/// <para>
/// Creates a new #GdkPixbuf out of in-memory image data.
/// </para>
/// <para>
/// Currently only RGB images with 8 bits per sample are supported.
/// </para>
/// <para>
/// Since you are providing a pre-allocated pixel buffer, you must also
/// specify a way to free that data.  This is done with a function of
/// type `GdkPixbufDestroyNotify`.  When a pixbuf created with is
/// finalized, your destroy notification function will be called, and
/// it is its responsibility to free the pixel array.
/// </para>
/// <para>
/// See also: [ctor@GdkPixbuf.Pixbuf.new_from_bytes]
/// </para>
/// </summary>

/// <param name="data">
/// Image data in 8-bit/sample packed format
/// </param>
/// <param name="colorspace">
/// Colorspace for the image data
/// </param>
/// <param name="has_alpha">
/// Whether the data has an opacity channel
/// </param>
/// <param name="bits_per_sample">
/// Number of bits per sample
/// </param>
/// <param name="width">
/// Width of the image in pixels, must be &amp;gt; 0
/// </param>
/// <param name="height">
/// Height of the image in pixels, must be &amp;gt; 0
/// </param>
/// <param name="rowstride">
/// Distance in bytes between row starts
/// </param>
/// <param name="destroy_fn">
/// Function used to free the data when the pixbuf&apos;s reference count
/// drops to zero, or %NULL if the data should not be freed
/// </param>
/// <param name="destroy_fn_data">
/// Closure data to pass to the destroy notification function
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromData(byte[] data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, MentorLake.GdkPixbuf.GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_data(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride, destroy_fn, destroy_fn_data);
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from a file.
/// </para>
/// <para>
/// The file format is detected automatically.
/// </para>
/// <para>
/// If `NULL` is returned, then @error will be set. Possible errors are:
/// </para>
/// <para>
///  - the file could not be opened
///  - there is no loader for the file&apos;s format
///  - there is not enough memory to allocate the image buffer
///  - the image buffer contains invalid data
/// </para>
/// <para>
/// The error domains are `GDK_PIXBUF_ERROR` and `G_FILE_ERROR`.
/// </para>
/// </summary>

/// <param name="filename">
/// Name of file to load, in the GLib file
///   name encoding
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromFile(string filename)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_file(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from a file.
/// </para>
/// <para>
/// The file format is detected automatically.
/// </para>
/// <para>
/// If `NULL` is returned, then @error will be set. Possible errors are:
/// </para>
/// <para>
///  - the file could not be opened
///  - there is no loader for the file&apos;s format
///  - there is not enough memory to allocate the image buffer
///  - the image buffer contains invalid data
/// </para>
/// <para>
/// The error domains are `GDK_PIXBUF_ERROR` and `G_FILE_ERROR`.
/// </para>
/// <para>
/// The image will be scaled to fit in the requested size, optionally preserving
/// the image&apos;s aspect ratio.
/// </para>
/// <para>
/// When preserving the aspect ratio, a `width` of -1 will cause the image
/// to be scaled to the exact given height, and a `height` of -1 will cause
/// the image to be scaled to the exact given width. When not preserving
/// aspect ratio, a `width` or `height` of -1 means to not scale the image
/// at all in that dimension. Negative values for `width` and `height` are
/// allowed since 2.8.
/// </para>
/// </summary>

/// <param name="filename">
/// Name of file to load, in the GLib file
///     name encoding
/// </param>
/// <param name="width">
/// The width the image should have or -1 to not constrain the width
/// </param>
/// <param name="height">
/// The height the image should have or -1 to not constrain the height
/// </param>
/// <param name="preserve_aspect_ratio">
/// `TRUE` to preserve the image&apos;s aspect ratio
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromFileAtScale(string filename, int width, int height, bool preserve_aspect_ratio)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_file_at_scale(filename, width, height, preserve_aspect_ratio, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from a file.
/// </para>
/// <para>
/// The file format is detected automatically.
/// </para>
/// <para>
/// If `NULL` is returned, then @error will be set. Possible errors are:
/// </para>
/// <para>
///  - the file could not be opened
///  - there is no loader for the file&apos;s format
///  - there is not enough memory to allocate the image buffer
///  - the image buffer contains invalid data
/// </para>
/// <para>
/// The error domains are `GDK_PIXBUF_ERROR` and `G_FILE_ERROR`.
/// </para>
/// <para>
/// The image will be scaled to fit in the requested size, preserving
/// the image&apos;s aspect ratio. Note that the returned pixbuf may be smaller
/// than `width` x `height`, if the aspect ratio requires it. To load
/// and image at the requested size, regardless of aspect ratio, use
/// [ctor@GdkPixbuf.Pixbuf.new_from_file_at_scale].
/// </para>
/// </summary>

/// <param name="filename">
/// Name of file to load, in the GLib file
///     name encoding
/// </param>
/// <param name="width">
/// The width the image should have or -1 to not constrain the width
/// </param>
/// <param name="height">
/// The height the image should have or -1 to not constrain the height
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromFileAtSize(string filename, int width, int height)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_file_at_size(filename, width, height, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a `GdkPixbuf` from a flat representation that is suitable for
/// storing as inline data in a program.
/// </para>
/// <para>
/// This is useful if you want to ship a program with images, but don&apos;t want
/// to depend on any external files.
/// </para>
/// <para>
/// GdkPixbuf ships with a program called `gdk-pixbuf-csource`, which allows
/// for conversion of `GdkPixbuf`s into such a inline representation.
/// </para>
/// <para>
/// In almost all cases, you should pass the `--raw` option to
/// `gdk-pixbuf-csource`. A sample invocation would be:
/// </para>
/// <para>
/// ```
/// gdk-pixbuf-csource --raw --name=myimage_inline myimage.png
/// ```
/// </para>
/// <para>
/// For the typical case where the inline pixbuf is read-only static data,
/// you don&apos;t need to copy the pixel data unless you intend to write to
/// it, so you can pass `FALSE` for `copy_pixels`. If you pass `--rle` to
/// `gdk-pixbuf-csource`, a copy will be made even if `copy_pixels` is `FALSE`,
/// so using this option is generally a bad idea.
/// </para>
/// <para>
/// If you create a pixbuf from const inline data compiled into your
/// program, it&apos;s probably safe to ignore errors and disable length checks,
/// since things will always succeed:
/// </para>
/// <para>
/// ```c
/// pixbuf = gdk_pixbuf_new_from_inline (-1, myimage_inline, FALSE, NULL);
/// ```
/// </para>
/// <para>
/// For non-const inline data, you could get out of memory. For untrusted
/// inline data located at runtime, you could have corrupt inline data in
/// addition.
/// </para>
/// </summary>

/// <param name="data_length">
/// Length in bytes of the `data` argument or -1 to
///   disable length checks
/// </param>
/// <param name="data">
/// Byte data containing a
///   serialized `GdkPixdata` structure
/// </param>
/// <param name="copy_pixels">
/// Whether to copy the pixel data, or use direct pointers
///   `data` for the resulting pixbuf
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromInline(int data_length, byte[] data, bool copy_pixels)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_inline(data_length, data, copy_pixels, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from an resource.
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
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromResource(string resource_path)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_resource(resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from an resource.
/// </para>
/// <para>
/// The file format is detected automatically. If `NULL` is returned, then
/// @error will be set.
/// </para>
/// <para>
/// The image will be scaled to fit in the requested size, optionally
/// preserving the image&apos;s aspect ratio. When preserving the aspect ratio,
/// a @width of -1 will cause the image to be scaled to the exact given
/// height, and a @height of -1 will cause the image to be scaled to the
/// exact given width. When not preserving aspect ratio, a @width or
/// @height of -1 means to not scale the image at all in that dimension.
/// </para>
/// <para>
/// The stream is not closed.
/// </para>
/// </summary>

/// <param name="resource_path">
/// the path of the resource file
/// </param>
/// <param name="width">
/// The width the image should have or -1 to not constrain the width
/// </param>
/// <param name="height">
/// The height the image should have or -1 to not constrain the height
/// </param>
/// <param name="preserve_aspect_ratio">
/// `TRUE` to preserve the image&apos;s aspect ratio
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromResourceAtScale(string resource_path, int width, int height, bool preserve_aspect_ratio)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_resource_at_scale(resource_path, width, height, preserve_aspect_ratio, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from an input stream.
/// </para>
/// <para>
/// The file format is detected automatically.
/// </para>
/// <para>
/// If `NULL` is returned, then `error` will be set.
/// </para>
/// <para>
/// The `cancellable` can be used to abort the operation from another thread.
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
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromStream(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by loading an image from an input stream.
/// </para>
/// <para>
/// The file format is detected automatically. If `NULL` is returned, then
/// @error will be set. The @cancellable can be used to abort the operation
/// from another thread. If the operation was cancelled, the error
/// `G_IO_ERROR_CANCELLED` will be returned. Other possible errors are in
/// the `GDK_PIXBUF_ERROR` and `G_IO_ERROR` domains.
/// </para>
/// <para>
/// The image will be scaled to fit in the requested size, optionally
/// preserving the image&apos;s aspect ratio.
/// </para>
/// <para>
/// When preserving the aspect ratio, a `width` of -1 will cause the image to be
/// scaled to the exact given height, and a `height` of -1 will cause the image
/// to be scaled to the exact given width. If both `width` and `height` are
/// given, this function will behave as if the smaller of the two values
/// is passed as -1.
/// </para>
/// <para>
/// When not preserving aspect ratio, a `width` or `height` of -1 means to not
/// scale the image at all in that dimension.
/// </para>
/// <para>
/// The stream is not closed.
/// </para>
/// </summary>

/// <param name="stream">
/// a `GInputStream` to load the pixbuf from
/// </param>
/// <param name="width">
/// The width the image should have or -1 to not constrain the width
/// </param>
/// <param name="height">
/// The height the image should have or -1 to not constrain the height
/// </param>
/// <param name="preserve_aspect_ratio">
/// `TRUE` to preserve the image&apos;s aspect ratio
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromStreamAtScale(MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_at_scale(stream, width, height, preserve_aspect_ratio, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous pixbuf creation operation started with
/// gdk_pixbuf_new_from_stream_async().
/// </para>
/// </summary>

/// <param name="async_result">
/// a `GAsyncResult`
/// </param>
/// <return>
/// the newly created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_finish(async_result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by parsing XPM data in memory.
/// </para>
/// <para>
/// This data is commonly the result of including an XPM file into a
/// program&apos;s C source.
/// </para>
/// </summary>

/// <param name="data">
/// Pointer to inline XPM data.
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewFromXpmData(string[] data)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_new_from_xpm_data(data);
	}

/// <summary>
/// <para>
/// Calculates the rowstride that an image created with those values would
/// have.
/// </para>
/// <para>
/// This function is useful for front-ends and backends that want to check
/// image values without needing to create a `GdkPixbuf`.
/// </para>
/// </summary>

/// <param name="colorspace">
/// Color space for image
/// </param>
/// <param name="has_alpha">
/// Whether the image should have transparency information
/// </param>
/// <param name="bits_per_sample">
/// Number of bits per color sample
/// </param>
/// <param name="width">
/// Width of image in pixels, must be &amp;gt; 0
/// </param>
/// <param name="height">
/// Height of image in pixels, must be &amp;gt; 0
/// </param>
/// <return>
/// the rowstride for the given values, or -1 in case of error.
/// </return>

	public static int CalculateRowstride(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_calculate_rowstride(colorspace, has_alpha, bits_per_sample, width, height);
	}

/// <summary>
/// <para>
/// Parses an image file far enough to determine its format and size.
/// </para>
/// </summary>

/// <param name="filename">
/// The name of the file to identify.
/// </param>
/// <param name="width">
/// Return location for the width of the image
/// </param>
/// <param name="height">
/// Return location for the height of the image
/// </param>
/// <return>
/// A `GdkPixbufFormat` describing
///   the image format of the file
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle GetFileInfo(string filename, out int width, out int height)
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_file_info(filename, out width, out height);
	}

/// <summary>
/// <para>
/// Asynchronously parses an image file far enough to determine its
/// format and size.
/// </para>
/// <para>
/// For more details see gdk_pixbuf_get_file_info(), which is the synchronous
/// version of this function.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called in the
/// main thread. You can then call gdk_pixbuf_get_file_info_finish() to
/// get the result of the operation.
/// </para>
/// </summary>

/// <param name="filename">
/// The name of the file to identify
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <param name="callback">
/// a `GAsyncReadyCallback` to call when the file info is available
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static void GetFileInfoAsync(string filename, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufHandleExterns.gdk_pixbuf_get_file_info_async(filename, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes an asynchronous pixbuf parsing operation started with
/// gdk_pixbuf_get_file_info_async().
/// </para>
/// </summary>

/// <param name="async_result">
/// a `GAsyncResult`
/// </param>
/// <param name="width">
/// Return location for the width of the image, or `NULL`
/// </param>
/// <param name="height">
/// Return location for the height of the image, or `NULL`
/// </param>
/// <return>
/// A `GdkPixbufFormat` describing the
///   image format of the file
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle GetFileInfoFinish(MentorLake.Gio.GAsyncResultHandle async_result, out int width, out int height)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_get_file_info_finish(async_result, out width, out height, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains the available information about the image formats supported
/// by GdkPixbuf.
/// </para>
/// </summary>

/// <return>
/// A list of
///   support image formats.
/// </return>

	public static MentorLake.GLib.GSListHandle GetFormats()
	{
		return GdkPixbufHandleExterns.gdk_pixbuf_get_formats();
	}

/// <summary>
/// <para>
/// Initalizes the gdk-pixbuf loader modules referenced by the `loaders.cache`
/// file present inside that directory.
/// </para>
/// <para>
/// This is to be used by applications that want to ship certain loaders
/// in a different location from the system ones.
/// </para>
/// <para>
/// This is needed when the OS or runtime ships a minimal number of loaders
/// so as to reduce the potential attack surface of carefully crafted image
/// files, especially for uncommon file types. Applications that require
/// broader image file types coverage, such as image viewers, would be
/// expected to ship the gdk-pixbuf modules in a separate location, bundled
/// with the application in a separate directory from the OS or runtime-
/// provided modules.
/// </para>
/// </summary>

/// <param name="path">
/// Path to directory where the `loaders.cache` is installed
/// </param>

	public static bool InitModules(string path)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_init_modules(path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by asynchronously loading an image from an input stream.
/// </para>
/// <para>
/// For more details see gdk_pixbuf_new_from_stream(), which is the synchronous
/// version of this function.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called in the main thread.
/// You can then call gdk_pixbuf_new_from_stream_finish() to get the result of
/// the operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a `GInputStream` from which to load the pixbuf
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <param name="callback">
/// a `GAsyncReadyCallback` to call when the pixbuf is loaded
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static void NewFromStreamAsync(MentorLake.Gio.GInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_async(stream, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by asynchronously loading an image from an input stream.
/// </para>
/// <para>
/// For more details see gdk_pixbuf_new_from_stream_at_scale(), which is the synchronous
/// version of this function.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called in the main thread.
/// You can then call gdk_pixbuf_new_from_stream_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a `GInputStream` from which to load the pixbuf
/// </param>
/// <param name="width">
/// the width the image should have or -1 to not constrain the width
/// </param>
/// <param name="height">
/// the height the image should have or -1 to not constrain the height
/// </param>
/// <param name="preserve_aspect_ratio">
/// `TRUE` to preserve the image&apos;s aspect ratio
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <param name="callback">
/// a `GAsyncReadyCallback` to call when the pixbuf is loaded
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static void NewFromStreamAtScaleAsync(MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkPixbufHandleExterns.gdk_pixbuf_new_from_stream_at_scale_async(stream, width, height, preserve_aspect_ratio, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Finishes an asynchronous pixbuf save operation started with
/// gdk_pixbuf_save_to_stream_async().
/// </para>
/// </summary>

/// <param name="async_result">
/// a `GAsyncResult`
/// </param>
/// <return>
/// `TRUE` if the pixbuf was saved successfully, `FALSE` if an error was set.
/// </return>

	public static bool SaveToStreamFinish(MentorLake.Gio.GAsyncResultHandle async_result)
	{
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_save_to_stream_finish(async_result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GdkPixbufHandleExtensions
{
/// <summary>
/// <para>
/// Takes an existing pixbuf and adds an alpha channel to it.
/// </para>
/// <para>
/// If the existing pixbuf already had an alpha channel, the channel
/// values are copied from the original; otherwise, the alpha channel
/// is initialized to 255 (full opacity).
/// </para>
/// <para>
/// If `substitute_color` is `TRUE`, then the color specified by the
/// (`r`, `g`, `b`) arguments will be assigned zero opacity. That is,
/// if you pass `(255, 255, 255)` for the substitute color, all white
/// pixels will become fully transparent.
/// </para>
/// <para>
/// If `substitute_color` is `FALSE`, then the (`r`, `g`, `b`) arguments
/// will be ignored.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A #GdkPixbuf.
/// </param>
/// <param name="substitute_color">
/// Whether to set a color to zero opacity.
/// </param>
/// <param name="r">
/// Red value to substitute.
/// </param>
/// <param name="g">
/// Green value to substitute.
/// </param>
/// <param name="b">
/// Blue value to substitute.
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle AddAlpha(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool substitute_color, byte r, byte g, byte b)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_add_alpha(pixbuf, substitute_color, r, g, b);
	}

/// <summary>
/// <para>
/// Takes an existing pixbuf and checks for the presence of an
/// associated &quot;orientation&quot; option.
/// </para>
/// <para>
/// The orientation option may be provided by the JPEG loader (which
/// reads the exif orientation tag) or the TIFF loader (which reads
/// the TIFF orientation tag, and compensates it for the partial
/// transforms performed by libtiff).
/// </para>
/// <para>
/// If an orientation option/tag is present, the appropriate transform
/// will be performed so that the pixbuf is oriented correctly.
/// </para>
/// </summary>

/// <param name="src">
/// a pixbuf with an orientation option
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle ApplyEmbeddedOrientation(this MentorLake.GdkPixbuf.GdkPixbufHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_apply_embedded_orientation(src);
	}

/// <summary>
/// <para>
/// Creates a transformation of the source image @src by scaling by
/// @scale_x and @scale_y then translating by @offset_x and @offset_y.
/// </para>
/// <para>
/// This gives an image in the coordinates of the destination pixbuf.
/// The rectangle (@dest_x, @dest_y, @dest_width, @dest_height)
/// is then alpha blended onto the corresponding rectangle of the
/// original destination image.
/// </para>
/// <para>
/// When the destination rectangle contains parts not in the source
/// image, the data at the edges of the source image is replicated
/// to infinity.
/// </para>
/// <para>
/// ![](composite.png)
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="dest">
/// the #GdkPixbuf into which to render the results
/// </param>
/// <param name="dest_x">
/// the left coordinate for region to render
/// </param>
/// <param name="dest_y">
/// the top coordinate for region to render
/// </param>
/// <param name="dest_width">
/// the width of the region to render
/// </param>
/// <param name="dest_height">
/// the height of the region to render
/// </param>
/// <param name="offset_x">
/// the offset in the X direction (currently rounded to an integer)
/// </param>
/// <param name="offset_y">
/// the offset in the Y direction (currently rounded to an integer)
/// </param>
/// <param name="scale_x">
/// the scale factor in the X direction
/// </param>
/// <param name="scale_y">
/// the scale factor in the Y direction
/// </param>
/// <param name="interp_type">
/// the interpolation type for the transformation.
/// </param>
/// <param name="overall_alpha">
/// overall alpha for source image (0..255)
/// </param>

	public static T Composite<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha) where T : GdkPixbufHandle
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_composite(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha);
		return src;
	}

/// <summary>
/// <para>
/// Creates a transformation of the source image @src by scaling by
/// @scale_x and @scale_y then translating by @offset_x and @offset_y,
/// then alpha blends the rectangle (@dest_x ,@dest_y, @dest_width,
/// @dest_height) of the resulting image with a checkboard of the
/// colors @color1 and @color2 and renders it onto the destination
/// image.
/// </para>
/// <para>
/// If the source image has no alpha channel, and @overall_alpha is 255, a fast
/// path is used which omits the alpha blending and just performs the scaling.
/// </para>
/// <para>
/// See gdk_pixbuf_composite_color_simple() for a simpler variant of this
/// function suitable for many tasks.
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="dest">
/// the #GdkPixbuf into which to render the results
/// </param>
/// <param name="dest_x">
/// the left coordinate for region to render
/// </param>
/// <param name="dest_y">
/// the top coordinate for region to render
/// </param>
/// <param name="dest_width">
/// the width of the region to render
/// </param>
/// <param name="dest_height">
/// the height of the region to render
/// </param>
/// <param name="offset_x">
/// the offset in the X direction (currently rounded to an integer)
/// </param>
/// <param name="offset_y">
/// the offset in the Y direction (currently rounded to an integer)
/// </param>
/// <param name="scale_x">
/// the scale factor in the X direction
/// </param>
/// <param name="scale_y">
/// the scale factor in the Y direction
/// </param>
/// <param name="interp_type">
/// the interpolation type for the transformation.
/// </param>
/// <param name="overall_alpha">
/// overall alpha for source image (0..255)
/// </param>
/// <param name="check_x">
/// the X offset for the checkboard (origin of checkboard is at -@check_x, -@check_y)
/// </param>
/// <param name="check_y">
/// the Y offset for the checkboard
/// </param>
/// <param name="check_size">
/// the size of checks in the checkboard (must be a power of two)
/// </param>
/// <param name="color1">
/// the color of check at upper left
/// </param>
/// <param name="color2">
/// the color of the other check
/// </param>

	public static T CompositeColor<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2) where T : GdkPixbufHandle
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_composite_color(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha, check_x, check_y, check_size, color1, color2);
		return src;
	}

/// <summary>
/// <para>
/// Creates a new pixbuf by scaling `src` to `dest_width` x `dest_height`
/// and alpha blending the result with a checkboard of colors `color1`
/// and `color2`.
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="dest_width">
/// the width of destination image
/// </param>
/// <param name="dest_height">
/// the height of destination image
/// </param>
/// <param name="interp_type">
/// the interpolation type for the transformation.
/// </param>
/// <param name="overall_alpha">
/// overall alpha for source image (0..255)
/// </param>
/// <param name="check_size">
/// the size of checks in the checkboard (must be a power of two)
/// </param>
/// <param name="color1">
/// the color of check at upper left
/// </param>
/// <param name="color2">
/// the color of the other check
/// </param>
/// <return>
/// the new pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle CompositeColorSimple(this MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_composite_color_simple(src, dest_width, dest_height, interp_type, overall_alpha, check_size, color1, color2);
	}

/// <summary>
/// <para>
/// Creates a new `GdkPixbuf` with a copy of the information in the specified
/// `pixbuf`.
/// </para>
/// <para>
/// Note that this does not copy the options set on the original `GdkPixbuf`,
/// use gdk_pixbuf_copy_options() for this.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// A newly-created pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle Copy(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_copy(pixbuf);
	}

/// <summary>
/// <para>
/// Copies a rectangular area from `src_pixbuf` to `dest_pixbuf`.
/// </para>
/// <para>
/// Conversion of pixbuf formats is done automatically.
/// </para>
/// <para>
/// If the source rectangle overlaps the destination rectangle on the
/// same pixbuf, it will be overwritten during the copy operation.
/// Therefore, you can not use this function to scroll a pixbuf.
/// </para>
/// </summary>

/// <param name="src_pixbuf">
/// Source pixbuf.
/// </param>
/// <param name="src_x">
/// Source X coordinate within @src_pixbuf.
/// </param>
/// <param name="src_y">
/// Source Y coordinate within @src_pixbuf.
/// </param>
/// <param name="width">
/// Width of the area to copy.
/// </param>
/// <param name="height">
/// Height of the area to copy.
/// </param>
/// <param name="dest_pixbuf">
/// Destination pixbuf.
/// </param>
/// <param name="dest_x">
/// X coordinate within @dest_pixbuf.
/// </param>
/// <param name="dest_y">
/// Y coordinate within @dest_pixbuf.
/// </param>

	public static T CopyArea<T>(this T src_pixbuf, int src_x, int src_y, int width, int height, MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y) where T : GdkPixbufHandle
	{
		if (src_pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_copy_area(src_pixbuf, src_x, src_y, width, height, dest_pixbuf, dest_x, dest_y);
		return src_pixbuf;
	}

/// <summary>
/// <para>
/// Copies the key/value pair options attached to a `GdkPixbuf` to another
/// `GdkPixbuf`.
/// </para>
/// <para>
/// This is useful to keep original metadata after having manipulated
/// a file. However be careful to remove metadata which you&apos;ve already
/// applied, such as the &quot;orientation&quot; option after rotating the image.
/// </para>
/// </summary>

/// <param name="src_pixbuf">
/// the source pixbuf
/// </param>
/// <param name="dest_pixbuf">
/// the destination pixbuf
/// </param>
/// <return>
/// `TRUE` on success.
/// </return>

	public static bool CopyOptions(this MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf)
	{
		if (src_pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_copy_options(src_pixbuf, dest_pixbuf);
	}

/// <summary>
/// <para>
/// Clears a pixbuf to the given RGBA value, converting the RGBA value into
/// the pixbuf&apos;s pixel format.
/// </para>
/// <para>
/// The alpha component will be ignored if the pixbuf doesn&apos;t have an alpha
/// channel.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="pixel">
/// RGBA pixel to used to clear (`0xffffffff` is opaque white,
///   `0x00000000` transparent black)
/// </param>

	public static T Fill<T>(this T pixbuf, uint pixel) where T : GdkPixbufHandle
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_fill(pixbuf, pixel);
		return pixbuf;
	}

/// <summary>
/// <para>
/// Flips a pixbuf horizontally or vertically and returns the
/// result in a new pixbuf.
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="horizontal">
/// `TRUE` to flip horizontally, `FALSE` to flip vertically
/// </param>
/// <return>
/// the new pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle Flip(this MentorLake.GdkPixbuf.GdkPixbufHandle src, bool horizontal)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_flip(src, horizontal);
	}

/// <summary>
/// <para>
/// Queries the number of bits per color sample in a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// Number of bits per color sample.
/// </return>

	public static int GetBitsPerSample(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_bits_per_sample(pixbuf);
	}

/// <summary>
/// <para>
/// Returns the length of the pixel data, in bytes.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf
/// </param>
/// <return>
/// The length of the pixel data.
/// </return>

	public static UIntPtr GetByteLength(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_byte_length(pixbuf);
	}

/// <summary>
/// <para>
/// Queries the color space of a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// Color space.
/// </return>

	public static MentorLake.GdkPixbuf.GdkColorspace GetColorspace(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_colorspace(pixbuf);
	}

/// <summary>
/// <para>
/// Queries whether a pixbuf has an alpha channel (opacity information).
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// `TRUE` if it has an alpha channel, `FALSE` otherwise.
/// </return>

	public static bool GetHasAlpha(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_has_alpha(pixbuf);
	}

/// <summary>
/// <para>
/// Queries the height of a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// Height in pixels.
/// </return>

	public static int GetHeight(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_height(pixbuf);
	}

/// <summary>
/// <para>
/// Queries the number of channels of a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// Number of channels.
/// </return>

	public static int GetNChannels(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_n_channels(pixbuf);
	}

/// <summary>
/// <para>
/// Looks up @key in the list of options that may have been attached to the
/// @pixbuf when it was loaded, or that may have been attached by another
/// function using gdk_pixbuf_set_option().
/// </para>
/// <para>
/// For instance, the ANI loader provides &quot;Title&quot; and &quot;Artist&quot; options.
/// The ICO, XBM, and XPM loaders provide &quot;x_hot&quot; and &quot;y_hot&quot; hot-spot
/// options for cursor definitions. The PNG loader provides the tEXt ancillary
/// chunk key/value pairs as options. Since 2.12, the TIFF and JPEG loaders
/// return an &quot;orientation&quot; option string that corresponds to the embedded
/// TIFF/Exif orientation tag (if present). Since 2.32, the TIFF loader sets
/// the &quot;multipage&quot; option string to &quot;yes&quot; when a multi-page TIFF is loaded.
/// Since 2.32 the JPEG and PNG loaders set &quot;x-dpi&quot; and &quot;y-dpi&quot; if the file
/// contains image density information in dots per inch.
/// Since 2.36.6, the JPEG loader sets the &quot;comment&quot; option with the comment
/// EXIF tag.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="key">
/// a nul-terminated string.
/// </param>
/// <return>
/// the value associated with `key`
/// </return>

	public static string GetOption(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_option(pixbuf, key);
	}

/// <summary>
/// <para>
/// Returns a `GHashTable` with a list of all the options that may have been
/// attached to the `pixbuf` when it was loaded, or that may have been
/// attached by another function using [method@GdkPixbuf.Pixbuf.set_option].
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <return>
/// a #GHashTable
///   of key/values pairs
/// </return>

	public static MentorLake.GLib.GHashTableHandle GetOptions(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_options(pixbuf);
	}

/// <summary>
/// <para>
/// Queries a pointer to the pixel data of a pixbuf.
/// </para>
/// <para>
/// This function will cause an implicit copy of the pixbuf data if the
/// pixbuf was created from read-only data.
/// </para>
/// <para>
/// Please see the section on [image data](class.Pixbuf.html#image-data) for information
/// about how the pixel data is stored in memory.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// A pointer to the pixbuf&apos;s pixel data.
/// </return>

	public static byte[] GetPixels(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_pixels(pixbuf);
	}

/// <summary>
/// <para>
/// Queries a pointer to the pixel data of a pixbuf.
/// </para>
/// <para>
/// This function will cause an implicit copy of the pixbuf data if the
/// pixbuf was created from read-only data.
/// </para>
/// <para>
/// Please see the section on [image data](class.Pixbuf.html#image-data) for information
/// about how the pixel data is stored in memory.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <param name="length">
/// The length of the binary data.
/// </param>
/// <return>
/// A pointer to the pixbuf&apos;s
/// pixel data.
/// </return>

	public static byte[] GetPixelsWithLength(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out uint length)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_pixels_with_length(pixbuf, out length);
	}

/// <summary>
/// <para>
/// Queries the rowstride of a pixbuf, which is the number of bytes between
/// the start of a row and the start of the next row.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// Distance between row starts.
/// </return>

	public static int GetRowstride(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_rowstride(pixbuf);
	}

/// <summary>
/// <para>
/// Queries the width of a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// Width in pixels.
/// </return>

	public static int GetWidth(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_get_width(pixbuf);
	}

/// <summary>
/// <para>
/// Creates a new pixbuf which represents a sub-region of `src_pixbuf`.
/// </para>
/// <para>
/// The new pixbuf shares its pixels with the original pixbuf, so
/// writing to one affects both.  The new pixbuf holds a reference to
/// `src_pixbuf`, so `src_pixbuf` will not be finalized until the new
/// pixbuf is finalized.
/// </para>
/// <para>
/// Note that if `src_pixbuf` is read-only, this function will force it
/// to be mutable.
/// </para>
/// </summary>

/// <param name="src_pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="src_x">
/// X coord in @src_pixbuf
/// </param>
/// <param name="src_y">
/// Y coord in @src_pixbuf
/// </param>
/// <param name="width">
/// width of region in @src_pixbuf
/// </param>
/// <param name="height">
/// height of region in @src_pixbuf
/// </param>
/// <return>
/// a new pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle NewSubpixbuf(this MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height)
	{
		if (src_pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_new_subpixbuf(src_pixbuf, src_x, src_y, width, height);
	}

/// <summary>
/// <para>
/// Provides a #GBytes buffer containing the raw pixel data; the data
/// must not be modified.
/// </para>
/// <para>
/// This function allows skipping the implicit copy that must be made
/// if gdk_pixbuf_get_pixels() is called on a read-only pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf
/// </param>
/// <return>
/// A new reference to a read-only copy of
///   the pixel data.  Note that for mutable pixbufs, this function will
///   incur a one-time copy of the pixel data for conversion into the
///   returned #GBytes.
/// </return>

	public static MentorLake.GLib.GBytesHandle ReadPixelBytes(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_read_pixel_bytes(pixbuf);
	}

/// <summary>
/// <para>
/// Provides a read-only pointer to the raw pixel data.
/// </para>
/// <para>
/// This function allows skipping the implicit copy that must be made
/// if gdk_pixbuf_get_pixels() is called on a read-only pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf
/// </param>
/// <return>
/// a read-only pointer to the raw pixel data
/// </return>

	public static byte ReadPixels(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_read_pixels(pixbuf);
	}

/// <summary>
/// <para>
/// Adds a reference to a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>
/// <return>
/// The same as the @pixbuf argument.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle Ref(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_ref(pixbuf);
	}

/// <summary>
/// <para>
/// Removes the key/value pair option attached to a `GdkPixbuf`.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="key">
/// a nul-terminated string representing the key to remove.
/// </param>
/// <return>
/// `TRUE` if an option was removed, `FALSE` if not.
/// </return>

	public static bool RemoveOption(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_remove_option(pixbuf, key);
	}

/// <summary>
/// <para>
/// Rotates a pixbuf by a multiple of 90 degrees, and returns the
/// result in a new pixbuf.
/// </para>
/// <para>
/// If `angle` is 0, this function will return a copy of `src`.
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="angle">
/// the angle to rotate by
/// </param>
/// <return>
/// the new pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RotateSimple(this MentorLake.GdkPixbuf.GdkPixbufHandle src, MentorLake.GdkPixbuf.GdkPixbufRotation angle)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_rotate_simple(src, angle);
	}

/// <summary>
/// <para>
/// Modifies saturation and optionally pixelates `src`, placing the result in
/// `dest`.
/// </para>
/// <para>
/// The `src` and `dest` pixbufs must have the same image format, size, and
/// rowstride.
/// </para>
/// <para>
/// The `src` and `dest` arguments may be the same pixbuf with no ill effects.
/// </para>
/// <para>
/// If `saturation` is 1.0 then saturation is not changed. If it&apos;s less than 1.0,
/// saturation is reduced (the image turns toward grayscale); if greater than
/// 1.0, saturation is increased (the image gets more vivid colors).
/// </para>
/// <para>
/// If `pixelate` is `TRUE`, then pixels are faded in a checkerboard pattern to
/// create a pixelated image.
/// </para>
/// </summary>

/// <param name="src">
/// source image
/// </param>
/// <param name="dest">
/// place to write modified version of @src
/// </param>
/// <param name="saturation">
/// saturation factor
/// </param>
/// <param name="pixelate">
/// whether to pixelate
/// </param>

	public static T SaturateAndPixelate<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, float saturation, bool pixelate) where T : GdkPixbufHandle
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_saturate_and_pixelate(src, dest, saturation, pixelate);
		return src;
	}

/// <summary>
/// <para>
/// Saves pixbuf to a file in format @type. By default, &quot;jpeg&quot;, &quot;png&quot;, &quot;ico&quot;
/// and &quot;bmp&quot; are possible file formats to save in, but more formats may be
/// installed. The list of all writable formats can be determined in the
/// following way:
/// </para>
/// <para>
/// ```c
/// void add_if_writable (GdkPixbufFormat *data, GSList **list)
/// {
///   if (gdk_pixbuf_format_is_writable (data))
///     *list = g_slist_prepend (*list, data);
/// }
/// </para>
/// <para>
/// GSList *formats = gdk_pixbuf_get_formats ();
/// GSList *writable_formats = NULL;
/// g_slist_foreach (formats, add_if_writable, &amp;writable_formats);
/// g_slist_free (formats);
/// ```
/// </para>
/// <para>
/// If `error` is set, `FALSE` will be returned. Possible errors include
/// those in the `GDK_PIXBUF_ERROR` domain and those in the `G_FILE_ERROR`
/// domain.
/// </para>
/// <para>
/// The variable argument list should be `NULL`-terminated; if not empty,
/// it should contain pairs of strings that modify the save
/// parameters. For example:
/// </para>
/// <para>
/// ```c
/// gdk_pixbuf_save (pixbuf, handle, &quot;jpeg&quot;, &amp;error, &quot;quality&quot;, &quot;100&quot;, NULL);
/// ```
/// </para>
/// <para>
/// Currently only few parameters exist.
/// </para>
/// <para>
/// JPEG images can be saved with a &quot;quality&quot; parameter; its value should be
/// in the range `[0, 100]`. JPEG and PNG density can be set by setting the
/// &quot;x-dpi&quot; and &quot;y-dpi&quot; parameters to the appropriate values in dots per inch.
/// </para>
/// <para>
/// Text chunks can be attached to PNG images by specifying parameters of
/// the form &quot;tEXt::key&quot;, where key is an ASCII string of length 1-79.
/// The values are UTF-8 encoded strings. The PNG compression level can
/// be specified using the &quot;compression&quot; parameter; it&apos;s value is in an
/// integer in the range of `[0, 9]`.
/// </para>
/// <para>
/// ICC color profiles can also be embedded into PNG, JPEG and TIFF images.
/// The &quot;icc-profile&quot; value should be the complete ICC profile encoded
/// into base64.
/// </para>
/// <para>
/// ```c
/// char *contents;
/// gsize length;
/// </para>
/// <para>
/// // icm_path is set elsewhere
/// g_file_get_contents (icm_path, &amp;contents, &amp;length, NULL);
/// </para>
/// <para>
/// char *contents_encode = g_base64_encode ((const guchar *) contents, length);
/// </para>
/// <para>
/// gdk_pixbuf_save (pixbuf, handle, &quot;png&quot;, &amp;error, &quot;icc-profile&quot;, contents_encode, NULL);
/// ```
/// </para>
/// <para>
/// TIFF images recognize:
/// </para>
/// <para>
///  1. a &quot;bits-per-sample&quot; option (integer) which can be either 1 for saving
///     bi-level CCITTFAX4 images, or 8 for saving 8-bits per sample
///  2. a &quot;compression&quot; option (integer) which can be 1 for no compression,
///     2 for Huffman, 5 for LZW, 7 for JPEG and 8 for DEFLATE (see the libtiff
///     documentation and tiff.h for all supported codec values)
///  3. an &quot;icc-profile&quot; option (zero-terminated string) containing a base64
///     encoded ICC color profile.
/// </para>
/// <para>
/// ICO images can be saved in depth 16, 24, or 32, by using the &quot;depth&quot;
/// parameter. When the ICO saver is given &quot;x_hot&quot; and &quot;y_hot&quot; parameters,
/// it produces a CUR instead of an ICO.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`.
/// </param>
/// <param name="filename">
/// name of file to save.
/// </param>
/// <param name="type">
/// name of file format.
/// </param>
/// <param name="error">
/// return location for error
/// </param>
/// <param name="@__arglist">
/// list of key-value save options, followed by `NULL`
/// </param>
/// <return>
/// `TRUE` on success, and `FALSE` otherwise
/// </return>

	public static bool Save(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, IntPtr error, IntPtr @__arglist)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_save(pixbuf, filename, type, error, @__arglist);
	}

/// <summary>
/// <para>
/// Saves pixbuf to a new buffer in format `type`, which is currently &quot;jpeg&quot;,
/// &quot;png&quot;, &quot;tiff&quot;, &quot;ico&quot; or &quot;bmp&quot;.
/// </para>
/// <para>
/// This is a convenience function that uses `gdk_pixbuf_save_to_callback()`
/// to do the real work.
/// </para>
/// <para>
/// Note that the buffer is not `NUL`-terminated and may contain embedded `NUL`
/// characters.
/// </para>
/// <para>
/// If @error is set, `FALSE` will be returned and @buffer will be set to
/// `NULL`. Possible errors include those in the `GDK_PIXBUF_ERROR`
/// domain.
/// </para>
/// <para>
/// See `gdk_pixbuf_save()` for more details.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`.
/// </param>
/// <param name="buffer">
/// location to receive a pointer
///   to the new buffer.
/// </param>
/// <param name="buffer_size">
/// location to receive the size of the new buffer.
/// </param>
/// <param name="type">
/// name of file format.
/// </param>
/// <param name="error">
/// return location for error, or `NULL`
/// </param>
/// <param name="@__arglist">
/// list of key-value save options
/// </param>
/// <return>
/// whether an error was set
/// </return>

	public static bool SaveToBuffer(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out byte[] buffer, out UIntPtr buffer_size, string type, IntPtr error, IntPtr @__arglist)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_buffer(pixbuf, out buffer, out buffer_size, type, error, @__arglist);
	}

/// <summary>
/// <para>
/// Vector version of `gdk_pixbuf_save_to_buffer()`.
/// </para>
/// <para>
/// Saves pixbuf to a new buffer in format @type, which is currently &quot;jpeg&quot;,
/// &quot;tiff&quot;, &quot;png&quot;, &quot;ico&quot; or &quot;bmp&quot;.
/// </para>
/// <para>
/// See [method@GdkPixbuf.Pixbuf.save_to_buffer] for more details.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`.
/// </param>
/// <param name="buffer">
/// 
///   location to receive a pointer to the new buffer.
/// </param>
/// <param name="buffer_size">
/// location to receive the size of the new buffer.
/// </param>
/// <param name="type">
/// name of file format.
/// </param>
/// <param name="option_keys">
/// name of options to set
/// </param>
/// <param name="option_values">
/// values for named options
/// </param>
/// <return>
/// whether an error was set
/// </return>

	public static bool SaveToBufferv(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out byte[] buffer, out UIntPtr buffer_size, string type, string[] option_keys, string[] option_values)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_save_to_bufferv(pixbuf, out buffer, out buffer_size, type, option_keys, option_values, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Saves pixbuf in format `type` by feeding the produced data to a
/// callback.
/// </para>
/// <para>
/// This function can be used when you want to store the image to something
/// other than a file, such as an in-memory buffer or a socket.
/// </para>
/// <para>
/// If @error is set, `FALSE` will be returned. Possible errors
/// include those in the `GDK_PIXBUF_ERROR` domain and whatever the save
/// function generates.
/// </para>
/// <para>
/// See [method@GdkPixbuf.Pixbuf.save] for more details.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`.
/// </param>
/// <param name="save_func">
/// a function that is called to save each block of data that
///   the save routine generates.
/// </param>
/// <param name="user_data">
/// user data to pass to the save function.
/// </param>
/// <param name="type">
/// name of file format.
/// </param>
/// <param name="error">
/// return location for error, or `NULL`
/// </param>
/// <param name="@__arglist">
/// list of key-value save options
/// </param>
/// <return>
/// whether an error was set
/// </return>

	public static bool SaveToCallback(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, IntPtr error, IntPtr @__arglist)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_callback(pixbuf, save_func, user_data, type, error, @__arglist);
	}

/// <summary>
/// <para>
/// Vector version of `gdk_pixbuf_save_to_callback()`.
/// </para>
/// <para>
/// Saves pixbuf to a callback in format @type, which is currently &quot;jpeg&quot;,
/// &quot;png&quot;, &quot;tiff&quot;, &quot;ico&quot; or &quot;bmp&quot;.
/// </para>
/// <para>
/// If @error is set, `FALSE` will be returned.
/// </para>
/// <para>
/// See [method@GdkPixbuf.Pixbuf.save_to_callback] for more details.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`.
/// </param>
/// <param name="save_func">
/// a function that is called to save each block of data that
///   the save routine generates.
/// </param>
/// <param name="user_data">
/// user data to pass to the save function.
/// </param>
/// <param name="type">
/// name of file format.
/// </param>
/// <param name="option_keys">
/// name of options to set
/// </param>
/// <param name="option_values">
/// values for named options
/// </param>
/// <return>
/// whether an error was set
/// </return>

	public static bool SaveToCallbackv(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_save_to_callbackv(pixbuf, save_func, user_data, type, option_keys, option_values, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Saves `pixbuf` to an output stream.
/// </para>
/// <para>
/// Supported file formats are currently &quot;jpeg&quot;, &quot;tiff&quot;, &quot;png&quot;, &quot;ico&quot; or
/// &quot;bmp&quot;. See `gdk_pixbuf_save_to_buffer()` for more details.
/// </para>
/// <para>
/// The `cancellable` can be used to abort the operation from another
/// thread. If the operation was cancelled, the error `G_IO_ERROR_CANCELLED`
/// will be returned. Other possible errors are in the `GDK_PIXBUF_ERROR`
/// and `G_IO_ERROR` domains.
/// </para>
/// <para>
/// The stream is not closed at the end of this call.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="stream">
/// a `GOutputStream` to save the pixbuf to
/// </param>
/// <param name="type">
/// name of file format
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <param name="error">
/// return location for error, or `NULL`
/// </param>
/// <param name="@__arglist">
/// list of key-value save options
/// </param>
/// <return>
/// `TRUE` if the pixbuf was saved successfully, `FALSE` if an
///   error was set.
/// </return>

	public static bool SaveToStream(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, IntPtr @__arglist)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_save_to_stream(pixbuf, stream, type, cancellable, error, @__arglist);
	}

/// <summary>
/// <para>
/// Saves `pixbuf` to an output stream asynchronously.
/// </para>
/// <para>
/// For more details see gdk_pixbuf_save_to_stream(), which is the synchronous
/// version of this function.
/// </para>
/// <para>
/// When the operation is finished, `callback` will be called in the main thread.
/// </para>
/// <para>
/// You can then call gdk_pixbuf_save_to_stream_finish() to get the result of
/// the operation.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="stream">
/// a `GOutputStream` to which to save the pixbuf
/// </param>
/// <param name="type">
/// name of file format
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <param name="callback">
/// a `GAsyncReadyCallback` to call when the pixbuf is saved
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>
/// <param name="@__arglist">
/// list of key-value save options
/// </param>

	public static T SaveToStreamAsync<T>(this T pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__arglist) where T : GdkPixbufHandle
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_save_to_stream_async(pixbuf, stream, type, cancellable, callback, user_data, @__arglist);
		return pixbuf;
	}

/// <summary>
/// <para>
/// Saves `pixbuf` to an output stream.
/// </para>
/// <para>
/// Supported file formats are currently &quot;jpeg&quot;, &quot;tiff&quot;, &quot;png&quot;, &quot;ico&quot; or
/// &quot;bmp&quot;.
/// </para>
/// <para>
/// See [method@GdkPixbuf.Pixbuf.save_to_stream] for more details.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="stream">
/// a `GOutputStream` to save the pixbuf to
/// </param>
/// <param name="type">
/// name of file format
/// </param>
/// <param name="option_keys">
/// name of options to set
/// </param>
/// <param name="option_values">
/// values for named options
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <return>
/// `TRUE` if the pixbuf was saved successfully, `FALSE` if an
///   error was set.
/// </return>

	public static bool SaveToStreamv(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_save_to_streamv(pixbuf, stream, type, option_keys, option_values, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Saves `pixbuf` to an output stream asynchronously.
/// </para>
/// <para>
/// For more details see gdk_pixbuf_save_to_streamv(), which is the synchronous
/// version of this function.
/// </para>
/// <para>
/// When the operation is finished, `callback` will be called in the main thread.
/// </para>
/// <para>
/// You can then call gdk_pixbuf_save_to_stream_finish() to get the result of
/// the operation.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="stream">
/// a `GOutputStream` to which to save the pixbuf
/// </param>
/// <param name="type">
/// name of file format
/// </param>
/// <param name="option_keys">
/// name of options to set
/// </param>
/// <param name="option_values">
/// values for named options
/// </param>
/// <param name="cancellable">
/// optional `GCancellable` object, `NULL` to ignore
/// </param>
/// <param name="callback">
/// a `GAsyncReadyCallback` to call when the pixbuf is saved
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T SaveToStreamvAsync<T>(this T pixbuf, MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GdkPixbufHandle
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_save_to_streamv_async(pixbuf, stream, type, option_keys, option_values, cancellable, callback, user_data);
		return pixbuf;
	}

/// <summary>
/// <para>
/// Vector version of `gdk_pixbuf_save()`.
/// </para>
/// <para>
/// Saves pixbuf to a file in `type`, which is currently &quot;jpeg&quot;, &quot;png&quot;, &quot;tiff&quot;, &quot;ico&quot; or &quot;bmp&quot;.
/// </para>
/// <para>
/// If @error is set, `FALSE` will be returned.
/// </para>
/// <para>
/// See [method@GdkPixbuf.Pixbuf.save] for more details.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`.
/// </param>
/// <param name="filename">
/// name of file to save.
/// </param>
/// <param name="type">
/// name of file format.
/// </param>
/// <param name="option_keys">
/// name of options to set
/// </param>
/// <param name="option_values">
/// values for named options
/// </param>
/// <return>
/// whether an error was set
/// </return>

	public static bool Savev(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		var externCallResult = GdkPixbufHandleExterns.gdk_pixbuf_savev(pixbuf, filename, type, option_keys, option_values, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a transformation of the source image @src by scaling by
/// @scale_x and @scale_y then translating by @offset_x and @offset_y,
/// then renders the rectangle (@dest_x, @dest_y, @dest_width,
/// @dest_height) of the resulting image onto the destination image
/// replacing the previous contents.
/// </para>
/// <para>
/// Try to use gdk_pixbuf_scale_simple() first; this function is
/// the industrial-strength power tool you can fall back to, if
/// gdk_pixbuf_scale_simple() isn&apos;t powerful enough.
/// </para>
/// <para>
/// If the source rectangle overlaps the destination rectangle on the
/// same pixbuf, it will be overwritten during the scaling which
/// results in rendering artifacts.
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="dest">
/// the #GdkPixbuf into which to render the results
/// </param>
/// <param name="dest_x">
/// the left coordinate for region to render
/// </param>
/// <param name="dest_y">
/// the top coordinate for region to render
/// </param>
/// <param name="dest_width">
/// the width of the region to render
/// </param>
/// <param name="dest_height">
/// the height of the region to render
/// </param>
/// <param name="offset_x">
/// the offset in the X direction (currently rounded to an integer)
/// </param>
/// <param name="offset_y">
/// the offset in the Y direction (currently rounded to an integer)
/// </param>
/// <param name="scale_x">
/// the scale factor in the X direction
/// </param>
/// <param name="scale_y">
/// the scale factor in the Y direction
/// </param>
/// <param name="interp_type">
/// the interpolation type for the transformation.
/// </param>

	public static T Scale<T>(this T src, MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type) where T : GdkPixbufHandle
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_scale(src, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type);
		return src;
	}

/// <summary>
/// <para>
/// Create a new pixbuf containing a copy of `src` scaled to
/// `dest_width` x `dest_height`.
/// </para>
/// <para>
/// This function leaves `src` unaffected.
/// </para>
/// <para>
/// The `interp_type` should be `GDK_INTERP_NEAREST` if you want maximum
/// speed (but when scaling down `GDK_INTERP_NEAREST` is usually unusably
/// ugly). The default `interp_type` should be `GDK_INTERP_BILINEAR` which
/// offers reasonable quality and speed.
/// </para>
/// <para>
/// You can scale a sub-portion of `src` by creating a sub-pixbuf
/// pointing into `src`; see [method@GdkPixbuf.Pixbuf.new_subpixbuf].
/// </para>
/// <para>
/// If `dest_width` and `dest_height` are equal to the width and height of
/// `src`, this function will return an unscaled copy of `src`.
/// </para>
/// <para>
/// For more complicated scaling/alpha blending see [method@GdkPixbuf.Pixbuf.scale]
/// and [method@GdkPixbuf.Pixbuf.composite].
/// </para>
/// </summary>

/// <param name="src">
/// a #GdkPixbuf
/// </param>
/// <param name="dest_width">
/// the width of destination image
/// </param>
/// <param name="dest_height">
/// the height of destination image
/// </param>
/// <param name="interp_type">
/// the interpolation type for the transformation.
/// </param>
/// <return>
/// the new pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle ScaleSimple(this MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_scale_simple(src, dest_width, dest_height, interp_type);
	}

/// <summary>
/// <para>
/// Attaches a key/value pair as an option to a `GdkPixbuf`.
/// </para>
/// <para>
/// If `key` already exists in the list of options attached to the `pixbuf`,
/// the new value is ignored and `FALSE` is returned.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a `GdkPixbuf`
/// </param>
/// <param name="key">
/// a nul-terminated string.
/// </param>
/// <param name="value">
/// a nul-terminated string.
/// </param>
/// <return>
/// `TRUE` on success
/// </return>

	public static bool SetOption(this MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key, string value)
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		return GdkPixbufHandleExterns.gdk_pixbuf_set_option(pixbuf, key, value);
	}

/// <summary>
/// <para>
/// Removes a reference from a pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// A pixbuf.
/// </param>

	public static T Unref<T>(this T pixbuf) where T : GdkPixbufHandle
	{
		if (pixbuf.IsInvalid) throw new Exception("Invalid handle (GdkPixbufHandle)");
		GdkPixbufHandleExterns.gdk_pixbuf_unref(pixbuf);
		return pixbuf;
	}

}

internal class GdkPixbufHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_data(byte[] data, MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, MentorLake.GdkPixbuf.GdkPixbufDestroyNotify destroy_fn, IntPtr destroy_fn_data);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_file(string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, bool preserve_aspect_ratio, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_inline(int data_length, byte[] data, bool copy_pixels, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_resource(string resource_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, bool preserve_aspect_ratio, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_stream_at_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_from_xpm_data(string[] data);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_add_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool substitute_color, byte r, byte g, byte b);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_apply_embedded_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_composite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_composite_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_composite_color_simple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_copy_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf, int dest_x, int dest_y);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_copy_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest_pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, uint pixel);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle gdk_pixbuf_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern byte[] gdk_pixbuf_get_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern byte[] gdk_pixbuf_get_pixels_with_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, out uint length);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_rowstride([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_new_subpixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src_pixbuf, int src_x, int src_y, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle gdk_pixbuf_read_pixel_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern byte gdk_pixbuf_read_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_remove_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_rotate_simple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, MentorLake.GdkPixbuf.GdkPixbufRotation angle);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_saturate_and_pixelate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, float saturation, bool pixelate);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, out UIntPtr buffer_size, string type, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_bufferv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buffer, out UIntPtr buffer_size, string type, string[] option_keys, string[] option_values, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_callbackv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, MentorLake.GdkPixbuf.GdkPixbufSaveFunc save_func, IntPtr user_data, string type, string[] option_keys, string[] option_values, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_save_to_stream_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr @__arglist);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_streamv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_save_to_streamv_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle stream, string type, string[] option_keys, string[] option_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_savev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string filename, string type, string[] option_keys, string[] option_values, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, MentorLake.GdkPixbuf.GdkInterpType interp_type);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_scale_simple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle src, int dest_width, int dest_height, MentorLake.GdkPixbuf.GdkInterpType interp_type);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_set_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, string key, string value);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_calculate_rowstride(MentorLake.GdkPixbuf.GdkColorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_get_file_info(string filename, out int width, out int height);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_get_file_info_async(string filename, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_get_file_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, out int width, out int height, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gdk_pixbuf_get_formats();

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_init_modules(string path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_new_from_stream_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_new_from_stream_at_scale_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, int width, int height, bool preserve_aspect_ratio, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_save_to_stream_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle async_result, out MentorLake.GLib.GErrorHandle error);

}
