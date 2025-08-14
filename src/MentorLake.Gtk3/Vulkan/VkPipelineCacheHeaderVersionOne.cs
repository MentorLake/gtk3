namespace MentorLake.Vulkan;


public class VkPipelineCacheHeaderVersionOneHandle : BaseSafeHandle
{
}


public static class VkPipelineCacheHeaderVersionOneExtensions
{

	public static VkPipelineCacheHeaderVersionOne Dereference(this VkPipelineCacheHeaderVersionOneHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCacheHeaderVersionOne>(x.DangerousGetHandle());
}
internal class VkPipelineCacheHeaderVersionOneExterns
{
}


public struct VkPipelineCacheHeaderVersionOne
{
}
