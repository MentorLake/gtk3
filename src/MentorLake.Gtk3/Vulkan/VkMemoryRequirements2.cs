namespace MentorLake.Vulkan;


public class VkMemoryRequirements2Handle : BaseSafeHandle
{
}


public static class VkMemoryRequirements2Extensions
{

	public static VkMemoryRequirements2 Dereference(this VkMemoryRequirements2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryRequirements2>(x.DangerousGetHandle());
}
internal class VkMemoryRequirements2Externs
{
}


public struct VkMemoryRequirements2
{
}
