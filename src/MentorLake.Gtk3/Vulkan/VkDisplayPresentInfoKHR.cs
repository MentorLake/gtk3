namespace MentorLake.Vulkan;

public class VkDisplayPresentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPresentInfoKHRExtensions
{

	public static VkDisplayPresentInfoKHR Dereference(this VkDisplayPresentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPresentInfoKHR>(x.DangerousGetHandle());
}
internal class VkDisplayPresentInfoKHRExterns
{
}

public struct VkDisplayPresentInfoKHR
{
}
