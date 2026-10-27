namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A JavaScript snippet which can be injected in loaded pages.
/// </para>
/// </summary>

public class WebKitUserScriptHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new user script.
/// </para>
/// <para>
/// Scripts can be applied to some URIs
/// only by passing non-null values for @allow_list or @block_list. Passing a
/// %NULL allow_list implies that all URIs are on the allow_list. The script
/// is applied if an URI matches the allow_list and not the block_list.
/// URI patterns must be of the form `[protocol]://[host]/[path]`, where the
/// *host* and *path* components can contain the wildcard character (`*`) to
/// represent zero or more other characters.
/// </para>
/// </summary>

/// <param name="source">
/// Source code of the user script.
/// </param>
/// <param name="injected_frames">
/// A #WebKitUserContentInjectedFrames value
/// </param>
/// <param name="injection_time">
/// A #WebKitUserScriptInjectionTime value
/// </param>
/// <param name="allow_list">
/// An allow_list of URI patterns or %NULL
/// </param>
/// <param name="block_list">
/// A block_list of URI patterns or %NULL
/// </param>
/// <return>
/// A new #WebKitUserScript
/// </return>

	public static MentorLake.WebKit2.WebKitUserScriptHandle New(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserScriptInjectionTime injection_time, string[] allow_list, string[] block_list)
	{
		return WebKitUserScriptExterns.webkit_user_script_new(source, injected_frames, injection_time, allow_list, block_list);
	}

/// <summary>
/// <para>
/// Creates a new user script for script world with name @world_name.
/// </para>
/// <para>
/// See webkit_user_script_new() for a full description.
/// </para>
/// </summary>

/// <param name="source">
/// Source code of the user script.
/// </param>
/// <param name="injected_frames">
/// A #WebKitUserContentInjectedFrames value
/// </param>
/// <param name="injection_time">
/// A #WebKitUserScriptInjectionTime value
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld
/// </param>
/// <param name="allow_list">
/// An allow_list of URI patterns or %NULL
/// </param>
/// <param name="block_list">
/// A block_list of URI patterns or %NULL
/// </param>
/// <return>
/// A new #WebKitUserScript
/// </return>

	public static MentorLake.WebKit2.WebKitUserScriptHandle NewForWorld(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserScriptInjectionTime injection_time, string world_name, string[] allow_list, string[] block_list)
	{
		return WebKitUserScriptExterns.webkit_user_script_new_for_world(source, injected_frames, injection_time, world_name, allow_list, block_list);
	}

}


public static class WebKitUserScriptExtensions
{
/// <summary>
/// <para>
/// Atomically increments the reference count of @user_script by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="user_script">
/// a #WebKitUserScript
/// </param>
/// <return>
/// The passed #WebKitUserScript
/// </return>

	public static MentorLake.WebKit2.WebKitUserScriptHandle Ref(this MentorLake.WebKit2.WebKitUserScriptHandle user_script)
	{
		if (user_script.IsInvalid) throw new Exception("Invalid handle (WebKitUserScript)");
		return WebKitUserScriptExterns.webkit_user_script_ref(user_script);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @user_script by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by
/// #WebKitUserScript is released. This function is MT-safe and may be called
/// from any thread.
/// </para>
/// </summary>

/// <param name="user_script">
/// a #WebKitUserScript
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitUserScriptHandle user_script)
	{
		if (user_script.IsInvalid) throw new Exception("Invalid handle (WebKitUserScript)");
		WebKitUserScriptExterns.webkit_user_script_unref(user_script);
	}


	public static WebKitUserScript Dereference(this WebKitUserScriptHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserScript>(x.DangerousGetHandle());
}
internal class WebKitUserScriptExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserScriptHandle webkit_user_script_new(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserScriptInjectionTime injection_time, string[] allow_list, string[] block_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserScriptHandle webkit_user_script_new_for_world(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserScriptInjectionTime injection_time, string world_name, string[] allow_list, string[] block_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserScriptHandle webkit_user_script_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))] MentorLake.WebKit2.WebKitUserScriptHandle user_script);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_script_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))] MentorLake.WebKit2.WebKitUserScriptHandle user_script);

}

/// <summary>
/// <para>
/// A JavaScript snippet which can be injected in loaded pages.
/// </para>
/// </summary>

public struct WebKitUserScript
{
}
