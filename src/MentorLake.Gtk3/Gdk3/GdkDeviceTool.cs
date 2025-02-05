namespace MentorLake.Gtk3.Gdk3;

public class GdkDeviceToolHandle : GObjectHandle
{
}

public static class GdkDeviceToolHandleExtensions
{
	public static ulong GetHardwareId(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_hardware_id(tool);
	}

	public static ulong GetSerial(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_serial(tool);
	}

	public static GdkDeviceToolType GetToolType(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_tool_type(tool);
	}

}

internal class GdkDeviceToolExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern ulong gdk_device_tool_get_hardware_id(GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk3)]
	internal static extern ulong gdk_device_tool_get_serial(GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceToolType gdk_device_tool_get_tool_type(GdkDeviceToolHandle tool);

}
