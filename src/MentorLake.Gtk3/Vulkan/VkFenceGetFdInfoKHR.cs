namespace MentorLake.Vulkan;


public class VkFenceGetFdInfoKHRHandle : BaseSafeHandle
{
}


public static class VkFenceGetFdInfoKHRExtensions
{

	public static VkFenceGetFdInfoKHR Dereference(this VkFenceGetFdInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceGetFdInfoKHR>(x.DangerousGetHandle());
}
internal class VkFenceGetFdInfoKHRExterns
{
}


public struct VkFenceGetFdInfoKHR
{
}
