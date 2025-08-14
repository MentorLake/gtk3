namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Enumeration describing different kinds of native credential types.
/// </para>
/// </summary>

[Flags]
public enum GCredentialsType
{
/// <summary>
/// <para>
/// Indicates an invalid native credential type.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_INVALID = 0,
/// <summary>
/// <para>
/// The native credentials type is a `struct ucred`.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_LINUX_UCRED = 1,
/// <summary>
/// <para>
/// The native credentials type is a `struct cmsgcred`.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_FREEBSD_CMSGCRED = 2,
/// <summary>
/// <para>
/// The native credentials type is a `struct sockpeercred`. Added in 2.30.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_OPENBSD_SOCKPEERCRED = 3,
/// <summary>
/// <para>
/// The native credentials type is a `ucred_t`. Added in 2.40.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_SOLARIS_UCRED = 4,
/// <summary>
/// <para>
/// The native credentials type is a `struct unpcbid`. Added in 2.42.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_NETBSD_UNPCBID = 5,
/// <summary>
/// <para>
/// The native credentials type is a `struct xucred`. Added in 2.66.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_APPLE_XUCRED = 6,
/// <summary>
/// <para>
/// The native credentials type is a PID `DWORD`. Added in 2.72.
/// </para>
/// </summary>

	G_CREDENTIALS_TYPE_WIN32_PID = 7
}
