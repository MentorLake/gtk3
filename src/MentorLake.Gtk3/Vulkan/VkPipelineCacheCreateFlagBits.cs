namespace MentorLake.Vulkan;

public class VkPipelineCacheCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineCacheCreateFlagBitsExtensions
{

	public static VkPipelineCacheCreateFlagBits Dereference(this VkPipelineCacheCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCacheCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineCacheCreateFlagBitsExterns
{
}

public struct VkPipelineCacheCreateFlagBits
{
}
