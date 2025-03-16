namespace MentorLake.Gio;

[Flags]
public enum GMountOperationResult
{
	G_MOUNT_OPERATION_HANDLED = 0,
	G_MOUNT_OPERATION_ABORTED = 1,
	G_MOUNT_OPERATION_UNHANDLED = 2
}
