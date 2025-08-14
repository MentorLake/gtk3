namespace MentorLake.Vulkan;


public class VkExtent2DHandle : BaseSafeHandle
{
}


public static class VkExtent2DExtensions
{

	public static VkExtent2D Dereference(this VkExtent2DHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExtent2D>(x.DangerousGetHandle());
}
internal class VkExtent2DExterns
{
}


public struct VkExtent2D
{
}
