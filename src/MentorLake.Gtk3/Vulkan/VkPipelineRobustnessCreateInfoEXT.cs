namespace MentorLake.Vulkan;


public class VkPipelineRobustnessCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRobustnessCreateInfoEXTExtensions
{

	public static VkPipelineRobustnessCreateInfoEXT Dereference(this VkPipelineRobustnessCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRobustnessCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRobustnessCreateInfoEXTExterns
{
}


public struct VkPipelineRobustnessCreateInfoEXT
{
}
