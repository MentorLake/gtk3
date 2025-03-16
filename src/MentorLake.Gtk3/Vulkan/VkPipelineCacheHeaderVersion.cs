namespace MentorLake.Vulkan;

public class VkPipelineCacheHeaderVersionHandle : BaseSafeHandle
{
}


public static class VkPipelineCacheHeaderVersionExtensions
{

	public static VkPipelineCacheHeaderVersion Dereference(this VkPipelineCacheHeaderVersionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCacheHeaderVersion>(x.DangerousGetHandle());
}
internal class VkPipelineCacheHeaderVersionExterns
{
}

public struct VkPipelineCacheHeaderVersion
{
}
