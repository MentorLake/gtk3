namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GMountOperationResult is returned as a result when a request for
/// information is send by the mounting operation.
/// </para>
/// </summary>

[Flags]
public enum GMountOperationResult
{
/// <summary>
/// <para>
/// The request was fulfilled and the
///     user specified data is now available
/// </para>
/// </summary>

	G_MOUNT_OPERATION_HANDLED = 0,
/// <summary>
/// <para>
/// The user requested the mount operation
///     to be aborted
/// </para>
/// </summary>

	G_MOUNT_OPERATION_ABORTED = 1,
/// <summary>
/// <para>
/// The request was unhandled (i.e. not
///     implemented)
/// </para>
/// </summary>

	G_MOUNT_OPERATION_UNHANDLED = 2
}
