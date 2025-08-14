namespace MentorLake.Vulkan;


public class VkApplicationInfoHandle : BaseSafeHandle
{
}


public static class VkApplicationInfoExtensions
{

	public static VkApplicationInfo Dereference(this VkApplicationInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkApplicationInfo>(x.DangerousGetHandle());
}
internal class VkApplicationInfoExterns
{
}


public struct VkApplicationInfo
{
}
