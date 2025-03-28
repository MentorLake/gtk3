namespace MentorLake.Gio;

public class GTlsInteractionHandle : GObjectHandle
{
}

public static class GTlsInteractionHandleExtensions
{
	public static MentorLake.Gio.GTlsInteractionResult AskPassword(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GTlsInteractionHandleExterns.g_tls_interaction_ask_password(interaction, password, cancellable, error);
	}

	public static T AskPasswordAsync<T>(this T interaction, MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsInteractionHandle
	{
		GTlsInteractionHandleExterns.g_tls_interaction_ask_password_async(interaction, password, cancellable, callback, user_data);
		return interaction;
	}

	public static MentorLake.Gio.GTlsInteractionResult AskPasswordFinish(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GTlsInteractionHandleExterns.g_tls_interaction_ask_password_finish(interaction, result, error);
	}

	public static MentorLake.Gio.GTlsInteractionResult InvokeAskPassword(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsPasswordHandle password, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GTlsInteractionHandleExterns.g_tls_interaction_invoke_ask_password(interaction, password, cancellable, error);
	}

	public static MentorLake.Gio.GTlsInteractionResult InvokeRequestCertificate(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GTlsInteractionHandleExterns.g_tls_interaction_invoke_request_certificate(interaction, connection, flags, cancellable, error);
	}

	public static MentorLake.Gio.GTlsInteractionResult RequestCertificate(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GTlsInteractionHandleExterns.g_tls_interaction_request_certificate(interaction, connection, flags, cancellable, error);
	}

	public static T RequestCertificateAsync<T>(this T interaction, MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsInteractionHandle
	{
		GTlsInteractionHandleExterns.g_tls_interaction_request_certificate_async(interaction, connection, flags, cancellable, callback, user_data);
		return interaction;
	}

	public static MentorLake.Gio.GTlsInteractionResult RequestCertificateFinish(this MentorLake.Gio.GTlsInteractionHandle interaction, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GTlsInteractionHandleExterns.g_tls_interaction_request_certificate_finish(interaction, result, error);
	}

}

internal class GTlsInteractionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_ask_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_interaction_ask_password_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_ask_password_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_invoke_ask_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle password, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_invoke_request_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_request_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_interaction_request_certificate_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle connection, MentorLake.Gio.GTlsCertificateRequestFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsInteractionResult g_tls_interaction_request_certificate_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

}
