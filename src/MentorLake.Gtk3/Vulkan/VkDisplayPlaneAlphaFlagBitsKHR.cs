namespace MentorLake.Vulkan;

public class VkDisplayPlaneAlphaFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlaneAlphaFlagBitsKHRExtensions
{

	public static VkDisplayPlaneAlphaFlagBitsKHR Dereference(this VkDisplayPlaneAlphaFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlaneAlphaFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlaneAlphaFlagBitsKHRExterns
{
}

public struct VkDisplayPlaneAlphaFlagBitsKHR
{
}
