namespace MentorLake.Vulkan;


public class VkSamplerBorderColorComponentMappingCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSamplerBorderColorComponentMappingCreateInfoEXTExtensions
{

	public static VkSamplerBorderColorComponentMappingCreateInfoEXT Dereference(this VkSamplerBorderColorComponentMappingCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerBorderColorComponentMappingCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkSamplerBorderColorComponentMappingCreateInfoEXTExterns
{
}


public struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
}
