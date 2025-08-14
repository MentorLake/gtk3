namespace MentorLake.Vulkan;


public class VkPhysicalDeviceProtectedMemoryPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceProtectedMemoryPropertiesExtensions
{

	public static VkPhysicalDeviceProtectedMemoryProperties Dereference(this VkPhysicalDeviceProtectedMemoryPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProtectedMemoryProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceProtectedMemoryPropertiesExterns
{
}


public struct VkPhysicalDeviceProtectedMemoryProperties
{
}
