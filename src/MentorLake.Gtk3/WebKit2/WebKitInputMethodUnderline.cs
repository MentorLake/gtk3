namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Range of text in an preedit string to be shown underlined.
/// </para>
/// </summary>

public class WebKitInputMethodUnderlineHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitInputMethodUnderline for the given range in preedit string
/// </para>
/// </summary>

/// <param name="start_offset">
/// the start offset in preedit string
/// </param>
/// <param name="end_offset">
/// the end offset in preedit string
/// </param>
/// <return>
/// A newly created #WebKitInputMethodUnderline
/// </return>

	public static MentorLake.WebKit2.WebKitInputMethodUnderlineHandle New(uint start_offset, uint end_offset)
	{
		return WebKitInputMethodUnderlineExterns.webkit_input_method_underline_new(start_offset, end_offset);
	}

}


public static class WebKitInputMethodUnderlineExtensions
{
/// <summary>
/// <para>
/// Make a copy of the #WebKitInputMethodUnderline.
/// </para>
/// </summary>

/// <param name="underline">
/// a #WebKitInputMethodUnderline
/// </param>
/// <return>
/// A copy of passed in #WebKitInputMethodUnderline
/// </return>

	public static MentorLake.WebKit2.WebKitInputMethodUnderlineHandle Copy(this MentorLake.WebKit2.WebKitInputMethodUnderlineHandle underline)
	{
		if (underline.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodUnderline)");
		return WebKitInputMethodUnderlineExterns.webkit_input_method_underline_copy(underline);
	}

/// <summary>
/// <para>
/// Free the #WebKitInputMethodUnderline.
/// </para>
/// </summary>

/// <param name="underline">
/// A #WebKitInputMethodUnderline
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitInputMethodUnderlineHandle underline)
	{
		if (underline.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodUnderline)");
		WebKitInputMethodUnderlineExterns.webkit_input_method_underline_free(underline);
	}

/// <summary>
/// <para>
/// Set the color of the underline.
/// </para>
/// <para>
/// If @rgba is %NULL the foreground text color will be used
/// for the underline too.
/// </para>
/// </summary>

/// <param name="underline">
/// a #WebKitInputMethodUnderline
/// </param>
/// <param name="rgba">
/// a #GdkRGBA or %NULL
/// </param>

	public static void SetColor(this MentorLake.WebKit2.WebKitInputMethodUnderlineHandle underline, MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (underline.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodUnderline)");
		WebKitInputMethodUnderlineExterns.webkit_input_method_underline_set_color(underline, rgba);
	}


	public static WebKitInputMethodUnderline Dereference(this WebKitInputMethodUnderlineHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitInputMethodUnderline>(x.DangerousGetHandle());
}
internal class WebKitInputMethodUnderlineExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodUnderlineHandle>))]
	internal static extern MentorLake.WebKit2.WebKitInputMethodUnderlineHandle webkit_input_method_underline_new(uint start_offset, uint end_offset);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodUnderlineHandle>))]
	internal static extern MentorLake.WebKit2.WebKitInputMethodUnderlineHandle webkit_input_method_underline_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodUnderlineHandle>))] MentorLake.WebKit2.WebKitInputMethodUnderlineHandle underline);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_underline_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodUnderlineHandle>))] MentorLake.WebKit2.WebKitInputMethodUnderlineHandle underline);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_underline_set_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodUnderlineHandle>))] MentorLake.WebKit2.WebKitInputMethodUnderlineHandle underline, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

}

/// <summary>
/// <para>
/// Range of text in an preedit string to be shown underlined.
/// </para>
/// </summary>

public struct WebKitInputMethodUnderline
{
}
