namespace MentorLake.Vulkan;

public class VkSubmitFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkSubmitFlagBitsKHRExtensions
{

	public static VkSubmitFlagBitsKHR Dereference(this VkSubmitFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkSubmitFlagBitsKHRExterns
{
}

public struct VkSubmitFlagBitsKHR
{
}
