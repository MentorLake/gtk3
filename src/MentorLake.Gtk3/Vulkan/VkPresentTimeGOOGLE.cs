namespace MentorLake.Vulkan;


public class VkPresentTimeGOOGLEHandle : BaseSafeHandle
{
}


public static class VkPresentTimeGOOGLEExtensions
{

	public static VkPresentTimeGOOGLE Dereference(this VkPresentTimeGOOGLEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentTimeGOOGLE>(x.DangerousGetHandle());
}
internal class VkPresentTimeGOOGLEExterns
{
}


public struct VkPresentTimeGOOGLE
{
}
