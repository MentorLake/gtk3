namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMultiviewPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultiviewPropertiesExtensions
{

	public static VkPhysicalDeviceMultiviewProperties Dereference(this VkPhysicalDeviceMultiviewPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultiviewProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultiviewPropertiesExterns
{
}


public struct VkPhysicalDeviceMultiviewProperties
{
}
