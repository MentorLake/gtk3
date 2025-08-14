namespace MentorLake.Vulkan;


public class VkPipelineCacheHandle : BaseSafeHandle
{
}


public static class VkPipelineCacheExtensions
{

	public static VkPipelineCache Dereference(this VkPipelineCacheHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCache>(x.DangerousGetHandle());
}
internal class VkPipelineCacheExterns
{
}


public struct VkPipelineCache
{
}
