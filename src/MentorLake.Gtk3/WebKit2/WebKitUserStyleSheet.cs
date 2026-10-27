namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A CSS style sheet which can be injected in loaded pages.
/// </para>
/// </summary>

public class WebKitUserStyleSheetHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new user style sheet.
/// </para>
/// <para>
/// Style sheets can be applied to some URIs
/// only by passing non-null values for @allow_list or @block_list. Passing a
/// %NULL allow_list implies that all URIs are on the allow_list. The style
/// sheet is applied if an URI matches the allow_list and not the block_list.
/// URI patterns must be of the form `[protocol]://[host]/[path]`, where the
/// *host* and *path* components can contain the wildcard character (`*`) to
/// represent zero or more other characters.
/// </para>
/// </summary>

/// <param name="source">
/// Source code of the user style sheet.
/// </param>
/// <param name="injected_frames">
/// A #WebKitUserContentInjectedFrames value
/// </param>
/// <param name="level">
/// A #WebKitUserStyleLevel
/// </param>
/// <param name="allow_list">
/// An allow_list of URI patterns or %NULL
/// </param>
/// <param name="block_list">
/// A block_list of URI patterns or %NULL
/// </param>
/// <return>
/// A new #WebKitUserStyleSheet
/// </return>

	public static MentorLake.WebKit2.WebKitUserStyleSheetHandle New(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserStyleLevel level, string[] allow_list, string[] block_list)
	{
		return WebKitUserStyleSheetExterns.webkit_user_style_sheet_new(source, injected_frames, level, allow_list, block_list);
	}

/// <summary>
/// <para>
/// Creates a new user style sheet for script world.
/// </para>
/// <para>
/// Creates a new user style sheet for script world with name @world_name.
/// See webkit_user_style_sheet_new() for a full description.
/// </para>
/// </summary>

/// <param name="source">
/// Source code of the user style sheet.
/// </param>
/// <param name="injected_frames">
/// A #WebKitUserContentInjectedFrames value
/// </param>
/// <param name="level">
/// A #WebKitUserStyleLevel
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
/// A new #WebKitUserStyleSheet
/// </return>

	public static MentorLake.WebKit2.WebKitUserStyleSheetHandle NewForWorld(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserStyleLevel level, string world_name, string[] allow_list, string[] block_list)
	{
		return WebKitUserStyleSheetExterns.webkit_user_style_sheet_new_for_world(source, injected_frames, level, world_name, allow_list, block_list);
	}

}


public static class WebKitUserStyleSheetExtensions
{
/// <summary>
/// <para>
/// Atomically increments the reference count of @user_style_sheet by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="user_style_sheet">
/// a #WebKitUserStyleSheet
/// </param>
/// <return>
/// The passed #WebKitUserStyleSheet
/// </return>

	public static MentorLake.WebKit2.WebKitUserStyleSheetHandle Ref(this MentorLake.WebKit2.WebKitUserStyleSheetHandle user_style_sheet)
	{
		if (user_style_sheet.IsInvalid) throw new Exception("Invalid handle (WebKitUserStyleSheet)");
		return WebKitUserStyleSheetExterns.webkit_user_style_sheet_ref(user_style_sheet);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @user_style_sheet by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by
/// #WebKitUserStyleSheet is released. This function is MT-safe and may be
/// called from any thread.
/// </para>
/// </summary>

/// <param name="user_style_sheet">
/// a #WebKitUserStyleSheet
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitUserStyleSheetHandle user_style_sheet)
	{
		if (user_style_sheet.IsInvalid) throw new Exception("Invalid handle (WebKitUserStyleSheet)");
		WebKitUserStyleSheetExterns.webkit_user_style_sheet_unref(user_style_sheet);
	}


	public static WebKitUserStyleSheet Dereference(this WebKitUserStyleSheetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserStyleSheet>(x.DangerousGetHandle());
}
internal class WebKitUserStyleSheetExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserStyleSheetHandle webkit_user_style_sheet_new(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserStyleLevel level, string[] allow_list, string[] block_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserStyleSheetHandle webkit_user_style_sheet_new_for_world(string source, MentorLake.WebKit2.WebKitUserContentInjectedFrames injected_frames, MentorLake.WebKit2.WebKitUserStyleLevel level, string world_name, string[] allow_list, string[] block_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserStyleSheetHandle webkit_user_style_sheet_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))] MentorLake.WebKit2.WebKitUserStyleSheetHandle user_style_sheet);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_style_sheet_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))] MentorLake.WebKit2.WebKitUserStyleSheetHandle user_style_sheet);

}

/// <summary>
/// <para>
/// A CSS style sheet which can be injected in loaded pages.
/// </para>
/// </summary>

public struct WebKitUserStyleSheet
{
}
