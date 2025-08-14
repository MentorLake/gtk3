namespace MentorLake.Vulkan;


public class VkExtent3DHandle : BaseSafeHandle
{
}


public static class VkExtent3DExtensions
{

	public static VkExtent3D Dereference(this VkExtent3DHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExtent3D>(x.DangerousGetHandle());
}
internal class VkExtent3DExterns
{
}


public struct VkExtent3D
{
}
