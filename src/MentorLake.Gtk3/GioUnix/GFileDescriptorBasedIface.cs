namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// An interface for file descriptor based io objects.
/// </para>
/// </summary>

public class GFileDescriptorBasedIfaceHandle : BaseSafeHandle
{
}


public static class GFileDescriptorBasedIfaceExtensions
{

	public static GFileDescriptorBasedIface Dereference(this GFileDescriptorBasedIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileDescriptorBasedIface>(x.DangerousGetHandle());
}
internal class GFileDescriptorBasedIfaceExterns
{
}

/// <summary>
/// <para>
/// An interface for file descriptor based io objects.
/// </para>
/// </summary>

public struct GFileDescriptorBasedIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Gets the underlying file descriptor.
/// </para>
/// </summary>

public IntPtr get_fd;
}
