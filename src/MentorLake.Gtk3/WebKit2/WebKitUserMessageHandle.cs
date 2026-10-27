namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Message that can be sent between the UI process and web process extensions.
/// </para>
/// <para>
/// A WebKitUserMessage is a message that can be used for the communication between the UI process
/// and web process extensions. A WebKitUserMessage always has a name, and it can also include parameters and
/// UNIX file descriptors. Messages can be sent from a #WebKitWebContext to all web process extensions,
/// from a web process extension to its corresponding #WebKitWebContext, and from a #WebKitWebView to its
/// corresponding #WebKitWebPage (and vice versa). One to one messages can be replied to directly with
/// webkit_user_message_send_reply().
/// </para>
/// </summary>

public class WebKitUserMessageHandle : GInitiallyUnownedHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitUserMessage with @name.
/// </para>
/// </summary>

/// <param name="name">
/// the message name
/// </param>
/// <param name="parameters">
/// the message parameters as a #GVariant, or %NULL
/// </param>
/// <return>
/// the newly created #WebKitUserMessage object.
/// </return>

	public static MentorLake.WebKit2.WebKitUserMessageHandle New(string name, MentorLake.GLib.GVariantHandle parameters)
	{
		return WebKitUserMessageHandleExterns.webkit_user_message_new(name, parameters);
	}

/// <summary>
/// <para>
/// Create a new #WebKitUserMessage including also a list of UNIX file descriptors to be sent.
/// </para>
/// </summary>

/// <param name="name">
/// the message name
/// </param>
/// <param name="parameters">
/// the message parameters as a #GVariant
/// </param>
/// <param name="fd_list">
/// the message file descriptors
/// </param>
/// <return>
/// the newly created #WebKitUserMessage object.
/// </return>

	public static MentorLake.WebKit2.WebKitUserMessageHandle NewWithFdList(string name, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GUnixFDListHandle fd_list)
	{
		return WebKitUserMessageHandleExterns.webkit_user_message_new_with_fd_list(name, parameters, fd_list);
	}

}

public static class WebKitUserMessageHandleExtensions
{
/// <summary>
/// <para>
/// Get the @message list of file descritpor.
/// </para>
/// </summary>

/// <param name="message">
/// a #WebKitUserMessage
/// </param>
/// <return>
/// the message list of file descriptors
/// </return>

	public static MentorLake.Gio.GUnixFDListHandle GetFdList(this MentorLake.WebKit2.WebKitUserMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (WebKitUserMessageHandle)");
		return WebKitUserMessageHandleExterns.webkit_user_message_get_fd_list(message);
	}

/// <summary>
/// <para>
/// Get the @message name.
/// </para>
/// </summary>

/// <param name="message">
/// a #WebKitUserMessage
/// </param>
/// <return>
/// the message name
/// </return>

	public static string GetName(this MentorLake.WebKit2.WebKitUserMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (WebKitUserMessageHandle)");
		return WebKitUserMessageHandleExterns.webkit_user_message_get_name(message);
	}

/// <summary>
/// <para>
/// Get the @message parameters.
/// </para>
/// </summary>

/// <param name="message">
/// a #WebKitUserMessage
/// </param>
/// <return>
/// the message parameters
/// </return>

	public static MentorLake.GLib.GVariantHandle GetParameters(this MentorLake.WebKit2.WebKitUserMessageHandle message)
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (WebKitUserMessageHandle)");
		return WebKitUserMessageHandleExterns.webkit_user_message_get_parameters(message);
	}

/// <summary>
/// <para>
/// Send a reply to an user message.
/// </para>
/// <para>
/// If @reply is floating, it&apos;s consumed.
/// You can only send a reply to a #WebKitUserMessage that has been
/// received.
/// </para>
/// </summary>

/// <param name="message">
/// a #WebKitUserMessage
/// </param>
/// <param name="reply">
/// a #WebKitUserMessage to send as reply
/// </param>

	public static T SendReply<T>(this T message, MentorLake.WebKit2.WebKitUserMessageHandle reply) where T : WebKitUserMessageHandle
	{
		if (message.IsInvalid) throw new Exception("Invalid handle (WebKitUserMessageHandle)");
		WebKitUserMessageHandleExterns.webkit_user_message_send_reply(message, reply);
		return message;
	}

}

internal class WebKitUserMessageHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserMessageHandle webkit_user_message_new(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserMessageHandle webkit_user_message_new_with_fd_list(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))]
	internal static extern MentorLake.Gio.GUnixFDListHandle webkit_user_message_get_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_user_message_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle webkit_user_message_get_parameters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_message_send_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle reply);

}
