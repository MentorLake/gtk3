namespace MentorLake.Vulkan;

public class VkBlitImageInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkBlitImageInfo2KHRExtensions
{

	public static VkBlitImageInfo2KHR Dereference(this VkBlitImageInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlitImageInfo2KHR>(x.DangerousGetHandle());
}
internal class VkBlitImageInfo2KHRExterns
{
}

public struct VkBlitImageInfo2KHR
{
}
