namespace MentorLake.Vulkan;

public class VkMemoryRequirements2KHRHandle : BaseSafeHandle
{
}


public static class VkMemoryRequirements2KHRExtensions
{

	public static VkMemoryRequirements2KHR Dereference(this VkMemoryRequirements2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryRequirements2KHR>(x.DangerousGetHandle());
}
internal class VkMemoryRequirements2KHRExterns
{
}

public struct VkMemoryRequirements2KHR
{
}
