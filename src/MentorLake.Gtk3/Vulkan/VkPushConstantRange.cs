namespace MentorLake.Vulkan;


public class VkPushConstantRangeHandle : BaseSafeHandle
{
}


public static class VkPushConstantRangeExtensions
{

	public static VkPushConstantRange Dereference(this VkPushConstantRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPushConstantRange>(x.DangerousGetHandle());
}
internal class VkPushConstantRangeExterns
{
}


public struct VkPushConstantRange
{
}
