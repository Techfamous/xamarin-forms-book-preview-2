
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace global
[<assembly: Android.Runtime.ResourceDesignerAttribute("Greetings.Droid.Resource", IsApplication=true)>]
    do ()

namespace Greetings.Droid
    // Generated by F# CodeDom
    #nowarn "49" // uppercase argument names
    #nowarn "67" // this type test or downcast will always hold
    #nowarn "66" // this upcast is unnecessary - the types are identical
    #nowarn "58" // possible incorrect indentation..
    #nowarn "57" // do not use create_DelegateEvent
    #nowarn "51" // address-of operator can occur in the code
    #nowarn "1183" // unused 'this' reference
    
    exception ReturnException13e15f5ed8ee4ff98e352b6361d78605 of obj
    exception ReturnNoneException13e15f5ed8ee4ff98e352b6361d78605
    [<AutoOpen>]
    module FuncConvertFinalOverload13e15f5ed8ee4ff98e352b6361d78605 =
      // This extension member adds to the FuncConvert type and is the last resort member in the method overloading rules. 
      type global.Microsoft.FSharp.Core.FuncConvert with
          /// A utility function to convert function values from tupled to curried form
          static member FuncFromTupled (f:'T -> 'Res) = f
    
    type
        [<System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Android.Build.Tasks", "1.0.0.0")>]
        
        (* partial *)Resource () =
            static do Android.Runtime.ResourceIdManager.UpdateIdValues()
            (* Member of type 'CodeTypeConstructor' is not supported by the CodeDOM provider and was omitted *)
            static member UpdateIdValues  () =
                global.Xamarin.Forms.Platform.Resource.String.ApplicationName <- Resource_String.ApplicationName
                global.Xamarin.Forms.Platform.Resource.String.Hello <- Resource_String.Hello


    
    and
        
        (* partial *)Resource_Attribute () =
            static do Android.Runtime.ResourceIdManager.UpdateIdValues()
            (* Member of type 'CodeTypeConstructor' is not supported by the CodeDOM provider and was omitted *)


    
    and
        
        (* partial *)Resource_Drawable () =
            static do Android.Runtime.ResourceIdManager.UpdateIdValues()
            // aapt resource value: 0x7f020000
            static member Icon = 2130837504
            (* Member of type 'CodeTypeConstructor' is not supported by the CodeDOM provider and was omitted *)


    
    and
        
        (* partial *)Resource_Id () =
            static do Android.Runtime.ResourceIdManager.UpdateIdValues()
            // aapt resource value: 0x7f050000
            static member MyButton = 2131034112
            (* Member of type 'CodeTypeConstructor' is not supported by the CodeDOM provider and was omitted *)


    
    and
        
        (* partial *)Resource_Layout () =
            static do Android.Runtime.ResourceIdManager.UpdateIdValues()
            // aapt resource value: 0x7f030000
            static member Main = 2130903040
            (* Member of type 'CodeTypeConstructor' is not supported by the CodeDOM provider and was omitted *)


    
    and
        
        (* partial *)Resource_String () =
            static do Android.Runtime.ResourceIdManager.UpdateIdValues()
            // aapt resource value: 0x7f040001
            static member ApplicationName = 2130968577
            
            // aapt resource value: 0x7f040000
            static member Hello = 2130968576
            (* Member of type 'CodeTypeConstructor' is not supported by the CodeDOM provider and was omitted *)

