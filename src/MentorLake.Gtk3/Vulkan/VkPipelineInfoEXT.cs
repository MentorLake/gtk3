namespace MentorLake.Vulkan;

public class VkPipelineInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineInfoEXTExtensions
{

	public static VkPipelineInfoEXT Dereference(this VkPipelineInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineInfoEXTExterns
{
}

public struct VkPipelineInfoEXT
{
}
