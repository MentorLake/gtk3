namespace MentorLake.Gtk3.GLib;

public class GIConvHandle : BaseSafeHandle
{
}


public static class GIConvHandleExtensions
{
	public static UIntPtr GIconv(GIConv converter, ref string inbuf, ref UIntPtr inbytes_left, ref string outbuf, ref UIntPtr outbytes_left)
	{
		return GIConvExterns.g_iconv(converter, ref inbuf, ref inbytes_left, ref outbuf, ref outbytes_left);
	}

	public static int GIconvClose(GIConv converter)
	{
		return GIConvExterns.g_iconv_close(converter);
	}

	public static GIConv GIconvOpen(string to_codeset, string from_codeset)
	{
		return GIConvExterns.g_iconv_open(to_codeset, from_codeset);
	}

}
internal class GIConvExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_iconv(GIConv converter, ref string inbuf, ref UIntPtr inbytes_left, ref string outbuf, ref UIntPtr outbytes_left);

	[DllImport(Libraries.GLib)]
	internal static extern int g_iconv_close(GIConv converter);

	[DllImport(Libraries.GLib)]
	internal static extern GIConv g_iconv_open(string to_codeset, string from_codeset);

}

public struct GIConv
{
}
