namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Represents a file descriptor, which events to poll for, and which events
/// occurred.
/// </para>
/// </summary>

public class GPollFDHandle : BaseSafeHandle
{
}


public static class GPollFDExtensions
{

	public static GPollFD Dereference(this GPollFDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPollFD>(x.DangerousGetHandle());
}
internal class GPollFDExterns
{
}

/// <summary>
/// <para>
/// Represents a file descriptor, which events to poll for, and which events
/// occurred.
/// </para>
/// </summary>

public struct GPollFD
{
	/// <summary>
/// <para>
/// the file descriptor to poll (or a HANDLE on Win32)
/// </para>
/// </summary>

public int fd;
	/// <summary>
/// <para>
/// a bitwise combination from #GIOCondition, specifying which
///     events should be polled for. Typically for reading from a file
///     descriptor you would use %G_IO_IN | %G_IO_HUP | %G_IO_ERR, and
///     for writing you would use %G_IO_OUT | %G_IO_ERR.
/// </para>
/// </summary>

public ushort events;
	/// <summary>
/// <para>
/// a bitwise combination of flags from #GIOCondition, returned
///     from the poll() function to indicate which events occurred.
/// </para>
/// </summary>

public ushort revents;
}
