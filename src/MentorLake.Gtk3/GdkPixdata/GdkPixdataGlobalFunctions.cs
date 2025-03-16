namespace MentorLake.GdkPixdata;

public class GdkPixdataGlobalFunctions
{
	public static MentorLake.GdkPixbuf.GdkPixbufHandle PixbufFromPixdata(MentorLake.GdkPixdata.GdkPixdataHandle pixdata, bool copy_pixels)
	{
		return GdkPixdataGlobalFunctionsExterns.gdk_pixbuf_from_pixdata(pixdata, copy_pixels);
	}

}

internal class GdkPixdataGlobalFunctionsExterns
{
	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_from_pixdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, bool copy_pixels);

}
