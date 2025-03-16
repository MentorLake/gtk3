namespace MentorLake.Vulkan;

public class VkPipelineColorBlendAdvancedStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineColorBlendAdvancedStateCreateInfoEXTExtensions
{

	public static VkPipelineColorBlendAdvancedStateCreateInfoEXT Dereference(this VkPipelineColorBlendAdvancedStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineColorBlendAdvancedStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineColorBlendAdvancedStateCreateInfoEXTExterns
{
}

public struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
}
