namespace MentorLake.Vulkan;


public class VkPastPresentationTimingGOOGLEHandle : BaseSafeHandle
{
}


public static class VkPastPresentationTimingGOOGLEExtensions
{

	public static VkPastPresentationTimingGOOGLE Dereference(this VkPastPresentationTimingGOOGLEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPastPresentationTimingGOOGLE>(x.DangerousGetHandle());
}
internal class VkPastPresentationTimingGOOGLEExterns
{
}


public struct VkPastPresentationTimingGOOGLE
{
}
