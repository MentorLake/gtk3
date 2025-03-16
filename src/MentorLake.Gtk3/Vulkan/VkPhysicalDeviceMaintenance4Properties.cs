namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMaintenance4PropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance4PropertiesExtensions
{

	public static VkPhysicalDeviceMaintenance4Properties Dereference(this VkPhysicalDeviceMaintenance4PropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance4Properties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance4PropertiesExterns
{
}

public struct VkPhysicalDeviceMaintenance4Properties
{
}
