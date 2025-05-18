namespace MentorLake.GdkPixdata;

public class GdkPixdataGlobalFunctions
{
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_from_pixdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, bool copy_pixels, out MentorLake.GLib.GErrorHandle error);

}
