namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Describes a first party origin.
/// </para>
/// </summary>

public class WebKitITPFirstPartyHandle : BaseSafeHandle
{
}


public static class WebKitITPFirstPartyExtensions
{
/// <summary>
/// <para>
/// Get the domain name of @itp_first_party.
/// </para>
/// </summary>

/// <param name="itp_first_party">
/// a #WebKitITPFirstParty
/// </param>
/// <return>
/// the domain name
/// </return>

	public static string GetDomain(this MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party)
	{
		if (itp_first_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPFirstParty)");
		return WebKitITPFirstPartyExterns.webkit_itp_first_party_get_domain(itp_first_party);
	}

/// <summary>
/// <para>
/// Get the last time a #WebKitITPThirdParty has been seen under @itp_first_party.
/// </para>
/// <para>
/// Each @WebKitITPFirstParty is created by webkit_itp_third_party_get_first_parties() and
/// therefore corresponds to exactly one #WebKitITPThirdParty.
/// </para>
/// </summary>

/// <param name="itp_first_party">
/// a #WebKitITPFirstParty
/// </param>
/// <return>
/// the last update time as a #GDateTime
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetLastUpdateTime(this MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party)
	{
		if (itp_first_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPFirstParty)");
		return WebKitITPFirstPartyExterns.webkit_itp_first_party_get_last_update_time(itp_first_party);
	}

/// <summary>
/// <para>
/// Get whether @itp_first_party has granted website data access to its #WebKitITPThirdParty.
/// </para>
/// <para>
/// Each @WebKitITPFirstParty is created by webkit_itp_third_party_get_first_parties() and
/// therefore corresponds to exactly one #WebKitITPThirdParty.
/// </para>
/// </summary>

/// <param name="itp_first_party">
/// a #WebKitITPFirstParty
/// </param>
/// <return>
/// %TRUE if website data access has been granted, or %FALSE otherwise
/// </return>

	public static bool GetWebsiteDataAccessAllowed(this MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party)
	{
		if (itp_first_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPFirstParty)");
		return WebKitITPFirstPartyExterns.webkit_itp_first_party_get_website_data_access_allowed(itp_first_party);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @itp_first_party by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="itp_first_party">
/// a #WebKitITPFirstParty
/// </param>
/// <return>
/// The passed #WebKitITPFirstParty
/// </return>

	public static MentorLake.WebKit2.WebKitITPFirstPartyHandle Ref(this MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party)
	{
		if (itp_first_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPFirstParty)");
		return WebKitITPFirstPartyExterns.webkit_itp_first_party_ref(itp_first_party);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @itp_first_party by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by
/// #WebKitITPFirstParty is released. This function is MT-safe and may be
/// called from any thread.
/// </para>
/// </summary>

/// <param name="itp_first_party">
/// a #WebKitITPFirstParty
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party)
	{
		if (itp_first_party.IsInvalid) throw new Exception("Invalid handle (WebKitITPFirstParty)");
		WebKitITPFirstPartyExterns.webkit_itp_first_party_unref(itp_first_party);
	}


	public static WebKitITPFirstParty Dereference(this WebKitITPFirstPartyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitITPFirstParty>(x.DangerousGetHandle());
}
internal class WebKitITPFirstPartyExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_itp_first_party_get_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPFirstPartyHandle>))] MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle webkit_itp_first_party_get_last_update_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPFirstPartyHandle>))] MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_itp_first_party_get_website_data_access_allowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPFirstPartyHandle>))] MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPFirstPartyHandle>))]
	internal static extern MentorLake.WebKit2.WebKitITPFirstPartyHandle webkit_itp_first_party_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPFirstPartyHandle>))] MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_itp_first_party_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitITPFirstPartyHandle>))] MentorLake.WebKit2.WebKitITPFirstPartyHandle itp_first_party);

}

/// <summary>
/// <para>
/// Describes a first party origin.
/// </para>
/// </summary>

public struct WebKitITPFirstParty
{
}
