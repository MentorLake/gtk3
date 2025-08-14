namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVertexAttributeDivisorPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVertexAttributeDivisorPropertiesKHRExtensions
{

	public static VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR Dereference(this VkPhysicalDeviceVertexAttributeDivisorPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVertexAttributeDivisorPropertiesKHRExterns
{
}


public struct VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR
{
}
