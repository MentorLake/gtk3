namespace MentorLake.Vulkan;

public class VkMemoryRequirementsHandle : BaseSafeHandle
{
}


public static class VkMemoryRequirementsExtensions
{

	public static VkMemoryRequirements Dereference(this VkMemoryRequirementsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryRequirements>(x.DangerousGetHandle());
}
internal class VkMemoryRequirementsExterns
{
}

public struct VkMemoryRequirements
{
}
