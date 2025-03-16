namespace MentorLake.Vulkan;

public class VkPipelineCacheCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineCacheCreateInfoExtensions
{

	public static VkPipelineCacheCreateInfo Dereference(this VkPipelineCacheCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCacheCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineCacheCreateInfoExterns
{
}

public struct VkPipelineCacheCreateInfo
{
}
