namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMaintenance3PropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance3PropertiesExtensions
{

	public static VkPhysicalDeviceMaintenance3Properties Dereference(this VkPhysicalDeviceMaintenance3PropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance3Properties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance3PropertiesExterns
{
}

public struct VkPhysicalDeviceMaintenance3Properties
{
}
