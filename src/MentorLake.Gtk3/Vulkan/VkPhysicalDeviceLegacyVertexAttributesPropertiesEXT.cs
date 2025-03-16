namespace MentorLake.Vulkan;

public class VkPhysicalDeviceLegacyVertexAttributesPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLegacyVertexAttributesPropertiesEXTExtensions
{

	public static VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT Dereference(this VkPhysicalDeviceLegacyVertexAttributesPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLegacyVertexAttributesPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT
{
}
