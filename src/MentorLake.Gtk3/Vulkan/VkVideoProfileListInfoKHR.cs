namespace MentorLake.Vulkan;

public class VkVideoProfileListInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoProfileListInfoKHRExtensions
{

	public static VkVideoProfileListInfoKHR Dereference(this VkVideoProfileListInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoProfileListInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoProfileListInfoKHRExterns
{
}

public struct VkVideoProfileListInfoKHR
{
}
