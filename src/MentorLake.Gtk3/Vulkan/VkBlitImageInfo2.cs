namespace MentorLake.Vulkan;

public class VkBlitImageInfo2Handle : BaseSafeHandle
{
}


public static class VkBlitImageInfo2Extensions
{

	public static VkBlitImageInfo2 Dereference(this VkBlitImageInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlitImageInfo2>(x.DangerousGetHandle());
}
internal class VkBlitImageInfo2Externs
{
}

public struct VkBlitImageInfo2
{
}
