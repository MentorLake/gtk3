namespace MentorLake.Vulkan;


public class VkPhysicalDeviceNestedCommandBufferFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceNestedCommandBufferFeaturesEXTExtensions
{

	public static VkPhysicalDeviceNestedCommandBufferFeaturesEXT Dereference(this VkPhysicalDeviceNestedCommandBufferFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceNestedCommandBufferFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceNestedCommandBufferFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
{
}
