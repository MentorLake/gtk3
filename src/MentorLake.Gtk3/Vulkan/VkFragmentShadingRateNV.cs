namespace MentorLake.Vulkan;

public class VkFragmentShadingRateNVHandle : BaseSafeHandle
{
}


public static class VkFragmentShadingRateNVExtensions
{

	public static VkFragmentShadingRateNV Dereference(this VkFragmentShadingRateNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFragmentShadingRateNV>(x.DangerousGetHandle());
}
internal class VkFragmentShadingRateNVExterns
{
}

public struct VkFragmentShadingRateNV
{
}
