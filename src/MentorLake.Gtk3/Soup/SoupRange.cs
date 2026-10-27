namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Represents a byte range as used in the Range header.
/// </para>
/// <para>
/// If @end is non-negative, then @start and @end represent the bounds
/// of of the range, counting from 0. (Eg, the first 500 bytes would be
/// represented as @start = 0 and @end = 499.)
/// </para>
/// <para>
/// If @end is -1 and @start is non-negative, then this represents a
/// range starting at @start and ending with the last byte of the
/// requested resource body. (Eg, all but the first 500 bytes would be
/// @start = 500, and @end = -1.)
/// </para>
/// <para>
/// If @end is -1 and @start is negative, then it represents a &quot;suffix
/// range&quot;, referring to the last -@start bytes of the resource body.
/// (Eg, the last 500 bytes would be @start = -500 and @end = -1.)
/// </para>
/// </summary>

public class SoupRangeHandle : BaseSafeHandle
{
}


public static class SoupRangeExtensions
{

	public static SoupRange Dereference(this SoupRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupRange>(x.DangerousGetHandle());
}
internal class SoupRangeExterns
{
}

/// <summary>
/// <para>
/// Represents a byte range as used in the Range header.
/// </para>
/// <para>
/// If @end is non-negative, then @start and @end represent the bounds
/// of of the range, counting from 0. (Eg, the first 500 bytes would be
/// represented as @start = 0 and @end = 499.)
/// </para>
/// <para>
/// If @end is -1 and @start is non-negative, then this represents a
/// range starting at @start and ending with the last byte of the
/// requested resource body. (Eg, all but the first 500 bytes would be
/// @start = 500, and @end = -1.)
/// </para>
/// <para>
/// If @end is -1 and @start is negative, then it represents a &quot;suffix
/// range&quot;, referring to the last -@start bytes of the resource body.
/// (Eg, the last 500 bytes would be @start = -500 and @end = -1.)
/// </para>
/// </summary>

public struct SoupRange
{
	/// <summary>
/// <para>
/// the start of the range
/// </para>
/// </summary>

public int start;
	/// <summary>
/// <para>
/// the end of the range
/// </para>
/// </summary>

public int end;
}
