namespace MentorLake.Vulkan;


public class VkSubmitInfoHandle : BaseSafeHandle
{
}


public static class VkSubmitInfoExtensions
{

	public static VkSubmitInfo Dereference(this VkSubmitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitInfo>(x.DangerousGetHandle());
}
internal class VkSubmitInfoExterns
{
}


public struct VkSubmitInfo
{
}
