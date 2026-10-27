namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Represents a multipart HTTP message body, parsed according to the
/// syntax of RFC 2046.
/// </para>
/// <para>
/// Of particular interest to HTTP are `multipart/byte-ranges` and
/// `multipart/form-data`,
/// </para>
/// <para>
/// Although the headers of a [struct@Multipart] body part will contain the
/// full headers from that body part, libsoup does not interpret them
/// according to MIME rules. For example, each body part is assumed to
/// have &quot;binary&quot; Content-Transfer-Encoding, even if its headers
/// explicitly state otherwise. In other words, don&apos;t try to use
/// [struct@Multipart] for handling real MIME multiparts.
/// </para>
/// </summary>

public class SoupMultipartHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new empty [struct@Multipart] with a randomly-generated
/// boundary string.
/// </para>
/// <para>
/// Note that @mime_type must be the full MIME type, including &quot;multipart/&quot;.
/// </para>
/// <para>
/// See also: [ctor@Message.new_from_multipart].
/// </para>
/// </summary>

/// <param name="mime_type">
/// the MIME type of the multipart to create.
/// </param>
/// <return>
/// a new empty #SoupMultipart of the given @mime_type
/// </return>

	public static MentorLake.Soup.SoupMultipartHandle New(string mime_type)
	{
		return SoupMultipartExterns.soup_multipart_new(mime_type);
	}

/// <summary>
/// <para>
/// Parses @headers and @body to form a new [struct@Multipart]
/// </para>
/// </summary>

/// <param name="headers">
/// the headers of the HTTP message to parse
/// </param>
/// <param name="body">
/// the body of the HTTP message to parse
/// </param>
/// <return>
/// a new #SoupMultipart (or %NULL if the
///   message couldn&apos;t be parsed or wasn&apos;t multipart).
/// </return>

	public static MentorLake.Soup.SoupMultipartHandle NewFromMessage(MentorLake.Soup.SoupMessageHeadersHandle headers, MentorLake.GLib.GBytesHandle body)
	{
		return SoupMultipartExterns.soup_multipart_new_from_message(headers, body);
	}

}


public static class SoupMultipartExtensions
{
/// <summary>
/// <para>
/// Adds a new MIME part containing @body to @multipart
/// </para>
/// <para>
/// Uses &quot;Content-Disposition: form-data&quot;, as per the HTML forms specification.
/// </para>
/// </summary>

/// <param name="multipart">
/// a multipart (presumably of type &quot;multipart/form-data&quot;)
/// </param>
/// <param name="control_name">
/// the name of the control associated with this file
/// </param>
/// <param name="filename">
/// the name of the file, or %NULL if not known
/// </param>
/// <param name="content_type">
/// the MIME type of the file, or %NULL if not known
/// </param>
/// <param name="body">
/// the file data
/// </param>

	public static void AppendFormFile(this MentorLake.Soup.SoupMultipartHandle multipart, string control_name, string filename, string content_type, MentorLake.GLib.GBytesHandle body)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		SoupMultipartExterns.soup_multipart_append_form_file(multipart, control_name, filename, content_type, body);
	}

/// <summary>
/// <para>
/// Adds a new MIME part containing @data to @multipart.
/// </para>
/// <para>
/// Uses &quot;Content-Disposition: form-data&quot;, as per the HTML forms specification.
/// </para>
/// </summary>

/// <param name="multipart">
/// a multipart (presumably of type &quot;multipart/form-data&quot;)
/// </param>
/// <param name="control_name">
/// the name of the control associated with @data
/// </param>
/// <param name="data">
/// the body data
/// </param>

	public static void AppendFormString(this MentorLake.Soup.SoupMultipartHandle multipart, string control_name, string data)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		SoupMultipartExterns.soup_multipart_append_form_string(multipart, control_name, data);
	}

/// <summary>
/// <para>
/// Adds a new MIME part to @multipart with the given headers and body.
/// </para>
/// <para>
/// (The multipart will make its own copies of @headers and @body, so
/// you should free your copies if you are not using them for anything
/// else.)
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipart
/// </param>
/// <param name="headers">
/// the MIME part headers
/// </param>
/// <param name="body">
/// the MIME part body
/// </param>

	public static void AppendPart(this MentorLake.Soup.SoupMultipartHandle multipart, MentorLake.Soup.SoupMessageHeadersHandle headers, MentorLake.GLib.GBytesHandle body)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		SoupMultipartExterns.soup_multipart_append_part(multipart, headers, body);
	}

/// <summary>
/// <para>
/// Frees @multipart.
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipart
/// </param>

	public static void Free(this MentorLake.Soup.SoupMultipartHandle multipart)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		SoupMultipartExterns.soup_multipart_free(multipart);
	}

/// <summary>
/// <para>
/// Gets the number of body parts in @multipart.
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipart
/// </param>
/// <return>
/// the number of body parts in @multipart
/// </return>

	public static int GetLength(this MentorLake.Soup.SoupMultipartHandle multipart)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		return SoupMultipartExterns.soup_multipart_get_length(multipart);
	}

/// <summary>
/// <para>
/// Gets the indicated body part from @multipart.
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipart
/// </param>
/// <param name="part">
/// the part number to get (counting from 0)
/// </param>
/// <param name="headers">
/// return location for the MIME part
///   headers
/// </param>
/// <param name="body">
/// return location for the MIME part
///   body
/// </param>
/// <return>
/// %TRUE on success, %FALSE if @part is out of range (in
///   which case @headers and @body won&apos;t be set)
/// </return>

	public static bool GetPart(this MentorLake.Soup.SoupMultipartHandle multipart, int part, out MentorLake.Soup.SoupMessageHeadersHandle headers, out MentorLake.GLib.GBytesHandle body)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		return SoupMultipartExterns.soup_multipart_get_part(multipart, part, out headers, out body);
	}

/// <summary>
/// <para>
/// Serializes @multipart to @dest_headers and @dest_body.
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipart
/// </param>
/// <param name="dest_headers">
/// the headers of the HTTP message to serialize @multipart to
/// </param>
/// <param name="dest_body">
/// the body of the HTTP message to serialize @multipart to
/// </param>

	public static void ToMessage(this MentorLake.Soup.SoupMultipartHandle multipart, MentorLake.Soup.SoupMessageHeadersHandle dest_headers, out MentorLake.GLib.GBytesHandle dest_body)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipart)");
		SoupMultipartExterns.soup_multipart_to_message(multipart, dest_headers, out dest_body);
	}


	public static SoupMultipart Dereference(this SoupMultipartHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMultipart>(x.DangerousGetHandle());
}
internal class SoupMultipartExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))]
	internal static extern MentorLake.Soup.SoupMultipartHandle soup_multipart_new(string mime_type);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))]
	internal static extern MentorLake.Soup.SoupMultipartHandle soup_multipart_new_from_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle headers, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_multipart_append_form_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart, string control_name, string filename, string content_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_multipart_append_form_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart, string control_name, string data);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_multipart_append_part([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle headers, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_multipart_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart);

	[DllImport(SoupLibrary.Name)]
	internal static extern int soup_multipart_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_multipart_get_part([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart, int part, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] out MentorLake.Soup.SoupMessageHeadersHandle headers, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_multipart_to_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle dest_headers, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle dest_body);

}

/// <summary>
/// <para>
/// Represents a multipart HTTP message body, parsed according to the
/// syntax of RFC 2046.
/// </para>
/// <para>
/// Of particular interest to HTTP are `multipart/byte-ranges` and
/// `multipart/form-data`,
/// </para>
/// <para>
/// Although the headers of a [struct@Multipart] body part will contain the
/// full headers from that body part, libsoup does not interpret them
/// according to MIME rules. For example, each body part is assumed to
/// have &quot;binary&quot; Content-Transfer-Encoding, even if its headers
/// explicitly state otherwise. In other words, don&apos;t try to use
/// [struct@Multipart] for handling real MIME multiparts.
/// </para>
/// </summary>

public struct SoupMultipart
{
}
