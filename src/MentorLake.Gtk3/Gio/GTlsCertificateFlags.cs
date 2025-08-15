namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A set of flags describing TLS certification validation. This can be
/// used to describe why a particular certificate was rejected (for
/// example, in #GTlsConnection::accept-certificate).
/// </para>
/// <para>
/// GLib guarantees that if certificate verification fails, at least one
/// flag will be set, but it does not guarantee that all possible flags
/// will be set. Accordingly, you may not safely decide to ignore any
/// particular type of error. For example, it would be incorrect to mask
/// %G_TLS_CERTIFICATE_EXPIRED if you want to allow expired certificates,
/// because this could potentially be the only error flag set even if
/// other problems exist with the certificate.
/// </para>
/// </summary>

[Flags]
public enum GTlsCertificateFlags : uint
{
/// <summary>
/// <para>
/// No flags set. Since: 2.74
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_NO_FLAGS = 0,
/// <summary>
/// <para>
/// The signing certificate authority is
///   not known.
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_UNKNOWN_CA = 1,
/// <summary>
/// <para>
/// The certificate does not match the
///   expected identity of the site that it was retrieved from.
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_BAD_IDENTITY = 2,
/// <summary>
/// <para>
/// The certificate&apos;s activation time
///   is still in the future
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_NOT_ACTIVATED = 4,
/// <summary>
/// <para>
/// The certificate has expired
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_EXPIRED = 8,
/// <summary>
/// <para>
/// The certificate has been revoked
///   according to the #GTlsConnection&apos;s certificate revocation list.
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_REVOKED = 16,
/// <summary>
/// <para>
/// The certificate&apos;s algorithm is
///   considered insecure.
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_INSECURE = 32,
/// <summary>
/// <para>
/// Some other error occurred validating
///   the certificate
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_GENERIC_ERROR = 64,
/// <summary>
/// <para>
/// the combination of all of the above
///   flags
/// </para>
/// </summary>

	G_TLS_CERTIFICATE_VALIDATE_ALL = 127
}
