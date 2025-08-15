namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface which provides access to streamable content.
/// </para>
/// <para>
/// An interface whereby an object allows its backing content to be
/// streamed to clients.  Typical implementors would be images or
/// icons, HTML content, or multimedia display/rendering widgets.
/// </para>
/// <para>
/// Negotiation of content type is allowed. Clients may examine the
/// backing data and transform, convert, or parse the content in order
/// to present it in an alternate form to end-users.
/// </para>
/// <para>
/// The AtkStreamableContent interface is particularly useful for
/// saving, printing, or post-processing entire documents, or for
/// persisting alternate views of a document. If document content
/// itself is being serialized, stored, or converted, then use of the
/// AtkStreamableContent interface can help address performance
/// issues. Unlike most ATK interfaces, this interface is not strongly
/// tied to the current user-agent view of the a particular document,
/// but may in some cases give access to the underlying model data.
/// </para>
/// </summary>

public interface AtkStreamableContentHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkStreamableContentHandleImpl : BaseSafeHandle, AtkStreamableContentHandle
{
}

public static class AtkStreamableContentHandleExtensions
{
/// <summary>
/// <para>
/// Gets the character string of the specified mime type. The first mime
/// type is at position 0, the second at position 1, and so on.
/// </para>
/// </summary>

/// <param name="streamable">
/// a GObject instance that implements AtkStreamableContent
/// </param>
/// <param name="i">
/// a gint representing the position of the mime type starting from 0
/// </param>
/// <return>
/// a gchar* representing the specified mime type; the caller
/// should not free the character string.
/// </return>

	public static string GetMimeType(this MentorLake.Atk.AtkStreamableContentHandle streamable, int i)
	{
		if (streamable.IsInvalid) throw new Exception("Invalid handle (AtkStreamableContentHandle)");
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_mime_type(streamable, i);
	}

/// <summary>
/// <para>
/// Gets the number of mime types supported by this object.
/// </para>
/// </summary>

/// <param name="streamable">
/// a GObject instance that implements AtkStreamableContentIface
/// </param>
/// <return>
/// a gint which is the number of mime types supported by the object.
/// </return>

	public static int GetNMimeTypes(this MentorLake.Atk.AtkStreamableContentHandle streamable)
	{
		if (streamable.IsInvalid) throw new Exception("Invalid handle (AtkStreamableContentHandle)");
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_n_mime_types(streamable);
	}

/// <summary>
/// <para>
/// Gets the content in the specified mime type.
/// </para>
/// </summary>

/// <param name="streamable">
/// a GObject instance that implements AtkStreamableContentIface
/// </param>
/// <param name="mime_type">
/// a gchar* representing the mime type
/// </param>
/// <return>
/// A #GIOChannel which contains the content in the
/// specified mime type.
/// </return>

	public static MentorLake.GLib.GIOChannelHandle GetStream(this MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type)
	{
		if (streamable.IsInvalid) throw new Exception("Invalid handle (AtkStreamableContentHandle)");
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_stream(streamable, mime_type);
	}

/// <summary>
/// <para>
/// Get a string representing a URI in IETF standard format
/// (see http://www.ietf.org/rfc/rfc2396.txt) from which the object&apos;s content
/// may be streamed in the specified mime-type, if one is available.
/// If mime_type is NULL, the URI for the default (and possibly only) mime-type is
/// returned.
/// </para>
/// <para>
/// Note that it is possible for get_uri to return NULL but for
/// get_stream to work nonetheless, since not all GIOChannels connect to URIs.
/// </para>
/// </summary>

/// <param name="streamable">
/// a GObject instance that implements AtkStreamableContentIface
/// </param>
/// <param name="mime_type">
/// a gchar* representing the mime type, or NULL to request a URI
/// for the default mime type.
/// </param>
/// <return>
/// Returns a string representing a URI, or %NULL
/// if no corresponding URI can be constructed.
/// </return>

	public static string GetUri(this MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type)
	{
		if (streamable.IsInvalid) throw new Exception("Invalid handle (AtkStreamableContentHandle)");
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_uri(streamable, mime_type);
	}

}

internal class AtkStreamableContentHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_streamable_content_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_streamable_content_get_n_mime_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle atk_streamable_content_get_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_streamable_content_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type);

}
