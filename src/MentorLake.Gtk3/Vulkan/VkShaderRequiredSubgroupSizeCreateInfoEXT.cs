namespace MentorLake.Vulkan;

public class VkShaderRequiredSubgroupSizeCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkShaderRequiredSubgroupSizeCreateInfoEXTExtensions
{

	public static VkShaderRequiredSubgroupSizeCreateInfoEXT Dereference(this VkShaderRequiredSubgroupSizeCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderRequiredSubgroupSizeCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkShaderRequiredSubgroupSizeCreateInfoEXTExterns
{
}

public struct VkShaderRequiredSubgroupSizeCreateInfoEXT
{
}
