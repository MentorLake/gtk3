namespace MentorLake.Gtk3.Atk;

public interface AtkValueHandle
{
}

internal class AtkValueHandleImpl : BaseSafeHandle, AtkValueHandle
{
}

public static class AtkValueHandleExtensions
{
	public static AtkValueHandle GetCurrentValue(this AtkValueHandle obj, out GValue value)
	{
		AtkValueExterns.atk_value_get_current_value(obj, out value);
		return obj;
	}

	public static double GetIncrement(this AtkValueHandle obj)
	{
		return AtkValueExterns.atk_value_get_increment(obj);
	}

	public static AtkValueHandle GetMaximumValue(this AtkValueHandle obj, out GValue value)
	{
		AtkValueExterns.atk_value_get_maximum_value(obj, out value);
		return obj;
	}

	public static AtkValueHandle GetMinimumIncrement(this AtkValueHandle obj, out GValue value)
	{
		AtkValueExterns.atk_value_get_minimum_increment(obj, out value);
		return obj;
	}

	public static AtkValueHandle GetMinimumValue(this AtkValueHandle obj, out GValue value)
	{
		AtkValueExterns.atk_value_get_minimum_value(obj, out value);
		return obj;
	}

	public static AtkRangeHandle GetRange(this AtkValueHandle obj)
	{
		return AtkValueExterns.atk_value_get_range(obj);
	}

	public static GSListHandle GetSubRanges(this AtkValueHandle obj)
	{
		return AtkValueExterns.atk_value_get_sub_ranges(obj);
	}

	public static AtkValueHandle GetValueAndText(this AtkValueHandle obj, out double value, out string text)
	{
		AtkValueExterns.atk_value_get_value_and_text(obj, out value, out text);
		return obj;
	}

	public static bool SetCurrentValue(this AtkValueHandle obj, GValueHandle value)
	{
		return AtkValueExterns.atk_value_set_current_value(obj, value);
	}

	public static AtkValueHandle SetValue(this AtkValueHandle obj, double new_value)
	{
		AtkValueExterns.atk_value_set_value(obj, new_value);
		return obj;
	}

}

internal class AtkValueExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern void atk_value_get_current_value(AtkValueHandle obj, out GValue value);

	[DllImport(Libraries.Atk)]
	internal static extern double atk_value_get_increment(AtkValueHandle obj);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_value_get_maximum_value(AtkValueHandle obj, out GValue value);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_value_get_minimum_increment(AtkValueHandle obj, out GValue value);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_value_get_minimum_value(AtkValueHandle obj, out GValue value);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRangeHandle atk_value_get_range(AtkValueHandle obj);

	[DllImport(Libraries.Atk)]
	internal static extern GSListHandle atk_value_get_sub_ranges(AtkValueHandle obj);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_value_get_value_and_text(AtkValueHandle obj, out double value, out string text);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_value_set_current_value(AtkValueHandle obj, GValueHandle value);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_value_set_value(AtkValueHandle obj, double new_value);

}
