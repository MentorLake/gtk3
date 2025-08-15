namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The class for #GTlsInteraction. Derived classes implement the various
/// virtual interaction methods to handle TLS interactions.
/// </para>
/// <para>
/// Derived classes can choose to implement whichever interactions methods they&apos;d
/// like to support by overriding those virtual methods in their class
/// initialization function. If a derived class implements an async method,
/// it must also implement the corresponding finish method.
/// </para>
/// <para>
/// The synchronous interaction methods should implement to display modal dialogs,
/// and the asynchronous methods to display modeless dialogs.
/// </para>
/// <para>
/// If the user cancels an interaction, then the result should be
/// %G_TLS_INTERACTION_FAILED and the error should be set with a domain of
/// %G_IO_ERROR and code of %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

public class GTlsInteractionClassHandle : BaseSafeHandle
{
}


public static class GTlsInteractionClassExtensions
{

	public static GTlsInteractionClass Dereference(this GTlsInteractionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsInteractionClass>(x.DangerousGetHandle());
}
internal class GTlsInteractionClassExterns
{
}

/// <summary>
/// <para>
/// The class for #GTlsInteraction. Derived classes implement the various
/// virtual interaction methods to handle TLS interactions.
/// </para>
/// <para>
/// Derived classes can choose to implement whichever interactions methods they&apos;d
/// like to support by overriding those virtual methods in their class
/// initialization function. If a derived class implements an async method,
/// it must also implement the corresponding finish method.
/// </para>
/// <para>
/// The synchronous interaction methods should implement to display modal dialogs,
/// and the asynchronous methods to display modeless dialogs.
/// </para>
/// <para>
/// If the user cancels an interaction, then the result should be
/// %G_TLS_INTERACTION_FAILED and the error should be set with a domain of
/// %G_IO_ERROR and code of %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

public struct GTlsInteractionClass
{
	/// <summary>
/// <para>
/// ask for a password synchronously. If the implementation
///     returns %G_TLS_INTERACTION_HANDLED, then the password argument should
///     have been filled in by using g_tls_password_set_value() or a similar
///     function.
/// </para>
/// </summary>

public IntPtr ask_password;
	/// <summary>
/// <para>
/// ask for a password asynchronously.
/// </para>
/// </summary>

public IntPtr ask_password_async;
	/// <summary>
/// <para>
/// complete operation to ask for a password asynchronously.
///     If the implementation returns %G_TLS_INTERACTION_HANDLED, then the
///     password argument of the async method should have been filled in by using
///     g_tls_password_set_value() or a similar function.
/// </para>
/// </summary>

public IntPtr ask_password_finish;
	/// <summary>
/// <para>
/// ask for a certificate synchronously. If the
///     implementation returns %G_TLS_INTERACTION_HANDLED, then the connection
///     argument should have been filled in by using
///     g_tls_connection_set_certificate().
/// </para>
/// </summary>

public IntPtr request_certificate;
	/// <summary>
/// <para>
/// ask for a certificate asynchronously.
/// </para>
/// </summary>

public IntPtr request_certificate_async;
	/// <summary>
/// <para>
/// complete operation to ask for a certificate
///     asynchronously. If the implementation returns %G_TLS_INTERACTION_HANDLED,
///     then the connection argument of the async method should have been
///     filled in by using g_tls_connection_set_certificate().
/// </para>
/// </summary>

public IntPtr request_certificate_finish;
}
