namespace MentorLake.Vulkan;


public class VkPolygonModeHandle : BaseSafeHandle
{
}


public static class VkPolygonModeExtensions
{

	public static VkPolygonMode Dereference(this VkPolygonModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPolygonMode>(x.DangerousGetHandle());
}
internal class VkPolygonModeExterns
{
}


public struct VkPolygonMode
{
}
