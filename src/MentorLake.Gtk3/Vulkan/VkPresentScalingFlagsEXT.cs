namespace MentorLake.Vulkan;

public class VkPresentScalingFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPresentScalingFlagsEXTExtensions
{

	public static VkPresentScalingFlagsEXT Dereference(this VkPresentScalingFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentScalingFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPresentScalingFlagsEXTExterns
{
}

public struct VkPresentScalingFlagsEXT
{
}
