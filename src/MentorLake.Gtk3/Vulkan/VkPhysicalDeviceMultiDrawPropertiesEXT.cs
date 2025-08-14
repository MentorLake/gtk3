namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMultiDrawPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultiDrawPropertiesEXTExtensions
{

	public static VkPhysicalDeviceMultiDrawPropertiesEXT Dereference(this VkPhysicalDeviceMultiDrawPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultiDrawPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultiDrawPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
}
