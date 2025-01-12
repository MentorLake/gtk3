namespace MentorLake.Gtk3.Atk;

public class AtkRangeHandle : BaseSafeHandle
{
	public static AtkRangeHandle New(double lower_limit, double upper_limit, string description)
	{
		return AtkRangeExterns.atk_range_new(lower_limit, upper_limit, description);
	}

}


public static class AtkRangeHandleExtensions
{
	public static AtkRangeHandle Copy(this AtkRangeHandle src)
	{
		return AtkRangeExterns.atk_range_copy(src);
	}

	public static T Free<T>(this T range) where T : AtkRangeHandle
	{
		AtkRangeExterns.atk_range_free(range);
		return range;
	}

	public static string GetDescription(this AtkRangeHandle range)
	{
		return AtkRangeExterns.atk_range_get_description(range);
	}

	public static double GetLowerLimit(this AtkRangeHandle range)
	{
		return AtkRangeExterns.atk_range_get_lower_limit(range);
	}

	public static double GetUpperLimit(this AtkRangeHandle range)
	{
		return AtkRangeExterns.atk_range_get_upper_limit(range);
	}

}
internal class AtkRangeExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkRangeHandle atk_range_new(double lower_limit, double upper_limit, string description);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRangeHandle atk_range_copy(AtkRangeHandle src);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_range_free(AtkRangeHandle range);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_range_get_description(AtkRangeHandle range);

	[DllImport(Libraries.Atk)]
	internal static extern double atk_range_get_lower_limit(AtkRangeHandle range);

	[DllImport(Libraries.Atk)]
	internal static extern double atk_range_get_upper_limit(AtkRangeHandle range);

}

public struct AtkRange
{
}
