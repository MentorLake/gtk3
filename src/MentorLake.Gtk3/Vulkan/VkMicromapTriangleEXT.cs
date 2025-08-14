namespace MentorLake.Vulkan;


public class VkMicromapTriangleEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapTriangleEXTExtensions
{

	public static VkMicromapTriangleEXT Dereference(this VkMicromapTriangleEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapTriangleEXT>(x.DangerousGetHandle());
}
internal class VkMicromapTriangleEXTExterns
{
}


public struct VkMicromapTriangleEXT
{
}
