namespace MentorLake.GdkPixdata;

public class GdkPixdataGlobalFunctions
{
/// <summary>
/// <para>
/// Converts a `GdkPixdata` to a `GdkPixbuf`.
/// </para>
/// <para>
/// If `copy_pixels` is `TRUE` or if the pixel data is run-length-encoded,
/// the pixel data is copied into newly-allocated memory; otherwise it is
/// reused.
/// </para>
/// </summary>

/// <param name="pixdata">
/// a #GdkPixdata to convert into a `GdkPixbuf`.
/// </param>
/// <param name="copy_pixels">
/// whether to copy raw pixel data; run-length encoded
///   pixel data is always copied.
/// </param>
/// <return>
/// a new pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle PixbufFromPixdata(MentorLake.GdkPixdata.GdkPixdataHandle pixdata, bool copy_pixels)
	{
		var externCallResult = GdkPixdataGlobalFunctionsExterns.gdk_pixbuf_from_pixdata(pixdata, copy_pixels, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GdkPixdataGlobalFunctionsExterns
{
	[DllImport(GdkPixdataLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_from_pixdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, bool copy_pixels, out MentorLake.GLib.GErrorHandle error);

}
