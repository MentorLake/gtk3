namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExternalMemoryHostPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalMemoryHostPropertiesEXTExtensions
{

	public static VkPhysicalDeviceExternalMemoryHostPropertiesEXT Dereference(this VkPhysicalDeviceExternalMemoryHostPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalMemoryHostPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalMemoryHostPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
}
