namespace MentorLake.Vulkan;

public class VkSubmitInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkSubmitInfo2KHRExtensions
{

	public static VkSubmitInfo2KHR Dereference(this VkSubmitInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitInfo2KHR>(x.DangerousGetHandle());
}
internal class VkSubmitInfo2KHRExterns
{
}

public struct VkSubmitInfo2KHR
{
}
