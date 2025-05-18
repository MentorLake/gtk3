namespace MentorLake.Atk;

public interface AtkValueHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkValueHandleImpl : BaseSafeHandle, AtkValueHandle
{
}

public static class AtkValueHandleExtensions
{
	public static T GetCurrentValue<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_current_value(obj, out value);
		return obj;
	}

	public static double GetIncrement(this MentorLake.Atk.AtkValueHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_get_increment(obj);
	}

	public static T GetMaximumValue<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_maximum_value(obj, out value);
		return obj;
	}

	public static T GetMinimumIncrement<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_minimum_increment(obj, out value);
		return obj;
	}

	public static T GetMinimumValue<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_minimum_value(obj, out value);
		return obj;
	}

	public static MentorLake.Atk.AtkRangeHandle GetRange(this MentorLake.Atk.AtkValueHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_get_range(obj);
	}

	public static MentorLake.GLib.GSListHandle GetSubRanges(this MentorLake.Atk.AtkValueHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_get_sub_ranges(obj);
	}

	public static T GetValueAndText<T>(this T obj, out double value, out string text) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_value_and_text(obj, out value, out text);
		return obj;
	}

	public static bool SetCurrentValue(this MentorLake.Atk.AtkValueHandle obj, MentorLake.GObject.GValueHandle value)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_set_current_value(obj, value);
	}

	public static T SetValue<T>(this T obj, double new_value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_set_value(obj, new_value);
		return obj;
	}

}

internal class AtkValueHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	internal static extern double atk_value_get_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_maximum_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_minimum_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_minimum_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))]
	internal static extern MentorLake.Atk.AtkRangeHandle atk_value_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle atk_value_get_sub_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_value_and_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out double value, out string text);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_value_set_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, double new_value);

}
