namespace MentorLake.GLib;

public class GIConvHandle : BaseSafeHandle
{
}


public static class GIConvExtensions
{
	public static UIntPtr GIconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left)
	{
		return GIConvExterns.g_iconv(converter, inbuf, ref inbytes_left, outbuf, ref outbytes_left);
	}

	public static int Close(MentorLake.GLib.GIConv converter)
	{
		return GIConvExterns.g_iconv_close(converter);
	}


	public static GIConv Dereference(this GIConvHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIConv>(x.DangerousGetHandle());
}
internal class GIConvExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_iconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_iconv_close(MentorLake.GLib.GIConv converter);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIConv g_iconv_open(string to_codeset, string from_codeset);

}

public struct GIConv
{
	public static MentorLake.GLib.GIConv Open(string to_codeset, string from_codeset)
	{
		return GIConvExterns.g_iconv_open(to_codeset, from_codeset);
	}

}
