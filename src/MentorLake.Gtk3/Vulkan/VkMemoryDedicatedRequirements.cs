namespace MentorLake.Vulkan;

public class VkMemoryDedicatedRequirementsHandle : BaseSafeHandle
{
}


public static class VkMemoryDedicatedRequirementsExtensions
{

	public static VkMemoryDedicatedRequirements Dereference(this VkMemoryDedicatedRequirementsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryDedicatedRequirements>(x.DangerousGetHandle());
}
internal class VkMemoryDedicatedRequirementsExterns
{
}

public struct VkMemoryDedicatedRequirements
{
}
