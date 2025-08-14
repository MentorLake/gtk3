namespace MentorLake.Gdk;


public class GdkDeviceToolHandle : GObjectHandle
{
}

public static class GdkDeviceToolHandleExtensions
{
/// <summary>
/// <para>
/// Gets the hardware ID of this tool, or 0 if it's not known. When
/// non-zero, the identificator is unique for the given tool model,
/// meaning that two identical tools will share the same @hardware_id,
/// but will have different serial numbers (see gdk_device_tool_get_serial()).
/// </para>
/// <para>
/// This is a more concrete (and device specific) method to identify
/// a #GdkDeviceTool than gdk_device_tool_get_tool_type(), as a tablet
/// may support multiple devices with the same #GdkDeviceToolType,
/// but having different hardware identificators.
/// </para>
/// </summary>

/// <param name="tool">
/// a #GdkDeviceTool
/// </param>
/// <return>
/// The hardware identificator of this tool.
/// </return>

	public static ulong GetHardwareId(this MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (tool.IsInvalid) throw new Exception("Invalid handle (GdkDeviceToolHandle)");
		return GdkDeviceToolHandleExterns.gdk_device_tool_get_hardware_id(tool);
	}

/// <summary>
/// <para>
/// Gets the serial of this tool, this value can be used to identify a
/// physical tool (eg. a tablet pen) across program executions.
/// </para>
/// </summary>

/// <param name="tool">
/// a #GdkDeviceTool
/// </param>
/// <return>
/// The serial ID for this tool
/// </return>

	public static ulong GetSerial(this MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (tool.IsInvalid) throw new Exception("Invalid handle (GdkDeviceToolHandle)");
		return GdkDeviceToolHandleExterns.gdk_device_tool_get_serial(tool);
	}

/// <summary>
/// <para>
/// Gets the #GdkDeviceToolType of the tool.
/// </para>
/// </summary>

/// <param name="tool">
/// a #GdkDeviceTool
/// </param>
/// <return>
/// The physical type for this tool. This can be used to figure out what
/// sort of pen is being used, such as an airbrush or a pencil.
/// </return>

	public static MentorLake.Gdk.GdkDeviceToolType GetToolType(this MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (tool.IsInvalid) throw new Exception("Invalid handle (GdkDeviceToolHandle)");
		return GdkDeviceToolHandleExterns.gdk_device_tool_get_tool_type(tool);
	}

}

internal class GdkDeviceToolHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern ulong gdk_device_tool_get_hardware_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool);

	[DllImport(GdkLibrary.Name)]
	internal static extern ulong gdk_device_tool_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceToolType gdk_device_tool_get_tool_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool);

}
