namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Result of JavaScript evaluation in a web view.
/// </para>
/// </summary>

public class WebKitJavascriptResultHandle : BaseSafeHandle
{
}


public static class WebKitJavascriptResultExtensions
{
/// <summary>
/// <para>
/// Get the global Javascript context.
/// </para>
/// <para>
/// Get the global Javascript context that should be used with the
/// &amp;lt;function&amp;gt;JSValueRef&amp;lt;/function&amp;gt; returned by webkit_javascript_result_get_value().
/// </para>
/// </summary>

/// <param name="js_result">
/// a #WebKitJavascriptResult
/// </param>
/// <return>
/// the &amp;lt;function&amp;gt;JSGlobalContextRef&amp;lt;/function&amp;gt; for the #WebKitJavascriptResult
/// </return>

	public static MentorLake.WebKit2.JSGlobalContextRef GetGlobalContext(this MentorLake.WebKit2.WebKitJavascriptResultHandle js_result)
	{
		if (js_result.IsInvalid) throw new Exception("Invalid handle (WebKitJavascriptResult)");
		return WebKitJavascriptResultExterns.webkit_javascript_result_get_global_context(js_result);
	}

/// <summary>
/// <para>
/// Get the #JSCValue of @js_result.
/// </para>
/// </summary>

/// <param name="js_result">
/// a #WebKitJavascriptResult
/// </param>
/// <return>
/// the #JSCValue of the #WebKitJavascriptResult
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle GetJsValue(this MentorLake.WebKit2.WebKitJavascriptResultHandle js_result)
	{
		if (js_result.IsInvalid) throw new Exception("Invalid handle (WebKitJavascriptResult)");
		return WebKitJavascriptResultExterns.webkit_javascript_result_get_js_value(js_result);
	}

/// <summary>
/// <para>
/// Get the value of @js_result.
/// </para>
/// <para>
/// You should use the &amp;lt;function&amp;gt;JSGlobalContextRef&amp;lt;/function&amp;gt;
/// returned by webkit_javascript_result_get_global_context() to use the &amp;lt;function&amp;gt;JSValueRef&amp;lt;/function&amp;gt;.
/// </para>
/// </summary>

/// <param name="js_result">
/// a #WebKitJavascriptResult
/// </param>
/// <return>
/// the &amp;lt;function&amp;gt;JSValueRef&amp;lt;/function&amp;gt; of the #WebKitJavascriptResult
/// </return>

	public static MentorLake.WebKit2.JSValueRef GetValue(this MentorLake.WebKit2.WebKitJavascriptResultHandle js_result)
	{
		if (js_result.IsInvalid) throw new Exception("Invalid handle (WebKitJavascriptResult)");
		return WebKitJavascriptResultExterns.webkit_javascript_result_get_value(js_result);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @js_result by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="js_result">
/// a #WebKitJavascriptResult
/// </param>
/// <return>
/// The passed in #WebKitJavascriptResult
/// </return>

	public static MentorLake.WebKit2.WebKitJavascriptResultHandle Ref(this MentorLake.WebKit2.WebKitJavascriptResultHandle js_result)
	{
		if (js_result.IsInvalid) throw new Exception("Invalid handle (WebKitJavascriptResult)");
		return WebKitJavascriptResultExterns.webkit_javascript_result_ref(js_result);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @js_result by one.
/// </para>
/// <para>
/// If the reference count drops to 0,
/// all memory allocated by the #WebKitJavascriptResult is
/// released. This function is MT-safe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="js_result">
/// a #WebKitJavascriptResult
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitJavascriptResultHandle js_result)
	{
		if (js_result.IsInvalid) throw new Exception("Invalid handle (WebKitJavascriptResult)");
		WebKitJavascriptResultExterns.webkit_javascript_result_unref(js_result);
	}


	public static WebKitJavascriptResult Dereference(this WebKitJavascriptResultHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitJavascriptResult>(x.DangerousGetHandle());
}
internal class WebKitJavascriptResultExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.JSGlobalContextRef webkit_javascript_result_get_global_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))] MentorLake.WebKit2.WebKitJavascriptResultHandle js_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle webkit_javascript_result_get_js_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))] MentorLake.WebKit2.WebKitJavascriptResultHandle js_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.JSValueRef webkit_javascript_result_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))] MentorLake.WebKit2.WebKitJavascriptResultHandle js_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))]
	internal static extern MentorLake.WebKit2.WebKitJavascriptResultHandle webkit_javascript_result_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))] MentorLake.WebKit2.WebKitJavascriptResultHandle js_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_javascript_result_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))] MentorLake.WebKit2.WebKitJavascriptResultHandle js_result);

}

/// <summary>
/// <para>
/// Result of JavaScript evaluation in a web view.
/// </para>
/// </summary>

public struct WebKitJavascriptResult
{
}
