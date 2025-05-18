namespace MentorLake.Atk;

public class AtkRangeHandle : BaseSafeHandle
{
	public static MentorLake.Atk.AtkRangeHandle New(double lower_limit, double upper_limit, string description)
	{
		return AtkRangeExterns.atk_range_new(lower_limit, upper_limit, description);
	}

}


public static class AtkRangeExtensions
{
	public static MentorLake.Atk.AtkRangeHandle Copy(this MentorLake.Atk.AtkRangeHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_copy(src);
	}

	public static void Free(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		AtkRangeExterns.atk_range_free(range);
	}

	public static string GetDescription(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_get_description(range);
	}

	public static double GetLowerLimit(this MentorLake.Atk.AtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (AtkRange)");
		return AtkRangeExterns.atk_range_get_lower_limit(range);
	}

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

public struct AtkRange
{
}
