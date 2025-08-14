namespace MentorLake.Vulkan;


public class VkPhysicalDeviceProvokingVertexFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceProvokingVertexFeaturesEXTExtensions
{

	public static VkPhysicalDeviceProvokingVertexFeaturesEXT Dereference(this VkPhysicalDeviceProvokingVertexFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProvokingVertexFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceProvokingVertexFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
}
