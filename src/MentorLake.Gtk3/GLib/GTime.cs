namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Simply a replacement for `time_t`. It has been deprecated
/// since it is not equivalent to `time_t` on 64-bit platforms
/// with a 64-bit `time_t`.
/// </para>
/// <para>
/// Unrelated to #GTimer.
/// </para>
/// <para>
/// Note that #GTime is defined to always be a 32-bit integer,
/// unlike `time_t` which may be 64-bit on some systems. Therefore,
/// #GTime will overflow in the year 2038, and you cannot use the
/// address of a #GTime variable as argument to the UNIX time()
/// function.
/// </para>
/// <para>
/// Instead, do the following:
/// </para>
/// <code>
/// time_t ttime;
/// time_t ttime;
/// GTime gtime;
/// 
/// time (&amp;ttime);
/// gtime = (GTime)ttime;
/// </code>
/// </summary>

public struct GTime
{
	public int Value;
}

/// <summary>
/// <para>
/// Simply a replacement for `time_t`. It has been deprecated
/// since it is not equivalent to `time_t` on 64-bit platforms
/// with a 64-bit `time_t`.
/// </para>
/// <para>
/// Unrelated to #GTimer.
/// </para>
/// <para>
/// Note that #GTime is defined to always be a 32-bit integer,
/// unlike `time_t` which may be 64-bit on some systems. Therefore,
/// #GTime will overflow in the year 2038, and you cannot use the
/// address of a #GTime variable as argument to the UNIX time()
/// function.
/// </para>
/// <para>
/// Instead, do the following:
/// </para>
/// <code>
/// time_t ttime;
/// time_t ttime;
/// GTime gtime;
/// 
/// time (&amp;ttime);
/// gtime = (GTime)ttime;
/// </code>
/// </summary>

public class GTimeHandle : BaseSafeHandle
{
}

public static class GTimeHandleExtensions
{
	public static GTime Dereference(this GTimeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTime>(x.DangerousGetHandle());
	public static int DereferenceValue(this GTimeHandle x) => x.Dereference().Value;
}
