namespace MentorLake.Vulkan;


public class VkOffset2DHandle : BaseSafeHandle
{
}


public static class VkOffset2DExtensions
{

	public static VkOffset2D Dereference(this VkOffset2DHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOffset2D>(x.DangerousGetHandle());
}
internal class VkOffset2DExterns
{
}


public struct VkOffset2D
{
}
