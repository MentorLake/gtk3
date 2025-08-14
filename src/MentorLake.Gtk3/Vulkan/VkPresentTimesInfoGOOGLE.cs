namespace MentorLake.Vulkan;


public class VkPresentTimesInfoGOOGLEHandle : BaseSafeHandle
{
}


public static class VkPresentTimesInfoGOOGLEExtensions
{

	public static VkPresentTimesInfoGOOGLE Dereference(this VkPresentTimesInfoGOOGLEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentTimesInfoGOOGLE>(x.DangerousGetHandle());
}
internal class VkPresentTimesInfoGOOGLEExterns
{
}


public struct VkPresentTimesInfoGOOGLE
{
}
