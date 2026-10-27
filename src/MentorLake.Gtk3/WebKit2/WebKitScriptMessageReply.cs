namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A reply for a script message received.
/// If no reply has been sent by the user, an automatically generated reply with
/// undefined value with be sent.
/// </para>
/// </summary>

public class WebKitScriptMessageReplyHandle : BaseSafeHandle
{
}


public static class WebKitScriptMessageReplyExtensions
{
/// <summary>
/// <para>
/// Atomically increments the reference count of @script_message_reply by one.
/// </para>
/// </summary>

/// <param name="script_message_reply">
/// A #WebKitScriptMessageReply
/// </param>
/// <return>
/// the @script_message_reply passed in.
/// </return>

	public static MentorLake.WebKit2.WebKitScriptMessageReplyHandle Ref(this MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply)
	{
		if (script_message_reply.IsInvalid) throw new Exception("Invalid handle (WebKitScriptMessageReply)");
		return WebKitScriptMessageReplyExterns.webkit_script_message_reply_ref(script_message_reply);
	}

/// <summary>
/// <para>
/// Reply to a script message with an error message.
/// </para>
/// </summary>

/// <param name="script_message_reply">
/// A #WebKitScriptMessageReply
/// </param>
/// <param name="error_message">
/// An error message to return as specified by the user&apos;s script message
/// </param>

	public static void ReturnErrorMessage(this MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply, string error_message)
	{
		if (script_message_reply.IsInvalid) throw new Exception("Invalid handle (WebKitScriptMessageReply)");
		WebKitScriptMessageReplyExterns.webkit_script_message_reply_return_error_message(script_message_reply, error_message);
	}

/// <summary>
/// <para>
/// Reply to a script message with a value.
/// </para>
/// <para>
/// This function can be called twice for passing the reply value in.
/// </para>
/// </summary>

/// <param name="script_message_reply">
/// A #WebKitScriptMessageReply
/// </param>
/// <param name="reply_value">
/// Reply value of the provided script message
/// </param>

	public static void ReturnValue(this MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply, MentorLake.JavaScriptCore.JSCValueHandle reply_value)
	{
		if (script_message_reply.IsInvalid) throw new Exception("Invalid handle (WebKitScriptMessageReply)");
		WebKitScriptMessageReplyExterns.webkit_script_message_reply_return_value(script_message_reply, reply_value);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @script_message_reply by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all the memory allocated by the
/// #WebKitScriptMessageReply is released. This function is MT-safe and may
/// be called from any thread.
/// </para>
/// </summary>

/// <param name="script_message_reply">
/// A #WebKitScriptMessageReply
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply)
	{
		if (script_message_reply.IsInvalid) throw new Exception("Invalid handle (WebKitScriptMessageReply)");
		WebKitScriptMessageReplyExterns.webkit_script_message_reply_unref(script_message_reply);
	}


	public static WebKitScriptMessageReply Dereference(this WebKitScriptMessageReplyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitScriptMessageReply>(x.DangerousGetHandle());
}
internal class WebKitScriptMessageReplyExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptMessageReplyHandle>))]
	internal static extern MentorLake.WebKit2.WebKitScriptMessageReplyHandle webkit_script_message_reply_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptMessageReplyHandle>))] MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_message_reply_return_error_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptMessageReplyHandle>))] MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply, string error_message);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_message_reply_return_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptMessageReplyHandle>))] MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle reply_value);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_message_reply_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptMessageReplyHandle>))] MentorLake.WebKit2.WebKitScriptMessageReplyHandle script_message_reply);

}

/// <summary>
/// <para>
/// A reply for a script message received.
/// If no reply has been sent by the user, an automatically generated reply with
/// undefined value with be sent.
/// </para>
/// </summary>

public struct WebKitScriptMessageReply
{
}
