namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Describes a third party origin.
/// </para>
/// </summary>

public class WebKitITPThirdPartyHandle : BaseSafeHandle
{
}


public static class WebKitITPThirdPartyExtensions
{
/// <summary>
/// <para>
/// Get the domain name of @itp_third_party.
/// </para>
/// </summary>

/// <param name="itp_third_party">
/// a #WebKitITPThirdParty
/// </param>
/// <return>
/// the domain name
/// </return>

	public static string GetDomain(this MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party)
	{
		if (itp_third_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPThirdParty)");
		return WebKitITPThirdPartyExterns.webkit_itp_third_party_get_domain(itp_third_party);
	}

/// <summary>
/// <para>
/// Get the list of #WebKitITPFirstParty under which @itp_third_party has been seen.
/// </para>
/// </summary>

/// <param name="itp_third_party">
/// a #WebKitITPThirdParty
/// </param>
/// <return>
/// a #GList of #WebKitITPFirstParty
/// </return>

	public static MentorLake.GLib.GListHandle GetFirstParties(this MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party)
	{
		if (itp_third_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPThirdParty)");
		return WebKitITPThirdPartyExterns.webkit_itp_third_party_get_first_parties(itp_third_party);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @itp_third_party by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="itp_third_party">
/// a #WebKitITPThirdParty
/// </param>
/// <return>
/// The passed #WebKitITPThirdParty
/// </return>

	public static MentorLake.WebKit2.WebKitITPThirdPartyHandle Ref(this MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party)
	{
		if (itp_third_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPThirdParty)");
		return WebKitITPThirdPartyExterns.webkit_itp_third_party_ref(itp_third_party);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @itp_third_party by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by
/// #WebKitITPThirdParty is released. This function is MT-safe and may be
/// called from any thread.
/// </para>
/// </summary>

/// <param name="itp_third_party">
/// a #WebKitITPThirdParty
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party)
	{
		if (itp_third_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPThirdParty)");
		WebKitITPThirdPartyExterns.webkit_itp_third_party_unref(itp_third_party);
	}


	public static WebKitITPThirdParty Dereference(this WebKitITPThirdPartyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitITPThirdParty>(x.DangerousGetHandle());
}
internal class WebKitITPThirdPartyExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_itp_third_party_get_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPThirdPartyHandle>))] MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_itp_third_party_get_first_parties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPThirdPartyHandle>))] MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPThirdPartyHandle>))]
	internal static extern MentorLake.WebKit2.WebKitITPThirdPartyHandle webkit_itp_third_party_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPThirdPartyHandle>))] MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_itp_third_party_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPThirdPartyHandle>))] MentorLake.WebKit2.WebKitITPThirdPartyHandle itp_third_party);

}

/// <summary>
/// <para>
/// Describes a third party origin.
/// </para>
/// </summary>

public struct WebKitITPThirdParty
{
}
