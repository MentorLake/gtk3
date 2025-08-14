namespace MentorLake.Vulkan;


public class VkPipelineRobustnessBufferBehaviorEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRobustnessBufferBehaviorEXTExtensions
{

	public static VkPipelineRobustnessBufferBehaviorEXT Dereference(this VkPipelineRobustnessBufferBehaviorEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRobustnessBufferBehaviorEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRobustnessBufferBehaviorEXTExterns
{
}


public struct VkPipelineRobustnessBufferBehaviorEXT
{
}
