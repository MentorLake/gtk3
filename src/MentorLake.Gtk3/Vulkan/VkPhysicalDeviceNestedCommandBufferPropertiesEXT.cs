namespace MentorLake.Vulkan;


public class VkPhysicalDeviceNestedCommandBufferPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceNestedCommandBufferPropertiesEXTExtensions
{

	public static VkPhysicalDeviceNestedCommandBufferPropertiesEXT Dereference(this VkPhysicalDeviceNestedCommandBufferPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceNestedCommandBufferPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceNestedCommandBufferPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT
{
}
