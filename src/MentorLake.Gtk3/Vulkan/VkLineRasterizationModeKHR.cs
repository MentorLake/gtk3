namespace MentorLake.Vulkan;

public class VkLineRasterizationModeKHRHandle : BaseSafeHandle
{
}


public static class VkLineRasterizationModeKHRExtensions
{

	public static VkLineRasterizationModeKHR Dereference(this VkLineRasterizationModeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLineRasterizationModeKHR>(x.DangerousGetHandle());
}
internal class VkLineRasterizationModeKHRExterns
{
}

public struct VkLineRasterizationModeKHR
{
}
