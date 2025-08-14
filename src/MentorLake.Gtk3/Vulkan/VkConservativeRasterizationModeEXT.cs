namespace MentorLake.Vulkan;


public class VkConservativeRasterizationModeEXTHandle : BaseSafeHandle
{
}


public static class VkConservativeRasterizationModeEXTExtensions
{

	public static VkConservativeRasterizationModeEXT Dereference(this VkConservativeRasterizationModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkConservativeRasterizationModeEXT>(x.DangerousGetHandle());
}
internal class VkConservativeRasterizationModeEXTExterns
{
}


public struct VkConservativeRasterizationModeEXT
{
}
