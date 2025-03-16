namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRobustness2PropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRobustness2PropertiesEXTExtensions
{

	public static VkPhysicalDeviceRobustness2PropertiesEXT Dereference(this VkPhysicalDeviceRobustness2PropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRobustness2PropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRobustness2PropertiesEXTExterns
{
}

public struct VkPhysicalDeviceRobustness2PropertiesEXT
{
}
