namespace MentorLake.Vulkan;


public class VkPresentScalingFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkPresentScalingFlagBitsEXTExtensions
{

	public static VkPresentScalingFlagBitsEXT Dereference(this VkPresentScalingFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentScalingFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkPresentScalingFlagBitsEXTExterns
{
}


public struct VkPresentScalingFlagBitsEXT
{
}
