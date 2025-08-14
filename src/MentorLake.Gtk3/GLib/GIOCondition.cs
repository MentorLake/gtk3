namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A bitwise combination representing a condition to watch for on an
/// event source.
/// </para>
/// </summary>

[Flags]
public enum GIOCondition : uint
{
/// <summary>
/// <para>
/// There is data to read.
/// </para>
/// </summary>

	G_IO_IN = 1,
/// <summary>
/// <para>
/// Data can be written (without blocking).
/// </para>
/// </summary>

	G_IO_OUT = 4,
/// <summary>
/// <para>
/// There is urgent data to read.
/// </para>
/// </summary>

	G_IO_PRI = 2,
/// <summary>
/// <para>
/// Error condition.
/// </para>
/// </summary>

	G_IO_ERR = 8,
/// <summary>
/// <para>
/// Hung up (the connection has been broken, usually for
///            pipes and sockets).
/// </para>
/// </summary>

	G_IO_HUP = 16,
/// <summary>
/// <para>
/// Invalid request. The file descriptor is not open.
/// </para>
/// </summary>

	G_IO_NVAL = 32
}
