namespace MentorLake.Vulkan;

public class VkFramebufferMixedSamplesCombinationNVHandle : BaseSafeHandle
{
}


public static class VkFramebufferMixedSamplesCombinationNVExtensions
{

	public static VkFramebufferMixedSamplesCombinationNV Dereference(this VkFramebufferMixedSamplesCombinationNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferMixedSamplesCombinationNV>(x.DangerousGetHandle());
}
internal class VkFramebufferMixedSamplesCombinationNVExterns
{
}

public struct VkFramebufferMixedSamplesCombinationNV
{
}
