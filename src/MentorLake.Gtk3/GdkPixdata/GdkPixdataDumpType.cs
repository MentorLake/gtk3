namespace MentorLake.GdkPixdata;

/// <summary>
/// <para>
/// An enumeration which is used by gdk_pixdata_to_csource() to
/// determine the form of C source to be generated. The three values
/// @GDK_PIXDATA_DUMP_PIXDATA_STREAM, @GDK_PIXDATA_DUMP_PIXDATA_STRUCT
/// and @GDK_PIXDATA_DUMP_MACROS are mutually exclusive, as are
/// @GDK_PIXBUF_DUMP_GTYPES and @GDK_PIXBUF_DUMP_CTYPES. The remaining
/// elements are optional flags that can be freely added.
/// </para>
/// </summary>

[Flags]
public enum GdkPixdataDumpType : uint
{
/// <summary>
/// <para>
/// Generate pixbuf data stream (a single
///    string containing a serialized #GdkPixdata structure in network byte
///    order).
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_PIXDATA_STREAM = 0,
/// <summary>
/// <para>
/// Generate #GdkPixdata structure (needs
///    the #GdkPixdata structure definition from gdk-pixdata.h).
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_PIXDATA_STRUCT = 1,
/// <summary>
/// <para>
/// Generate &amp;lt;function&amp;gt;*_ROWSTRIDE&amp;lt;/function&amp;gt;,
///    &amp;lt;function&amp;gt;*_WIDTH&amp;lt;/function&amp;gt;, &amp;lt;function&amp;gt;*_HEIGHT&amp;lt;/function&amp;gt;,
///    &amp;lt;function&amp;gt;*_BYTES_PER_PIXEL&amp;lt;/function&amp;gt; and
///    &amp;lt;function&amp;gt;*_RLE_PIXEL_DATA&amp;lt;/function&amp;gt; or &amp;lt;function&amp;gt;*_PIXEL_DATA&amp;lt;/function&amp;gt;
///    macro definitions for the image.
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_MACROS = 2,
/// <summary>
/// <para>
/// Generate GLib data types instead of
///    standard C data types.
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_GTYPES = 0,
/// <summary>
/// <para>
/// Generate standard C data types instead of
///    GLib data types.
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_CTYPES = 256,
/// <summary>
/// <para>
/// Generate static symbols.
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_STATIC = 512,
/// <summary>
/// <para>
/// Generate const symbols.
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_CONST = 1024,
/// <summary>
/// <para>
/// Provide a &amp;lt;function&amp;gt;*_RUN_LENGTH_DECODE(image_buf, rle_data, size, bpp)&amp;lt;/function&amp;gt;
///    macro definition  to  decode  run-length encoded image data.
/// </para>
/// </summary>

	GDK_PIXDATA_DUMP_RLE_DECODER = 65536
}
