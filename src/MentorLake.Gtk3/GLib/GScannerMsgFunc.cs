namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the message handler function.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="message">
/// the message
/// </param>
/// <param name="error">
/// %TRUE if the message signals an error,
///     %FALSE if it signals a warning.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GScannerMsgFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, string message, bool error);
