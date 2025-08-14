namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVertexAttributeDivisorFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVertexAttributeDivisorFeaturesEXTExtensions
{

	public static VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT Dereference(this VkPhysicalDeviceVertexAttributeDivisorFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVertexAttributeDivisorFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
}
