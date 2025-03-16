namespace MentorLake.Vulkan;

public class VkCompositeAlphaFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkCompositeAlphaFlagBitsKHRExtensions
{

	public static VkCompositeAlphaFlagBitsKHR Dereference(this VkCompositeAlphaFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCompositeAlphaFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkCompositeAlphaFlagBitsKHRExterns
{
}

public struct VkCompositeAlphaFlagBitsKHR
{
}
