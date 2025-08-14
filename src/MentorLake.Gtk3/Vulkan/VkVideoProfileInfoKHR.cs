namespace MentorLake.Vulkan;


public class VkVideoProfileInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoProfileInfoKHRExtensions
{

	public static VkVideoProfileInfoKHR Dereference(this VkVideoProfileInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoProfileInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoProfileInfoKHRExterns
{
}


public struct VkVideoProfileInfoKHR
{
}
