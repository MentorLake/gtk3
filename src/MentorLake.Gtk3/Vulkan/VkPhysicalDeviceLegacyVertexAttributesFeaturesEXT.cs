namespace MentorLake.Vulkan;


public class VkPhysicalDeviceLegacyVertexAttributesFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLegacyVertexAttributesFeaturesEXTExtensions
{

	public static VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT Dereference(this VkPhysicalDeviceLegacyVertexAttributesFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLegacyVertexAttributesFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT
{
}
