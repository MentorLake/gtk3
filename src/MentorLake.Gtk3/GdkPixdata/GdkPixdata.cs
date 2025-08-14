namespace MentorLake.GdkPixdata;

/// <summary>
/// <para>
/// A pixel buffer suitable for serialization and streaming.
/// </para>
/// <para>
/// Using `GdkPixdata`, images can be compiled into an application,
/// making it unnecessary to refer to external image files at runtime.
/// </para>
/// <para>
/// `GdkPixbuf` includes a utility named `gdk-pixbuf-csource`, which
/// can be used to convert image files into `GdkPixdata` structures suitable
/// for inclusion in C sources. To convert the `GdkPixdata` structures back
/// into a `GdkPixbuf`, use `gdk_pixbuf_from_pixdata()`.
/// </para>
/// </summary>

public class GdkPixdataHandle : BaseSafeHandle
{
}


public static class GdkPixdataExtensions
{
/// <summary>
/// <para>
/// Deserializes (reconstruct) a #GdkPixdata structure from a byte stream.
/// </para>
/// <para>
/// The byte stream consists of a straightforward writeout of the
/// `GdkPixdata` fields in network byte order, plus the `pixel_data`
/// bytes the structure points to.
/// </para>
/// <para>
/// The `pixdata` contents are reconstructed byte by byte and are checked
/// for validity.
/// </para>
/// <para>
/// This function may fail with `GDK_PIXBUF_ERROR_CORRUPT_IMAGE`
/// or `GDK_PIXBUF_ERROR_UNKNOWN_TYPE`.
/// </para>
/// </summary>

/// <param name="pixdata">
/// a #GdkPixdata structure to be filled in.
/// </param>
/// <param name="stream_length">
/// length of the stream used for deserialization.
/// </param>
/// <param name="stream">
/// stream of bytes containing a
///   serialized #GdkPixdata structure.
/// </param>
/// <return>
/// Upon successful deserialization `TRUE` is returned,
/// `FALSE` otherwise.
/// </return>

	public static bool Deserialize(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, uint stream_length, byte[] stream)
	{
		if (pixdata.IsInvalid) throw new Exception("Invalid handle (GdkPixdata)");
		var externCallResult = GdkPixdataExterns.gdk_pixdata_deserialize(pixdata, stream_length, stream, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts a `GdkPixbuf` to a `GdkPixdata`.
/// </para>
/// <para>
/// If `use_rle` is `TRUE`, the pixel data is run-length encoded into
/// newly-allocated memory and a pointer to that memory is returned.
/// </para>
/// </summary>

/// <param name="pixdata">
/// a `GdkPixdata` to fill.
/// </param>
/// <param name="pixbuf">
/// the data to fill `pixdata` with.
/// </param>
/// <param name="use_rle">
/// whether to use run-length encoding for the pixel data.
/// </param>
/// <return>
/// If `use_rle` is
///   `TRUE`, a pointer to the newly-allocated memory for the run-length
///   encoded pixel data, otherwise `NULL`.
/// </return>

	public static byte[] FromPixbuf(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool use_rle)
	{
		if (pixdata.IsInvalid) throw new Exception("Invalid handle (GdkPixdata)");
		return GdkPixdataExterns.gdk_pixdata_from_pixbuf(pixdata, pixbuf, use_rle);
	}

/// <summary>
/// <para>
/// Serializes a #GdkPixdata structure into a byte stream.
/// The byte stream consists of a straightforward writeout of the
/// #GdkPixdata fields in network byte order, plus the @pixel_data
/// bytes the structure points to.
/// </para>
/// </summary>

/// <param name="pixdata">
/// a valid #GdkPixdata structure to serialize.
/// </param>
/// <param name="stream_length_p">
/// location to store the resulting stream length in.
/// </param>
/// <return>
/// A
/// newly-allocated string containing the serialized #GdkPixdata
/// structure.
/// </return>

	public static byte[] Serialize(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, out uint stream_length_p)
	{
		if (pixdata.IsInvalid) throw new Exception("Invalid handle (GdkPixdata)");
		return GdkPixdataExterns.gdk_pixdata_serialize(pixdata, out stream_length_p);
	}

/// <summary>
/// <para>
/// Generates C source code suitable for compiling images directly
/// into programs.
/// </para>
/// <para>
/// GdkPixbuf ships with a program called `gdk-pixbuf-csource`, which offers
/// a command line interface to this function.
/// </para>
/// </summary>

/// <param name="pixdata">
/// a `GdkPixdata` to convert to C source
/// </param>
/// <param name="name">
/// used for naming generated data structures or macros
/// </param>
/// <param name="dump_type">
/// the kind of C source to be generated
/// </param>
/// <return>
/// a newly-allocated string buffer containing
///   the C source form of `pixdata`.
/// </return>

	public static MentorLake.GLib.GStringHandle ToCsource(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, string name, MentorLake.GdkPixdata.GdkPixdataDumpType dump_type)
	{
		if (pixdata.IsInvalid) throw new Exception("Invalid handle (GdkPixdata)");
		return GdkPixdataExterns.gdk_pixdata_to_csource(pixdata, name, dump_type);
	}


	public static GdkPixdata Dereference(this GdkPixdataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixdata>(x.DangerousGetHandle());
}
internal class GdkPixdataExterns
{
	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern bool gdk_pixdata_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, uint stream_length, byte[] stream, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern byte[] gdk_pixdata_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool use_rle);

	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern byte[] gdk_pixdata_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, out uint stream_length_p);

	[DllImport(GdkPixdataLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle gdk_pixdata_to_csource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, string name, MentorLake.GdkPixdata.GdkPixdataDumpType dump_type);

}

/// <summary>
/// <para>
/// A pixel buffer suitable for serialization and streaming.
/// </para>
/// <para>
/// Using `GdkPixdata`, images can be compiled into an application,
/// making it unnecessary to refer to external image files at runtime.
/// </para>
/// <para>
/// `GdkPixbuf` includes a utility named `gdk-pixbuf-csource`, which
/// can be used to convert image files into `GdkPixdata` structures suitable
/// for inclusion in C sources. To convert the `GdkPixdata` structures back
/// into a `GdkPixbuf`, use `gdk_pixbuf_from_pixdata()`.
/// </para>
/// </summary>

public struct GdkPixdata
{
	/// <summary>
/// <para>
/// magic number. A valid `GdkPixdata` structure must have
///   `GDK_PIXBUF_MAGIC_NUMBER` here
/// </para>
/// </summary>

public uint magic;
	/// <summary>
/// <para>
/// less than 1 to disable length checks, otherwise
///   `GDK_PIXDATA_HEADER_LENGTH` plus the length of `pixel_data`
/// </para>
/// </summary>

public int length;
	/// <summary>
/// <para>
/// information about colorspace, sample width and
///   encoding, in a `GdkPixdataType`
/// </para>
/// </summary>

public uint pixdata_type;
	/// <summary>
/// <para>
/// Distance in bytes between rows
/// </para>
/// </summary>

public uint rowstride;
	/// <summary>
/// <para>
/// Width of the image in pixels
/// </para>
/// </summary>

public uint width;
	/// <summary>
/// <para>
/// Height of the image in pixels
/// </para>
/// </summary>

public uint height;
	/// <summary>
/// <para>
/// `width` x `height`
///   pixels, encoded according to `pixdata_type` and `rowstride`
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public byte[] pixel_data;
}
