namespace MentorLake.Vulkan;

public class VkPipelineCacheCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineCacheCreateFlagsExtensions
{

	public static VkPipelineCacheCreateFlags Dereference(this VkPipelineCacheCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCacheCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineCacheCreateFlagsExterns
{
}

public struct VkPipelineCacheCreateFlags
{
}
