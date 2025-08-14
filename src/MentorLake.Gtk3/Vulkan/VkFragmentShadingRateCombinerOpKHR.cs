namespace MentorLake.Vulkan;


public class VkFragmentShadingRateCombinerOpKHRHandle : BaseSafeHandle
{
}


public static class VkFragmentShadingRateCombinerOpKHRExtensions
{

	public static VkFragmentShadingRateCombinerOpKHR Dereference(this VkFragmentShadingRateCombinerOpKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFragmentShadingRateCombinerOpKHR>(x.DangerousGetHandle());
}
internal class VkFragmentShadingRateCombinerOpKHRExterns
{
}


public struct VkFragmentShadingRateCombinerOpKHR
{
}
