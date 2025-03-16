namespace MentorLake.Vulkan;

public class VkViewportWScalingNVHandle : BaseSafeHandle
{
}


public static class VkViewportWScalingNVExtensions
{

	public static VkViewportWScalingNV Dereference(this VkViewportWScalingNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkViewportWScalingNV>(x.DangerousGetHandle());
}
internal class VkViewportWScalingNVExterns
{
}

public struct VkViewportWScalingNV
{
}
