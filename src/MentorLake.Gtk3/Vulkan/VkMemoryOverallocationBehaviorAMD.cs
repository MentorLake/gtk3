namespace MentorLake.Vulkan;

public class VkMemoryOverallocationBehaviorAMDHandle : BaseSafeHandle
{
}


public static class VkMemoryOverallocationBehaviorAMDExtensions
{

	public static VkMemoryOverallocationBehaviorAMD Dereference(this VkMemoryOverallocationBehaviorAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryOverallocationBehaviorAMD>(x.DangerousGetHandle());
}
internal class VkMemoryOverallocationBehaviorAMDExterns
{
}

public struct VkMemoryOverallocationBehaviorAMD
{
}
