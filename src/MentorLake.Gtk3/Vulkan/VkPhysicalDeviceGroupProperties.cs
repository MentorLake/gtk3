namespace MentorLake.Vulkan;

public class VkPhysicalDeviceGroupPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceGroupPropertiesExtensions
{

	public static VkPhysicalDeviceGroupProperties Dereference(this VkPhysicalDeviceGroupPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceGroupProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceGroupPropertiesExterns
{
}

public struct VkPhysicalDeviceGroupProperties
{
}
