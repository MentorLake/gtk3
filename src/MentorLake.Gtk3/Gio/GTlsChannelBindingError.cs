namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An error code used with %G_TLS_CHANNEL_BINDING_ERROR in a #GError to
/// indicate a TLS channel binding retrieval error.
/// </para>
/// </summary>

[Flags]
public enum GTlsChannelBindingError
{
/// <summary>
/// <para>
/// Either entire binding
///    retrieval facility or specific binding type is not implemented in the
///    TLS backend.
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_ERROR_NOT_IMPLEMENTED = 0,
/// <summary>
/// <para>
/// The handshake is not yet
///    complete on the connection which is a strong requirement for any existing
///    binding type.
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_ERROR_INVALID_STATE = 1,
/// <summary>
/// <para>
/// Handshake is complete but
///    binding data is not available. That normally indicates the TLS
///    implementation failed to provide the binding data. For example, some
///    implementations do not provide a peer certificate for resumed connections.
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_ERROR_NOT_AVAILABLE = 2,
/// <summary>
/// <para>
/// Binding type is not supported
///    on the current connection. This error could be triggered when requesting
///    `tls-server-end-point` binding data for a certificate which has no hash
///    function or uses multiple hash functions.
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_ERROR_NOT_SUPPORTED = 3,
/// <summary>
/// <para>
/// Any other backend error
///    preventing binding data retrieval.
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_ERROR_GENERAL_ERROR = 4
}
