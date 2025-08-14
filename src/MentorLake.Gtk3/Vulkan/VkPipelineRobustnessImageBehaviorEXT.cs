namespace MentorLake.Vulkan;


public class VkPipelineRobustnessImageBehaviorEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRobustnessImageBehaviorEXTExtensions
{

	public static VkPipelineRobustnessImageBehaviorEXT Dereference(this VkPipelineRobustnessImageBehaviorEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRobustnessImageBehaviorEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRobustnessImageBehaviorEXTExterns
{
}


public struct VkPipelineRobustnessImageBehaviorEXT
{
}
