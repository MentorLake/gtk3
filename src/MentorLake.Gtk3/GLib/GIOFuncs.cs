namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A table of functions used to handle different types of #GIOChannel
/// in a generic way.
/// </para>
/// </summary>

public class GIOFuncsHandle : BaseSafeHandle
{
}


public static class GIOFuncsExtensions
{

	public static GIOFuncs Dereference(this GIOFuncsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOFuncs>(x.DangerousGetHandle());
}
internal class GIOFuncsExterns
{
}

/// <summary>
/// <para>
/// A table of functions used to handle different types of #GIOChannel
/// in a generic way.
/// </para>
/// </summary>

public struct GIOFuncs
{
	/// <summary>
/// <para>
/// reads raw bytes from the channel.  This is called from
///           various functions such as g_io_channel_read_chars() to
///           read raw bytes from the channel.  Encoding and buffering
///           issues are dealt with at a higher level.
/// </para>
/// </summary>

public IntPtr io_read;
	/// <summary>
/// <para>
/// writes raw bytes to the channel.  This is called from
///            various functions such as g_io_channel_write_chars() to
///            write raw bytes to the channel.  Encoding and buffering
///            issues are dealt with at a higher level.
/// </para>
/// </summary>

public IntPtr io_write;
	/// <summary>
/// <para>
/// seeks the channel.  This is called from
///           g_io_channel_seek() on channels that support it.
/// </para>
/// </summary>

public IntPtr io_seek;
	/// <summary>
/// <para>
/// closes the channel.  This is called from
///            g_io_channel_close() after flushing the buffers.
/// </para>
/// </summary>

public IntPtr io_close;
	/// <summary>
/// <para>
/// creates a watch on the channel.  This call
///                   corresponds directly to g_io_create_watch().
/// </para>
/// </summary>

public IntPtr io_create_watch;
	/// <summary>
/// <para>
/// called from g_io_channel_unref() when the channel needs to
///           be freed.  This function must free the memory associated
///           with the channel, including freeing the #GIOChannel
///           structure itself.  The channel buffers have been flushed
///           and possibly @io_close has been called by the time this
///           function is called.
/// </para>
/// </summary>

public IntPtr io_free;
	/// <summary>
/// <para>
/// sets the #GIOFlags on the channel.  This is called
///                from g_io_channel_set_flags() with all flags except
///                for %G_IO_FLAG_APPEND and %G_IO_FLAG_NONBLOCK masked
///                out.
/// </para>
/// </summary>

public IntPtr io_set_flags;
	/// <summary>
/// <para>
/// gets the #GIOFlags for the channel.  This function
///                need only return the %G_IO_FLAG_APPEND and
///                %G_IO_FLAG_NONBLOCK flags; g_io_channel_get_flags()
///                automatically adds the others as appropriate.
/// </para>
/// </summary>

public IntPtr io_get_flags;
}
