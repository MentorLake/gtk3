namespace MentorLake.Vulkan;

public class VkRect2DHandle : BaseSafeHandle
{
}


public static class VkRect2DExtensions
{

	public static VkRect2D Dereference(this VkRect2DHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRect2D>(x.DangerousGetHandle());
}
internal class VkRect2DExterns
{
}

public struct VkRect2D
{
}
