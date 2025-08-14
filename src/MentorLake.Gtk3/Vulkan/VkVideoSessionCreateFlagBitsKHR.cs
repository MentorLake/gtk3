namespace MentorLake.Vulkan;


public class VkVideoSessionCreateFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionCreateFlagBitsKHRExtensions
{

	public static VkVideoSessionCreateFlagBitsKHR Dereference(this VkVideoSessionCreateFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionCreateFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionCreateFlagBitsKHRExterns
{
}


public struct VkVideoSessionCreateFlagBitsKHR
{
}
