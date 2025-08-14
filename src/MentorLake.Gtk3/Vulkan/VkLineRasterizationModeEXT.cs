namespace MentorLake.Vulkan;


public class VkLineRasterizationModeEXTHandle : BaseSafeHandle
{
}


public static class VkLineRasterizationModeEXTExtensions
{

	public static VkLineRasterizationModeEXT Dereference(this VkLineRasterizationModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLineRasterizationModeEXT>(x.DangerousGetHandle());
}
internal class VkLineRasterizationModeEXTExterns
{
}


public struct VkLineRasterizationModeEXT
{
}
