namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Handles serialization of a web view&apos;s browsing state.
/// </para>
/// </summary>

public class WebKitWebViewSessionStateHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitWebViewSessionState from serialized data.
/// </para>
/// </summary>

/// <param name="data">
/// a #GBytes
/// </param>
/// <return>
/// a new #WebKitWebViewSessionState, or %NULL if @data doesn&apos;t contain a
///     valid serialized #WebKitWebViewSessionState.
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewSessionStateHandle New(MentorLake.GLib.GBytesHandle data)
	{
		return WebKitWebViewSessionStateExterns.webkit_web_view_session_state_new(data);
	}

}


public static class WebKitWebViewSessionStateExtensions
{
/// <summary>
/// <para>
/// Atomically increments the reference count of @state by one.
/// </para>
/// <para>
/// This
/// function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="state">
/// a #WebKitWebViewSessionState
/// </param>
/// <return>
/// The passed in #WebKitWebViewSessionState
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewSessionStateHandle Ref(this MentorLake.WebKit2.WebKitWebViewSessionStateHandle state)
	{
		if (state.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewSessionState)");
		return WebKitWebViewSessionStateExterns.webkit_web_view_session_state_ref(state);
	}

/// <summary>
/// <para>
/// Serializes a #WebKitWebViewSessionState.
/// </para>
/// </summary>

/// <param name="state">
/// a #WebKitWebViewSessionState
/// </param>
/// <return>
/// a #GBytes containing the @state serialized.
/// </return>

	public static MentorLake.GLib.GBytesHandle Serialize(this MentorLake.WebKit2.WebKitWebViewSessionStateHandle state)
	{
		if (state.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewSessionState)");
		return WebKitWebViewSessionStateExterns.webkit_web_view_session_state_serialize(state);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @state by one.
/// </para>
/// <para>
/// If the
/// reference count drops to 0, all memory allocated by the #WebKitWebViewSessionState is
/// released. This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="state">
/// a #WebKitWebViewSessionState
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitWebViewSessionStateHandle state)
	{
		if (state.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewSessionState)");
		WebKitWebViewSessionStateExterns.webkit_web_view_session_state_unref(state);
	}


	public static WebKitWebViewSessionState Dereference(this WebKitWebViewSessionStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebViewSessionState>(x.DangerousGetHandle());
}
internal class WebKitWebViewSessionStateExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewSessionStateHandle webkit_web_view_session_state_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewSessionStateHandle webkit_web_view_session_state_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))] MentorLake.WebKit2.WebKitWebViewSessionStateHandle state);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle webkit_web_view_session_state_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))] MentorLake.WebKit2.WebKitWebViewSessionStateHandle state);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_session_state_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))] MentorLake.WebKit2.WebKitWebViewSessionStateHandle state);

}

/// <summary>
/// <para>
/// Handles serialization of a web view&apos;s browsing state.
/// </para>
/// </summary>

public struct WebKitWebViewSessionState
{
}
