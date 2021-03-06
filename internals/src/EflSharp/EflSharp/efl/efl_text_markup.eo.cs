#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { 
/// <summary>Markup data that populates the text object&apos;s style and format</summary>
[ITextMarkupNativeInherit]
public interface ITextMarkup : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Markup property</summary>
/// <returns>The markup-text representation set to this text.</returns>
System.String GetMarkup();
    /// <summary>Markup property</summary>
/// <param name="markup">The markup-text representation set to this text.</param>
/// <returns></returns>
void SetMarkup( System.String markup);
            /// <summary>Markup property</summary>
/// <value>The markup-text representation set to this text.</value>
    System.String Markup {
        get ;
        set ;
    }
}
/// <summary>Markup data that populates the text object&apos;s style and format</summary>
sealed public class ITextMarkupConcrete : 

ITextMarkup
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (ITextMarkupConcrete))
                return Efl.ITextMarkupNativeInherit.GetEflClassStatic();
            else
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
        }
    }
    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle {
        get { return handle; }
    }
    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_text_markup_interface_get();
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    private ITextMarkupConcrete(System.IntPtr raw)
    {
        handle = raw;
        RegisterEventProxies();
    }
    ///<summary>Destructor.</summary>
    ~ITextMarkupConcrete()
    {
        Dispose(false);
    }
    ///<summary>Releases the underlying native instance.</summary>
    void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero) {
            Efl.Eo.Globals.efl_unref(handle);
            handle = System.IntPtr.Zero;
        }
    }
    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    ///<summary>Verifies if the given object is equal to this one.</summary>
    public override bool Equals(object obj)
    {
        var other = obj as Efl.Object;
        if (other == null)
            return false;
        return this.NativeHandle == other.NativeHandle;
    }
    ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }
    ///<summary>Turns the native pointer into a string representation.</summary>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }
    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
     void RegisterEventProxies()
    {
    }
    /// <summary>Markup property</summary>
    /// <returns>The markup-text representation set to this text.</returns>
    public System.String GetMarkup() {
         var _ret_var = Efl.ITextMarkupNativeInherit.efl_text_markup_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Markup property</summary>
    /// <param name="markup">The markup-text representation set to this text.</param>
    /// <returns></returns>
    public void SetMarkup( System.String markup) {
                                 Efl.ITextMarkupNativeInherit.efl_text_markup_set_ptr.Value.Delegate(this.NativeHandle, markup);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Markup property</summary>
/// <value>The markup-text representation set to this text.</value>
    public System.String Markup {
        get { return GetMarkup(); }
        set { SetMarkup( value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.ITextMarkupConcrete.efl_text_markup_interface_get();
    }
}
public class ITextMarkupNativeInherit  : Efl.Eo.NativeClass{
    public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Efl);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_text_markup_get_static_delegate == null)
            efl_text_markup_get_static_delegate = new efl_text_markup_get_delegate(markup_get);
        if (methods.FirstOrDefault(m => m.Name == "GetMarkup") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_markup_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_markup_get_static_delegate)});
        if (efl_text_markup_set_static_delegate == null)
            efl_text_markup_set_static_delegate = new efl_text_markup_set_delegate(markup_set);
        if (methods.FirstOrDefault(m => m.Name == "SetMarkup") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_markup_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_markup_set_static_delegate)});
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.ITextMarkupConcrete.efl_text_markup_interface_get();
    }
    public static  IntPtr GetEflClassStatic()
    {
        return Efl.ITextMarkupConcrete.efl_text_markup_interface_get();
    }


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate System.String efl_text_markup_get_delegate(System.IntPtr obj, System.IntPtr pd);


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate System.String efl_text_markup_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_text_markup_get_api_delegate> efl_text_markup_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_markup_get_api_delegate>(_Module, "efl_text_markup_get");
     private static System.String markup_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_text_markup_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        System.String _ret_var = default(System.String);
            try {
                _ret_var = ((ITextMarkup)wrapper).GetMarkup();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_text_markup_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_text_markup_get_delegate efl_text_markup_get_static_delegate;


     private delegate void efl_text_markup_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String markup);


     public delegate void efl_text_markup_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String markup);
     public static Efl.Eo.FunctionWrapper<efl_text_markup_set_api_delegate> efl_text_markup_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_markup_set_api_delegate>(_Module, "efl_text_markup_set");
     private static void markup_set(System.IntPtr obj, System.IntPtr pd,  System.String markup)
    {
        Eina.Log.Debug("function efl_text_markup_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((ITextMarkup)wrapper).SetMarkup( markup);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_text_markup_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  markup);
        }
    }
    private static efl_text_markup_set_delegate efl_text_markup_set_static_delegate;
}
} 
