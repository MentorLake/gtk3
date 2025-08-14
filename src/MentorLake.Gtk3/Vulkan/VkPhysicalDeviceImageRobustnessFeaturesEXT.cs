namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageRobustnessFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageRobustnessFeaturesEXTExtensions
{

	public static VkPhysicalDeviceImageRobustnessFeaturesEXT Dereference(this VkPhysicalDeviceImageRobustnessFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageRobustnessFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageRobustnessFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceImageRobustnessFeaturesEXT
{
}
