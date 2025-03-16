namespace MentorLake.GdkPixdata;

public class GdkPixdataHandle : BaseSafeHandle
{
}


public static class GdkPixdataExtensions
{
	public static bool Deserialize(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, uint stream_length, byte[] stream)
	{
		return GdkPixdataExterns.gdk_pixdata_deserialize(pixdata, stream_length, stream);
	}

	public static byte[] FromPixbuf(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool use_rle)
	{
		return GdkPixdataExterns.gdk_pixdata_from_pixbuf(pixdata, pixbuf, use_rle);
	}

	public static byte[] Serialize(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, out uint stream_length_p)
	{
		return GdkPixdataExterns.gdk_pixdata_serialize(pixdata, out stream_length_p);
	}

	public static MentorLake.GLib.GStringHandle ToCsource(this MentorLake.GdkPixdata.GdkPixdataHandle pixdata, string name, MentorLake.GdkPixdata.GdkPixdataDumpType dump_type)
	{
		return GdkPixdataExterns.gdk_pixdata_to_csource(pixdata, name, dump_type);
	}


	public static GdkPixdata Dereference(this GdkPixdataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixdata>(x.DangerousGetHandle());
}
internal class GdkPixdataExterns
{
	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern bool gdk_pixdata_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, uint stream_length, byte[] stream);

	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern byte[] gdk_pixdata_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, bool use_rle);

	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern byte[] gdk_pixdata_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, out uint stream_length_p);

	[DllImport(GdkPixdataLibrary.Name)]
	internal static extern MentorLake.GLib.GStringHandle gdk_pixdata_to_csource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixdata.GdkPixdataHandle>))] MentorLake.GdkPixdata.GdkPixdataHandle pixdata, string name, MentorLake.GdkPixdata.GdkPixdataDumpType dump_type);

}

public struct GdkPixdata
{
	public uint magic;
	public int length;
	public uint pixdata_type;
	public uint rowstride;
	public uint width;
	public uint height;
	public byte[] pixel_data;
}
