namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVertexAttributeDivisorFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVertexAttributeDivisorFeaturesKHRExtensions
{

	public static VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR Dereference(this VkPhysicalDeviceVertexAttributeDivisorFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVertexAttributeDivisorFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR
{
}
