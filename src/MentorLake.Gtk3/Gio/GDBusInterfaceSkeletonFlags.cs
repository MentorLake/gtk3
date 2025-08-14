namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags describing the behavior of a #GDBusInterfaceSkeleton instance.
/// </para>
/// </summary>

[Flags]
public enum GDBusInterfaceSkeletonFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_INTERFACE_SKELETON_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Each method invocation is handled in
///   a thread dedicated to the invocation. This means that the method implementation can use blocking IO
///   without blocking any other part of the process. It also means that the method implementation must
///   use locking to access data structures used by other threads.
/// </para>
/// </summary>

	G_DBUS_INTERFACE_SKELETON_FLAGS_HANDLE_METHOD_INVOCATIONS_IN_THREAD = 1
}
