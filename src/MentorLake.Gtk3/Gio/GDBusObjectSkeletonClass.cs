namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GDBusObjectSkeleton.
/// </para>
/// </summary>

public class GDBusObjectSkeletonClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectSkeletonClassExtensions
{

	public static GDBusObjectSkeletonClass Dereference(this GDBusObjectSkeletonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectSkeletonClass>(x.DangerousGetHandle());
}
internal class GDBusObjectSkeletonClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GDBusObjectSkeleton.
/// </para>
/// </summary>

public struct GDBusObjectSkeletonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal class handler for the #GDBusObjectSkeleton::authorize-method signal.
/// </para>
/// </summary>

public IntPtr authorize_method;
}
