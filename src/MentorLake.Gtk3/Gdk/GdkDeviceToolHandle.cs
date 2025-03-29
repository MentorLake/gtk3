namespace MentorLake.Gdk;

public class GdkDeviceToolHandle : GObjectHandle
{
}

public static class GdkDeviceToolHandleExtensions
{
	public static ulong GetHardwareId(this MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (tool.IsInvalid || tool.IsClosed) throw new Exception("Invalid or closed handle (GdkDeviceToolHandle)");
		return GdkDeviceToolHandleExterns.gdk_device_tool_get_hardware_id(tool);
	}

	public static ulong GetSerial(this MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (tool.IsInvalid || tool.IsClosed) throw new Exception("Invalid or closed handle (GdkDeviceToolHandle)");
		return GdkDeviceToolHandleExterns.gdk_device_tool_get_serial(tool);
	}

	public static MentorLake.Gdk.GdkDeviceToolType GetToolType(this MentorLake.Gdk.GdkDeviceToolHandle tool)
	{
		if (tool.IsInvalid || tool.IsClosed) throw new Exception("Invalid or closed handle (GdkDeviceToolHandle)");
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
