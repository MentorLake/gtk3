namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The GIConv struct wraps an iconv() conversion descriptor. It contains
/// private data and should only be accessed using the following functions.
/// </para>
/// </summary>

public class GIConvHandle : BaseSafeHandle
{
}


public static class GIConvExtensions
{
/// <summary>
/// <para>
/// Same as the standard UNIX routine iconv(), but
/// may be implemented via libiconv on UNIX flavors that lack
/// a native implementation.
/// </para>
/// <para>
/// GLib provides g_convert() and g_locale_to_utf8() which are likely
/// more convenient than the raw iconv wrappers.
/// </para>
/// <para>
/// Note that the behaviour of iconv() for characters which are valid in the
/// input character set, but which have no representation in the output character
/// set, is implementation defined. This function may return success (with a
/// positive number of non-reversible conversions as replacement characters were
/// used), or it may return -1 and set an error such as %EILSEQ, in such a
/// situation.
/// </para>
/// </summary>

/// <param name="converter">
/// conversion descriptor from g_iconv_open()
/// </param>
/// <param name="inbuf">
/// bytes to convert
/// </param>
/// <param name="inbytes_left">
/// inout parameter, bytes remaining to convert in @inbuf
/// </param>
/// <param name="outbuf">
/// converted output bytes
/// </param>
/// <param name="outbytes_left">
/// inout parameter, bytes available to fill in @outbuf
/// </param>
/// <return>
/// count of non-reversible conversions, or -1 on error
/// </return>

	public static UIntPtr GIconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left)
	{
		return GIConvExterns.g_iconv(converter, inbuf, ref inbytes_left, outbuf, ref outbytes_left);
	}

/// <summary>
/// <para>
/// Same as the standard UNIX routine iconv_close(), but
/// may be implemented via libiconv on UNIX flavors that lack
/// a native implementation. Should be called to clean up
/// the conversion descriptor from g_iconv_open() when
/// you are done converting things.
/// </para>
/// <para>
/// GLib provides g_convert() and g_locale_to_utf8() which are likely
/// more convenient than the raw iconv wrappers.
/// </para>
/// </summary>

/// <param name="converter">
/// a conversion descriptor from g_iconv_open()
/// </param>
/// <return>
/// -1 on error, 0 on success
/// </return>

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

/// <summary>
/// <para>
/// The GIConv struct wraps an iconv() conversion descriptor. It contains
/// private data and should only be accessed using the following functions.
/// </para>
/// </summary>

public struct GIConv
{
/// <summary>
/// <para>
/// Same as the standard UNIX routine iconv_open(), but
/// may be implemented via libiconv on UNIX flavors that lack
/// a native implementation.
/// </para>
/// <para>
/// GLib provides g_convert() and g_locale_to_utf8() which are likely
/// more convenient than the raw iconv wrappers.
/// </para>
/// </summary>

/// <param name="to_codeset">
/// destination codeset
/// </param>
/// <param name="from_codeset">
/// source codeset
/// </param>
/// <return>
/// a &quot;conversion descriptor&quot;, or (GIConv)-1 if
///  opening the converter failed.
/// </return>

	public static MentorLake.GLib.GIConv Open(string to_codeset, string from_codeset)
	{
		return GIConvExterns.g_iconv_open(to_codeset, from_codeset);
	}

}
