namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Sniffs the mime type of messages.
/// </para>
/// <para>
/// A [class@ContentSniffer] tries to detect the actual content type of
/// the files that are being downloaded by looking at some of the data
/// before the [class@Message] emits its [signal@Message::got-headers] signal.
/// [class@ContentSniffer] implements [iface@SessionFeature], so you can add
/// content sniffing to a session with [method@Session.add_feature] or
/// [method@Session.add_feature_by_type].
/// </para>
/// </summary>

public class SoupContentSnifferHandle : GObjectHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a new [class@ContentSniffer].
/// </para>
/// </summary>

/// <return>
/// a new #SoupContentSniffer
/// </return>

	public static MentorLake.Soup.SoupContentSnifferHandle New()
	{
		return SoupContentSnifferHandleExterns.soup_content_sniffer_new();
	}

}

public static class SoupContentSnifferHandleExtensions
{
/// <summary>
/// <para>
/// Sniffs @buffer to determine its Content-Type.
/// </para>
/// <para>
/// The result may also be influenced by the Content-Type declared in @msg&apos;s
/// response headers.
/// </para>
/// </summary>

/// <param name="sniffer">
/// a #SoupContentSniffer
/// </param>
/// <param name="msg">
/// the message to sniff
/// </param>
/// <param name="buffer">
/// a buffer containing the start of @msg&apos;s response body
/// </param>
/// <param name="@params">
/// return
///   location for Content-Type parameters (eg, &quot;charset&quot;), or %NULL
/// </param>
/// <return>
/// the sniffed Content-Type of @buffer; this will never be %NULL,
///   but may be `application/octet-stream`.
/// </return>

	public static string Sniff(this MentorLake.Soup.SoupContentSnifferHandle sniffer, MentorLake.Soup.SoupMessageHandle msg, MentorLake.GLib.GBytesHandle buffer, out MentorLake.GLib.GHashTableHandle @params)
	{
		if (sniffer.IsInvalid) throw new Exception("Invalid handle (SoupContentSnifferHandle)");
		return SoupContentSnifferHandleExterns.soup_content_sniffer_sniff(sniffer, msg, buffer, out @params);
	}

}

internal class SoupContentSnifferHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupContentSnifferHandle>))]
	internal static extern MentorLake.Soup.SoupContentSnifferHandle soup_content_sniffer_new();

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_content_sniffer_sniff([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupContentSnifferHandle>))] MentorLake.Soup.SoupContentSnifferHandle sniffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] out MentorLake.GLib.GHashTableHandle @params);

}
