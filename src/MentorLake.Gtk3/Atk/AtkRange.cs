namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A given range or subrange, to be used with #AtkValue
/// </para>
/// <para>
/// #AtkRange are used on #AtkValue, in order to represent the full
/// range of a given component (for example an slider or a range
/// control), or to define each individual subrange this full range is
/// splitted if available. See #AtkValue documentation for further
/// details.
/// </para>
/// </summary>

public class AtkRangeHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #AtkRange.
/// </para>
/// </summary>

/// <param name="lower_limit">
/// inferior limit for this range
/// </param>
/// <param name="upper_limit">
/// superior limit for this range
/// </param>
/// <param name="description">
/// human readable description of this range.
/// </param>
/// <return>
/// a new #AtkRange
/// </return>

	public static MentorLake.Atk.AtkRangeHandle New(double lower_limit, double upper_limit, string description)
	{
		return AtkRangeExterns.atk_range_new(lower_limit, upper_limit, description);
	}

}


public static class AtkRangeExtensions
{
/// <summary>
/// <para>
/// Returns a new #AtkRange that is a exact copy of @src
/// </para>
/// </summary>

/// <param name="src">
/// #AtkRange to copy
/// </param>
/// <return>
/// a new #AtkRange copy of @src
/// </return>

	public static MentorLake.Atk.AtkRangeHandle Copy(this MentorLake.Atk.AtkRangeHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_copy(src);
	}

/// <summary>
/// <para>
/// Free @range
/// </para>
/// </summary>

/// <param name="range">
/// #AtkRange to free
/// </param>

	public static void Free(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		AtkRangeExterns.atk_range_free(range);
	}

/// <summary>
/// <para>
/// Returns the human readable description of @range
/// </para>
/// </summary>

/// <param name="range">
/// an #AtkRange
/// </param>
/// <return>
/// the human-readable description of @range
/// </return>

	public static string GetDescription(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_get_description(range);
	}

/// <summary>
/// <para>
/// Returns the lower limit of @range
/// </para>
/// </summary>

/// <param name="range">
/// an #AtkRange
/// </param>
/// <return>
/// the lower limit of @range
/// </return>

	public static double GetLowerLimit(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_get_lower_limit(range);
	}

/// <summary>
/// <para>
/// Returns the upper limit of @range
/// </para>
/// </summary>

/// <param name="range">
/// an #AtkRange
/// </param>
/// <return>
/// the upper limit of @range
/// </return>

	public static double GetUpperLimit(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_get_upper_limit(range);
	}


	public static AtkRange Dereference(this AtkRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkRange>(x.DangerousGetHandle());
}
internal class AtkRangeExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))]
	internal static extern MentorLake.Atk.AtkRangeHandle atk_range_new(double lower_limit, double upper_limit, string description);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))]
	internal static extern MentorLake.Atk.AtkRangeHandle atk_range_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))] MentorLake.Atk.AtkRangeHandle src);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_range_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))] MentorLake.Atk.AtkRangeHandle range);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_range_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))] MentorLake.Atk.AtkRangeHandle range);

	[DllImport(AtkLibrary.Name)]
	internal static extern double atk_range_get_lower_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))] MentorLake.Atk.AtkRangeHandle range);

	[DllImport(AtkLibrary.Name)]
	internal static extern double atk_range_get_upper_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))] MentorLake.Atk.AtkRangeHandle range);

}

/// <summary>
/// <para>
/// A given range or subrange, to be used with #AtkValue
/// </para>
/// <para>
/// #AtkRange are used on #AtkValue, in order to represent the full
/// range of a given component (for example an slider or a range
/// control), or to define each individual subrange this full range is
/// splitted if available. See #AtkValue documentation for further
/// details.
/// </para>
/// </summary>

public struct AtkRange
{
}
