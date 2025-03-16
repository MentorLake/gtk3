namespace MentorLake.Vulkan;

public class VkPipelineColorBlendStateCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineColorBlendStateCreateFlagBitsExtensions
{

	public static VkPipelineColorBlendStateCreateFlagBits Dereference(this VkPipelineColorBlendStateCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineColorBlendStateCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineColorBlendStateCreateFlagBitsExterns
{
}

public struct VkPipelineColorBlendStateCreateFlagBits
{
}
