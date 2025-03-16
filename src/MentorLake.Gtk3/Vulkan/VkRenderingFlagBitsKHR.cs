namespace MentorLake.Vulkan;

public class VkRenderingFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingFlagBitsKHRExtensions
{

	public static VkRenderingFlagBitsKHR Dereference(this VkRenderingFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkRenderingFlagBitsKHRExterns
{
}

public struct VkRenderingFlagBitsKHR
{
}
